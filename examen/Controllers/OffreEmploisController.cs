using examen.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace examen.Controllers
{
    public class OffreEmploisController : Controller
    {
        private readonly AppDbContext _context;
        public OffreEmploisController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {

            var allOffresEmplois = await _context.Offres.ToListAsync();
            return View(allOffresEmplois);
        }
    }
}
