using System;

namespace Domain
{
    public class Contrat 
    {
        public DateTime DateContrat;

        [Range(1,24,ErrorMessage = "Le nombre de joueur doit être compris entre 1 et 24")]

        public int DureeMois;
        public double Salaire;

        public int MembreId { get; set; }
        public Membre Membre { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }
    }
}