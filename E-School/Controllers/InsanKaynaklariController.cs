using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class InsanKaynaklariController : Controller
    {
		public IActionResult InsanKaynaklari()
        {
            return View();
        }
		/*************************************************Izin Controller*********************************************/

		public IActionResult IzinDetay()
		{
			return View();
		}

		/*************************************************Bitti Izin Controller***************************************/


		/*************************************************Personel Controller*********************************************/
		public IActionResult PersonelEkle()
		{
			return View();
		}



		public IActionResult PersonelDetay()
        {
            return View();
        }

		/*************************************************Bitti Personel Controller***************************************/


		/*************************************************Maaş Controller*********************************************/

		public IActionResult MaasEkle()
		{
			return View();
		}


		public IActionResult MaasDetay()
        {
            return View();
        }

		/*************************************************Bitti Maaş Controller***************************************/

	}
}
