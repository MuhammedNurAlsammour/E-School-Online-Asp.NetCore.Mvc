using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class SubeController : Controller
    {
        public IActionResult Subeler()
        {
            return View();
        }

        public IActionResult SubeDetay()
        {
            return View();
        }

        public string SubeEkle()
        {
            //Şube eklendikten sonra atanan müdüre mail gidecek. "...... adlı şubesine müdür olarak atandınız. Giriş yapmak için tıklayınız."
            return "1";
        }
    }
}
