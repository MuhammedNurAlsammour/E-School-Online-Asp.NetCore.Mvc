using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    [AllowAnonymous]
    public class UyelikController : Controller
    {
        public IActionResult Giris()
        {
            return View();
        }
    }
}
