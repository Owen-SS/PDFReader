using Microsoft.AspNetCore.Mvc;

namespace PDFReader.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
