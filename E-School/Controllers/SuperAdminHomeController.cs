using EduSamaV4.Services;
using Microsoft.AspNetCore.Mvc;

namespace EduSamaV4.Controllers
{
    public class SuperAdminHomeController : Controller
    {
        public IActionResult Dashboard()
        {
            
            return View();
        }
    }
}
