using System;

namespace Domain
{
    public class Trophee
    {
        public int TropheeId { get; set; }
        public string TypeTrophee { get; set; }

        [DataType(DataType.Date)]
        
        public DateTime DateTrophee { get; set; }

        [DataType(DataType.Currency)]
        public double Recomponse { get; set; }

        [ForeignKey("EquipeFK")]
        public int? EquipeFK { get; set; }
        public Equipe Equipe { get; set; }
       
    }

}