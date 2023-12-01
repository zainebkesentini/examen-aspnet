using examen.Models;

namespace examen.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
using (var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
               //Entreprise 
               if (!context.Entreprises.Any())
                {
                    
                    
                 }
               if(!context.Offres.Any
                    ())
                {

                }
               if (context.Demandes.Any())
                {

                }
            }
        }
    }
}
