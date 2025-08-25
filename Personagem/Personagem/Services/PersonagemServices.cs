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
        Is_Dead = 0,
        IdClasse = 1,
        IdSubClasse = 1,
        Atributos = new Atributos {
            Forca = 16, Destreza = 14, Constituicao = 13, Inteligencia = 10, Sabedoria = 11, Carisma = 9
        }
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
        Is_Dead = 0,
        IdClasse = 1,
        IdSubClasse = 1,
        Atributos = new Atributos {
            Forca = 18, Destreza = 12, Constituicao = 16, Inteligencia = 8, Sabedoria = 10, Carisma = 11
        }
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
        Is_Dead = 0,
        IdClasse = 3,
        IdSubClasse = 3,
        Atributos = new Atributos {
            Forca = 9, Destreza = 18, Constituicao = 12, Inteligencia = 14, Sabedoria = 10, Carisma = 11
        }
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
        Is_Dead = 0,
        IdClasse = 4,
        IdSubClasse = 4,
        Atributos = new Atributos {
            Forca = 14, Destreza = 12, Constituicao = 15, Inteligencia = 11, Sabedoria = 18, Carisma = 13
        }
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
        Is_Dead = 0,
        IdClasse = 2,
        IdSubClasse = 2,
        Atributos = new Atributos {
            Forca = 10, Destreza = 12, Constituicao = 14, Inteligencia = 20, Sabedoria = 16, Carisma = 15
        }
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
        Is_Dead = 0,
        IdClasse = 5,
        IdSubClasse = 5,
        Atributos = new Atributos {
            Forca = 9, Destreza = 13, Constituicao = 12, Inteligencia = 15, Sabedoria = 18, Carisma = 14
        }
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
        Is_Dead = 0,
        IdClasse = 3,
        IdSubClasse = 3,
        Atributos = new Atributos {
            Forca = 14, Destreza = 19, Constituicao = 13, Inteligencia = 11, Sabedoria = 9, Carisma = 8
        }
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
        Is_Dead = 0,
        IdClasse = 4,
        IdSubClasse = 4,
        Atributos = new Atributos {
            Forca = 8, Destreza = 12, Constituicao = 11, Inteligencia = 16, Sabedoria = 17, Carisma = 14
        }
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
        Is_Dead = 0,
        IdClasse = 2,
        IdSubClasse = 2,
        Atributos = new Atributos {
            Forca = 11, Destreza = 13, Constituicao = 16, Inteligencia = 20, Sabedoria = 14, Carisma = 12
        }
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
        Is_Dead = 0,
        IdClasse = 5,
        IdSubClasse = 5,
        Atributos = new Atributos {
            Forca = 10, Destreza = 13, Constituicao = 14, Inteligencia = 15, Sabedoria = 18, Carisma = 16
        }
    }
};

            _classes = new List<ClasseRecord>
{
                new ClasseRecord
                {
                    IdClasse = 1,
                    Nome = "Guerreiro",
                    Descricao = "Especialista em combate corpo a corpo, com armaduras pesadas e espadas largas.",
                    Lista_Habilidades = new string[] { "Ataque Poderoso", "Defesa Implacável", "Grito de Guerra", "Investida" }
                },
                new ClasseRecord
                {
                    IdClasse = 2,
                    Nome = "Mago",
                    Descricao = "Usuário de magias arcanas, capaz de controlar os elementos e o tempo.",
                    Lista_Habilidades = new string[] { "Bola de Fogo", "Barreira Arcana", "Teleporte", "Raio Congelante" }
                },
                new ClasseRecord
                {
                    IdClasse = 3,
                    Nome = "Ladino",
                    Descricao = "Mestre da furtividade e precisão, ótimo para emboscadas e ataques críticos.",
                    Lista_Habilidades = new string[] { "Ataque Furtivo", "Esquiva Ágil", "Desarme de Armadilhas", "Sombra Silenciosa" }
                },
                new ClasseRecord
                {
                    IdClasse = 4,
                    Nome = "Clérigo",
                    Descricao = "Curandeiro divino que canaliza a luz sagrada para curar aliados e destruir mortos-vivos.",
                    Lista_Habilidades = new string[] { "Cura Divina", "Luz Purificadora", "Barreira Sagrada", "Expulsar Mortos-Vivos" }
                },
                new ClasseRecord
                {
                    IdClasse = 5,
                    Nome = "Druida",
                    Descricao = "Guardião da natureza com poderes de metamorfose e manipulação de plantas e animais.",
                    Lista_Habilidades = new string[] { "Forma Selvagem", "Chicote de Cipó", "Invocar Animais", "Enraizar" }
                }
};
            _subClasses = new List<SubClasseRecord>
{
                new SubClasseRecord
                {
                    IdSubClasse = 1,
                    Nome = "Berserker",
                    Descricao = "Subclasse do guerreiro que entra em fúria, aumentando dano e resistência momentaneamente.",
                    Lista_Habilidades = new string[] { "Fúria Implacável", "Grito Intimidador", "Resistência Brutal", "Esmagamento" }
                },
                new SubClasseRecord
                {
                    IdSubClasse = 2,
                    Nome = "Elementalista",
                    Descricao = "Subclasse do mago focada na manipulação avançada dos quatro elementos naturais.",
                    Lista_Habilidades = new string[] { "Tempestade de Fogo", "Muralha de Gelo", "Tornado", "Terremoto Arcano" }
                },
                new SubClasseRecord
                {
                    IdSubClasse = 3,
                    Nome = "Assassino das Sombras",
                    Descricao = "Subclasse do ladino especializada em abates rápidos e movimentação invisível.",
                    Lista_Habilidades = new string[] { "Lâmina Fantasma", "Desaparecer", "Ataque Mortal", "Passo Silencioso" }
                },
                new SubClasseRecord
                {
                    IdSubClasse = 4,
                    Nome = "Oráculo",
                    Descricao = "Subclasse do clérigo com dons proféticos, cura superior e manipulação do destino.",
                    Lista_Habilidades = new string[] { "Visão Profética", "Bênção Ancestral", "Reviver", "Maldição do Destino" }
                },
                new SubClasseRecord
                {
                    IdSubClasse = 5,
                    Nome = "Guardião Verde",
                    Descricao = "Subclasse do druida com foco em defesa natural, controle de terreno e proteção aliada.",
                    Lista_Habilidades = new string[] { "Casca de Carvalho", "Raízes Prisioneiras", "Aura de Renovação", "Escudo de Espinhos" }
                }
};
        }

        #region Private Properties

        /// <summary>
        /// Propriedade privada que armazenará todos os registros fixos.
        /// </summary>
        private readonly List<PersonagemRecord> _personagens;
        private readonly List<ClasseRecord> _classes;
        private readonly List<SubClasseRecord> _subClasses;

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
            if(record.Nome.Length>40) throw new Exception("O nome não pode exceder 40 caracteres.");
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
        public List<PersonagemRecord> GetFilter(
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
            int? carisma)
        {
            try
            {
                var records = _personagens.Where(e => nome != null ? e.Nome.Contains(nome) : true)
                                        .Where(e => nivel != null ? e.Nivel == nivel : true)
                                        .Where(e => raca != null ? e.Raca == (Raca)raca : true)
                                        .Where(e => alinhamento != null ? e.Alinhamento == (Alinhamento)alinhamento : true)
                                        .Where(e => is_Dead != null ? e.Is_Dead == is_Dead : true)
                                        .Where(e => forca != null ? e.Atributos?.Forca == forca : true)
                                        .Where(e => destreza != null ? e.Atributos?.Destreza == destreza : true)
                                        .Where(e => constituicao != null ? e.Atributos?.Constituicao == constituicao : true)
                                        .Where(e => inteligencia != null ? e.Atributos?.Inteligencia == inteligencia : true)
                                        .Where(e => sabedoria != null ? e.Atributos?.Sabedoria == sabedoria : true)
                                        .Where(e => carisma != null ? e.Atributos?.Carisma == carisma : true);

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
                    Is_Dead = record.Is_Dead,
                    IdClasse = record.IdClasse,
                    IdSubClasse = record.IdSubClasse,
                    Atributos = record.Atributos
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
        public void PatchVida(int id, int novaVida, int novaVidaExtra)
        {
            var personagem = _personagens.FirstOrDefault(p => p.IdPersonagem == id);

            if (personagem == null)
                throw new Exception("Personagem não encontrado.");

            if (novaVida == 0 && novaVidaExtra != 0)
            {
                personagem.Is_Dead = 1;
            }
            else
            {
                personagem.Is_Dead = 0;
            }
                // Atualiza só os campos de vida
                personagem.Vida = novaVida;
            personagem.VidaExtra = novaVidaExtra;
        }
        public void PatchClasse(int id, int novaClasseId, int novaSubClasseId)
        {
            var personagem = _personagens.FirstOrDefault(p => p.IdPersonagem == id);
            var novaClasse = _classes.FirstOrDefault(c => c.IdClasse == novaClasseId);
            var novaSubClasse = _subClasses.FirstOrDefault(s => s.IdSubClasse == novaSubClasseId);
            if (personagem == null)
                throw new Exception("Personagem não encontrado.");
            else if(novaClasse == null)
                throw new Exception("Classe não encontrada.");
            else if(novaSubClasse == null)
                throw new Exception("Sub-Classe não encontrada.");

            personagem.IdClasse = novaClasseId;
            personagem.IdSubClasse = novaSubClasseId;
        }
        public void PatchAtributos(int id, int novaForca, int novaDestreza, int novaConstituicao, int novaInteligencia, int novaSabedoria, int novoCarisma)
        {
            var personagem = _personagens.FirstOrDefault(p => p.IdPersonagem == id);

            if (personagem == null)
                throw new Exception("Personagem não encontrado.");


            personagem.Atributos.Forca = novaForca;
            personagem.Atributos.Destreza = novaDestreza;
            personagem.Atributos.Constituicao = novaConstituicao;
            personagem.Atributos.Inteligencia = novaInteligencia;
            personagem.Atributos.Sabedoria = novaSabedoria;
            personagem.Atributos.Carisma = novoCarisma;

        }

        #endregion Public Methods

    }
}
