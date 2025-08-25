using Personagem.Models;

namespace Personagem.Services
{
    public class PersonagemServices
    {

        // Construtor da minha services, que inicializa uma lista fixa de criaturas que será acessada pelo Controller e pelos métodos da Service.
        public PersonagemServices()
        {
            _personagens = new List<PersonagemRecord>
            {
                new PersonagemRecord {
                    IdPersonagem = 1,
                    Nome = "Kael'thor, o Lâmina de Prata",
                    Raca = Raca.ELFO,
                    Nivel = 12,
                    Xp = 18500,
                    Vida = 98,
                    VidaExtra = 15,
                    Alinhamento = Alinhamento.LEAL_E_BOM,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 2,
                    Nome = "Thorgun Punho de Pedra",
                    Raca = Raca.DRACÔNICO,
                    Nivel = 10,
                    Xp = 14200,
                    Vida = 120,
                    VidaExtra = 10,
                    Alinhamento = Alinhamento.NEUTRO,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 3,
                    Nome = "Nyssa Sombrasangue",
                    Raca = Raca.ARACNIDEO,
                    Nivel = 8,
                    Xp = 9700,
                    Vida = 68,
                    VidaExtra = 20,
                    Alinhamento = Alinhamento.CAÓTICO_E_NEUTRO,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 4,
                    Nome = "Sir Elandor, Escudo da Luz",
                    Raca = Raca.HUMANO,
                    Nivel = 15,
                    Xp = 24500,
                    Vida = 110,
                    VidaExtra = 25,
                    Alinhamento = Alinhamento.LEAL_E_BOM,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 5,
                    Nome = "Az'Karum, o Quebrador de Reinos",
                    Raca = Raca.SERAFIM,
                    Nivel = 20,
                    Xp = 40000,
                    Vida = 200,
                    VidaExtra = 50,
                    Alinhamento = Alinhamento.CAÓTICO_E_MAU,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 6,
                    Nome = "Velmira da Névoa Eterna",
                    Raca = Raca.ESTELAR,
                    Nivel = 14,
                    Xp = 19800,
                    Vida = 85,
                    VidaExtra = 40,
                    Alinhamento = Alinhamento.NEUTRO_E_BOM,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 7,
                    Nome = "Graxor, o Vazio Andante",
                    Raca = Raca.ARACNIDEO,
                    Nivel = 18,
                    Xp = 32000,
                    Vida = 170,
                    VidaExtra = 35,
                    Alinhamento = Alinhamento.CAÓTICO_E_NEUTRO,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 8,
                    Nome = "Mirael, Cantora dos Espíritos",
                    Raca = Raca.ELFO,
                    Nivel = 11,
                    Xp = 16000,
                    Vida = 75,
                    VidaExtra = 30,
                    Alinhamento = Alinhamento.NEUTRO_E_BOM,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 9,
                    Nome = "Zarnak, o Sem Rosto",
                    Raca = Raca.DRACÔNICO,
                    Nivel = 22,
                    Xp = 45000,
                    Vida = 220,
                    VidaExtra = 60,
                    Alinhamento = Alinhamento.LEAL_E_MAU,
                    Is_Dead = 0
                },
                new PersonagemRecord {
                    IdPersonagem = 10,
                    Nome = "Tilda dos Ventos Sagrados",
                    Raca = Raca.SERAFIM,
                    Nivel = 19,
                    Xp = 38000,
                    Vida = 130,
                    VidaExtra = 45,
                    Alinhamento = Alinhamento.LEAL_E_NEUTRO,
                    Is_Dead = 0
                }
            };
        }

        #region Private Properties

