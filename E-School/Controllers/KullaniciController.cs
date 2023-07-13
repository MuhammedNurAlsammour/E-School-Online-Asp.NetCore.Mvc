using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Kullanicilar()
        {
            return View();
        }
        
        public IActionResult Ogrenciler()
        {
            return View();
        }

        public IActionResult Ogretmenler()
        {       
            return View();
        }

        public IActionResult Mudurler()
        {       
            return View();
        }

		public IActionResult Veliler()
		{
			return View();
		}

		public IActionResult DigerPersoneller()
		{
			return View();
		}

        //Tüm controller'larda işlemlerden sonra db dispose yapılacak.

		//protected override void Dispose(bool disposing)
		//{
		//	if (disposing)
		//	{
		//		//db.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}
	}
}
