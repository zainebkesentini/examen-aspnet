using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examen.Models
{
    public class DemandeOffreEntreprise
    {
       

        [Key]
        public int IdDemande { get; set; }

        [Display(Name = "NomCandidat")]
        public string NomCandidat { get; set; }
        [Display(Name = "PrenomCandidat")]
        public string PrenomCandidat { get; set; }
        [Display(Name = "Telephone")]
        public int TelephoneCandidat { get; set; }
       
     

        //relationships

        public int IdOffre { get; set; }

        [ForeignKey("IdOffre")]
        public OffreEmplois OffreEmplois { get; set; }
    }
        
   
}
