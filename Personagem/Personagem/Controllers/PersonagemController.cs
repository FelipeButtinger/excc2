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
        [HttpPatch("vida/{id}")]
        public IActionResult PatchVida(int id, [FromBody] AtualizarVidaDTO dto)
        {
            try
            {
                _services.PatchVida(id, dto.Vida, dto.VidaExtra);
                return Ok("Vida Atualizada com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
        [HttpPatch("classe/{id}")]
        public IActionResult PatchClasse(int id, [FromBody] AtualizarClasseDTO dto)
        {
            try
            {

                _services.PatchClasse(id, dto.IdClasse, dto.IdSubClasse);
                return Ok("Classe Atualizada com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
        [HttpPatch("Atributos/{id}")]
        public IActionResult PatchAtributos(int id, [FromBody] AtualizarAtributosDTO dto)
        {
            try
            {
                _services.PatchAtributos(id, dto.Forca, dto.Destreza, dto.Constituicao, dto.Inteligencia, dto.Sabedoria,dto.Carisma);
                return Ok("Atributos Atualizados com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
        [HttpGet("vida/{id}")]
        public IActionResult GetVida(int id)
        {
            try
            {
                var record = _services.Get(id);
                var vidaTotal = record.Vida + record.VidaExtra;
                return Ok(new {Id = id,Nome = record.Nome, VidaBase = record.Vida, vidaExtra = record.VidaExtra, vidaTotal = vidaTotal});
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        [HttpGet("personagens")]
        public IActionResult Get(
            string? nome,
            int? nivel,
            int? raca,
            int? alinhamento,
            int? is_Dead,
            int? forca,
            int? destreza,
            int? constituicao,
            int? inteligencia,
            int? sabedoria,
            int? carisma
)
        {
            try
            {
                var records = _services.GetFilter(nome, nivel, raca, alinhamento, is_Dead,
                    forca, destreza, constituicao, inteligencia, sabedoria, carisma);

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
