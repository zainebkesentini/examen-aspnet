using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace examen.Models
{
    public class Entreprise
    {
        [Key]
        public int IdEntreprise { get; set; }
        [Display(Name ="PhotoURL")]

        public string PhotoURL { get; set; }

        [Display(Name = "NomEntreprise")]
        public string NomEntreprise { get; set; }
        [Display(Name = "Localisation")]
        public string Localisation { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        [Display(Name = "Telephone")]
        public int Telephone { get; set; }
        [Display(Name = "Email")]

        
         public string Email {  get; set; }
       
        //relation 
        public List<OffreEmplois> Offres { get; set; }
     




    }
}
