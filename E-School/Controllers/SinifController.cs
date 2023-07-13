using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class SinifController : Controller
    {
        public IActionResult Siniflar()
        {
            return View();
        }

		public IActionResult SinifOlusturmaSihirbazi()
		{
			return View();
		}

		public IActionResult SinifDetay()
        {
            return View();
        }

        public IActionResult SinifOgrenci()
        {
            return View();
        }

        public IActionResult Gecmisderskayit()
        {
            return View();
        }

		public IActionResult Gecmisderskayitog()
		{
			return View();
		}

		public IActionResult KonuAnlatim()
        {
            return View();
        }

		public IActionResult KonuAnlatimDuzelt()
		{
			return View();
		}

        public IActionResult SinifSablonlari()
        {
            return View();
        }
        public IActionResult DuzSinifSablonlari()
        {
            return View();
        }
        public IActionResult SinifEklemeSablonlari()
        {
            return View();
        }
    }
}
