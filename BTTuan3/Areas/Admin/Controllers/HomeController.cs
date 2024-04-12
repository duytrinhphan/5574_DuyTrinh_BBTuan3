using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BTTuan3.Models;

namespace BTTuan3.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}