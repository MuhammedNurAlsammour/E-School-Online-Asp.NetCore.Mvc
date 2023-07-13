using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class KutuphaneController : Controller
    {
        public IActionResult Kutuphane()
        {
            return View();
        }

        public IActionResult KategoriDetay()
        {
            return View();
        }

        [HttpPost]
        public string TestUpload(List<IFormFile> filepond, string text)
        {
            return "1";
        }
    }
}