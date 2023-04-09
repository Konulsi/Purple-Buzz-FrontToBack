using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {

            AboutUs aboutUs = await _context.AboutUs.FirstOrDefaultAsync();


            IEnumerable<TeamMember> teamMembers = await _context.TeamMembers.Include(m => m.Team).Where(m => m.SoftDelete == false).ToListAsync();



            AboutVM model = new()
            {
                AboutUs = aboutUs,
                TeamMembers= teamMembers
            };

            return View(model);
        }
    }
}
