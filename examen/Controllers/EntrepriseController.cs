using examen.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace examen.Controllers
{
    public class EntrepriseController : Controller
    { 
        private readonly AppDbContext _context ;
        public EntrepriseController(AppDbContext context)

        {
            _context = context;            
        }
        public  async Task<ActionResult> Index()
        { 
          var data = await _context.Offres.ToListAsync();
            return View(data);
        }
    }
}
