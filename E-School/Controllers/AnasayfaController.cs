using EduSamaV4.Services;
using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Anasayfa()
        {
            //LanguageService LS = new LanguageService();
            //LS.SessionID = "65214";
            //HttpContext.Session.SetString("user_id", LS.SessionID);
            return View();
        }
		public IActionResult AnasayfaOgretmen()
		{
			return View();
		}
		public IActionResult AnasayfaOgrenci()
		{
			return View();
		}

        public IActionResult AnasayfaDeneme()
        {
            return View();
        }
    }
}
