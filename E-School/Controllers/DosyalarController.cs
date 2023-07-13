using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class DosyalarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dosyalar()
        {
            return View();
        }

        public IActionResult Dosya()
        {
            return View();
        }
    }
}