        /// <summary>
        /// Propriedade privada que armazenará todos os registros fixos.
        /// </summary>
        private readonly List<PersonagemRecord> _personagens;

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// Responsável pelas validações de dados nos métodos de Create e Update.
        /// </summary>
        /// <param name="record">Objeto com as informações vindas do Swagger/Postman</param>
        /// <param name="isUpdate">Informa se estou chamado o método para Create ou Update pois algumas validações só fazem sentido para um ou para outro</param>
        /// <exception cref="Exception">Exceções que serão jogadas caso algum dos parâmetros estiver inválido</exception>
        private static void ValidateParams(PersonagemRecord record, bool isUpdate)
        {
            if (record == null) throw new Exception("Dados inválidos.");

            if (record.IdPersonagem <= 0) throw new Exception("O identificador 'IdPersonagem' não pode estar vazio/zerado.");

            if (record.Nome == null) throw new Exception("O campo 'Nome' é obrigatório.");
            if (record.Nivel <= 0) throw new Exception("O campo 'Nível' é obrigatório e não pode ser menor que zero.");
            if (record.Xp < 0) throw new Exception("O campo 'Xp' é obrigatório e não pode ser menor que zero.");
            if (record.Raca < 0) throw new Exception("O campo 'Raça' é obrigatório.");
            if (record.Alinhamento < 0) throw new Exception("O campo 'Alinhamento' é obrigatório.");

            if (record.Vida < 0) throw new Exception("O campo 'Vida' é obrigatório e não pode ser menor que zero.");
            if (record.Is_Dead < 0) throw new Exception("O campo 'Is_Dead' é obrigatório e não pode ser menor que zero.");

        }

        #endregion Private Methods

        #region Public Methods

        /// <summary>
        /// Este método retornará a lista de registros completa sem filtragem
        /// </summary>
        /// <returns>Estrutura <see cref="List{T}"/> com todos os registros</returns>
        public List<PersonagemRecord> GetList()
        {
            try
            {
                return _personagens;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Busca um registro único com base no ID informado
        /// </summary>
        /// <param name="id">ID a ser pesquisado</param>
        /// <returns>Registro do tipo <see cref="PersonagemRecord"/></returns>
        public PersonagemRecord Get(int id)
        {
            try
            {
                var record = _personagens.FirstOrDefault(e => e.IdPersonagem == id);

                if (record == null) throw new Exception("Nenhum registro encontrado com este ID.");
                return record;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Filtra a lista de criaturas com base em diversos campos opcionais
        /// </summary>
        /// <
        /// <returns>Estrutura <see cref="List{T}"/> com todos os registros filtrados ou uma exeção caso não encontre nenhum registro.</returns>
        public List<PersonagemRecord> GetFilter(string? nome, int? nivel, int? raca, int? alinhamento)
        {
            try
            {
                var records = _personagens.Where(e => nome != null ? e.Nome.Contains(nome) : true)
                                        .Where(e => nivel != null ? e.Nivel == nivel : true)
                                        .Where(e => raca != null ? e.Raca == (Raca)raca : true)
                                        .Where(e => alinhamento != null ? e.Alinhamento == (Alinhamento)alinhamento : true);

                if (records == null || records.Count() == 0) throw new Exception("Nenhum registro encontrado com esta filtragem.");
                return records.ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Cria um registro de criatura na lista já existente.
        /// </summary>
        /// <param name="record">Registro preenchido</param>
        public void Create(PersonagemRecord record)
        {
            try
            {
                ValidateParams(record, false);

                // Gerar novo ID
                int novoId = _personagens.Max(p => p.IdPersonagem) + 1;
                record.IdPersonagem = novoId;

                _personagens.Add(record);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Atualiza um registro já existente com base no ID encontrado
        /// </summary>
        /// <param name="record">Registro preenchido</param>
        public void Update(PersonagemRecord record)
        {
            try
            {
                ValidateParams(record, true);

                int foundIndex = _personagens.FindIndex(e => e.IdPersonagem == record.IdPersonagem);
                if (foundIndex == -1) throw new Exception("Registro não encontrado com este ID.");

                _personagens[foundIndex] = new PersonagemRecord
                {

                    IdPersonagem = record.IdPersonagem,
                    Nome = record.Nome,
                    Raca = record.Raca,
                    Nivel = record.Nivel,
                    Xp = record.Xp,
                    Vida = record.Vida,
                    VidaExtra = record.VidaExtra,
                    Alinhamento = record.Alinhamento,
                    Is_Dead = record.Is_Dead
                };
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// Exclui um registro
        /// </summary>
        /// <param name="id">ID a ser excluído</param>
        public void Delete(int idPersonagem)
        {
            try
            {
                int foundIndex = _personagens.FindIndex(e => e.IdPersonagem == idPersonagem);
                if (foundIndex == -1) throw new Exception("Nenhum registro encontrado com este ID.");

                _personagens.RemoveAt(foundIndex);
            }
            catch
            {
                throw;
            }
        }

        #endregion Public Methods

    }
}
