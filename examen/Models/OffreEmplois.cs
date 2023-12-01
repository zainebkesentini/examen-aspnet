using examen.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examen.Models
{
    public class OffreEmplois
    {
        [Key]
        public int IdOffre{ get; set; }

        [Display(Name = "PhotoURL")]
        public string PhotoURL { get; set; }

        [Display(Name = "OffreDescription")]
        public string OffreDescription{ get; set; }
        [Display(Name = "Salaire")]
        public int Salaire { get; set; }
        [Display(Name = "DomaineTravail")]
        public DomaineTravail DomaineTravail { get; set; }
        public int IdEntreprise { get; set; }
        [ForeignKey("IdEntreprise")]
        public Entreprise Entreprises { get; set; }
        public List<DemandeOffreEntreprise> DemandesOffres { get; set; }
    }
}
