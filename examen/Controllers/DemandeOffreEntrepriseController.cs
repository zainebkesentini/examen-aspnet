using examen.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace examen.Controllers
{
    public class DemandeOffreEntrepriseController : Controller
    {
        private readonly AppDbContext _context;
        public DemandeOffreEntrepriseController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {

            var allDemandes = await _context.Offres.ToListAsync();
            return View(allDemandes);
        }
    }
}
