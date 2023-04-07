using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index(int id)
        {
            //viewdan id gelir taghelper s vasitesi ile
            ViewBag.Id = id;
            return View();
        }
    }
}
