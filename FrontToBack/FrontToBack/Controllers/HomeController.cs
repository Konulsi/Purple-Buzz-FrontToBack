using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderInfo> sliderInfos = await _context.SliderInfo.Include(m=>m.SliderImage).Where(m => m.SoftDelete == false).ToListAsync();

            Services services = await _context.Services.FirstOrDefaultAsync();

            IEnumerable<ResentWork> resentWorks = await _context.ResentWorks.Where(m => m.SoftDelete == false).ToListAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => m.SoftDelete == false).ToListAsync();

            IEnumerable<Work> work = await _context.Works.Include(m=>m.WorkImages).Include(m=>m.Category).Where(m => m.SoftDelete == false).ToListAsync();



            HomeVM model = new()
            {
                SliderInfos = sliderInfos,
                Services = services,
                ResentWorks = resentWorks,
                Works = work,
                Categories = categories
            };

            return View(model);
        }

     
    }
}