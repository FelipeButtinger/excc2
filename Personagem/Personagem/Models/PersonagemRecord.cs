namespace Personagem.Models
{
    public class PersonagemRecord
    {
        public int IdPersonagem { get; set; }

        public required string Nome { get; set; }

        public required Raca Raca { get; set; }

        public int ClasseId { get; set; } // FK "Classe"

        public int SubClasseId { get; set; } // FK classe "SubClasse"

        public int Nivel { get; set; }

        public int Xp { get; set; }

        public int Vida { get; set; }

        public int VidaExtra { get; set; }

        public required Alinhamento Alinhamento { get; set; }

        public int Is_Dead { get; set; }

        public PersonagemRecord()
        {
            IdPersonagem = 0;
            Nome = "";
            Raca = Raca.HUMANO;
            ClasseId = 0;
            SubClasseId = 0;
            Nivel = 1;
            Xp = 0;
            Vida = 1;
            VidaExtra = 1;
            Alinhamento = Alinhamento.NEUTRO;
            Is_Dead = 0;
        }
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
