using System;

namespace Domain
{
    public class Membre
    {
        public int Identifiant { get; set; }
        
        [DataType(DataType.Date)]

        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "Nom est obligatoire.")]

        public string Nom { get; set; }
        [Required(ErrorMessage = "Prenom est obligatoire.")]

        public string Prenom { get; set; }

        public List<Contrat> Contrats { get; set; }
    }
}