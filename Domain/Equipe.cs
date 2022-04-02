using System;

namespace Domain
{
    public class Equipe
    {
        public String AdresseLocal { get; set; }
        public String NomEquipe { get; set; }
        public int EquipeId { get; set; }
        public String Logo { get; set; }

        public List<Trophee> Trophees { get; set; }

        public List<Contrat> Contrats { get; set; }
    }
}