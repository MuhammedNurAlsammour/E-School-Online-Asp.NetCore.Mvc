using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class DemirbasController : Controller
    {
        public IActionResult Demirbaslar()
        {
            return View();
        }
    }
}
