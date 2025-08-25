namespace Personagem.Models
{
    public class PersonagemRecord
    {
        public int IdPersonagem { get; set; }

        public required string Nome { get; set; }

        public required Raca Raca { get; set; }

        public int Nivel { get; set; }

        public int Xp { get; set; }

        public int Vida { get; set; }

        public int VidaExtra { get; set; }

        public required Alinhamento Alinhamento { get; set; }

        public int Is_Dead { get; set; }

        public required int IdClasse { get; set; }
         
        public int IdSubClasse { get; set; }

        public Atributos Atributos { get; set; }

        public PersonagemRecord()
        {
            IdPersonagem = 0;
            Nome = "";
            Raca = Raca.HUMANO;
            Nivel = 1;
            Xp = 0;
            Vida = 1;
            VidaExtra = 1;
            Alinhamento = Alinhamento.NEUTRO;
            Is_Dead = 0;
            IdClasse = 0;
            IdSubClasse = 0;
        }
    }

    public class ClasseRecord
    {
        public int IdClasse { get; set; }

        public required string Nome { get; set; }

        public required string Descricao { get; set; }

        public required string[] Lista_Habilidades { get; set; }

        public ClasseRecord()
        {
            IdClasse = 0;
            Nome = "";
            Descricao = "";
            Lista_Habilidades = [];
        }
    }
    public class SubClasseRecord
    {
        public int IdSubClasse { get; set; }

        public required string Nome { get; set; }

        public required string Descricao { get; set; }

        public required string[] Lista_Habilidades { get; set; }

        public SubClasseRecord()
        {
            IdSubClasse = 0;
            Nome = "";
            Descricao = "";
            Lista_Habilidades = [];
        }
    }
    public class Atributos
    {
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }
    }
    public enum Raca
    {
        DRACÔNICO = 0,
        ELFO = 1,
        ARACNIDEO = 2,
        SERAFIM = 3,
        HUMANO = 4,
        ESTELAR = 5
    }

    public enum Alinhamento
    {
        LEAL_E_BOM = 0,
        LEAL_E_NEUTRO = 1,
        LEAL_E_MAU = 2,
        NEUTRO_E_BOM = 3,
        NEUTRO = 4,
        NEUTRO_E_MAU = 5,
        CAÓTICO_E_BOM = 6,
        CAÓTICO_E_NEUTRO = 7,
        CAÓTICO_E_MAU = 8
    }
}
    public class AtualizarVidaDTO
    {
        public int Vida { get; set; }

        public int VidaExtra { get; set; }
    }
    public class AtualizarClasseDTO
    {
        public required int IdClasse { get; set; }

        public int IdSubClasse { get; set; }
    }
    public class AtualizarAtributosDTO
    {
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }
    }
