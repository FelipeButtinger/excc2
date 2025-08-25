using Microsoft.AspNetCore.Mvc;
using Personagem.Models;
using Personagem.Services;

namespace Personagem.Controllers
{
    [ApiController]
    [Route("api/personagem")]
    public class PersonagemController : Controller
    {

        #region Constructor

        public PersonagemController(PersonagemServices services)
        {
            _services = services;
        }

        #endregion Constructor

        #region Private Properties

        private PersonagemServices _services;

        #endregion Private Properties

        #region Endpoints

        [HttpGet]
        public IEnumerable<PersonagemRecord> Get()
        {
            return _services.GetList();
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var record = _services.Get(id);

                return Ok(record);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }



        [HttpGet("personagens")]
        public IActionResult Get(string? nome, int? nivel, int? raca, int? alinhamento)
        {
            try
            {
                var records = _services.GetFilter(nome, nivel, raca, alinhamento);
                return Ok(records);
            }
            catch
            {
                return StatusCode(500);
            }
        }



        [HttpPost]
        public IActionResult Create([FromBody] PersonagemRecord record)
        {
            try
            {
                _services.Create(record);

                return Created();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpPut]
        public IActionResult Update([FromBody] PersonagemRecord record)
        {
            try
            {
                _services.Update(record);

                return Ok("Registro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _services.Delete(id);

                return Ok("Registro excluído com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        #endregion Endpoints

    }
}
