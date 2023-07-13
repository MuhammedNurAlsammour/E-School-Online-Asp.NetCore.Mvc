using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class ProfilController : Controller
    {
        public IActionResult PersonelProfilim()
        {
            return View();
        }

        public IActionResult OgrenciProfilim()
        {
            return View();
        }
    }
}
