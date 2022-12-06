using EverGreenMovies.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EverGreenMovies.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult>Index()
        {
            //var data = _context.Actors.ToList();
            return View(await _context.Actors.ToListAsync());
        }
    }
}
