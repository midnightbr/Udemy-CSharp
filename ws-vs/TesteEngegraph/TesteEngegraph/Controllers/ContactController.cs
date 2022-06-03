using Microsoft.AspNetCore.Mvc;

namespace TesteEngegraph.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
