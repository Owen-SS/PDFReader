using Microsoft.AspNetCore.Mvc;
using PDFReader.Models;
using PDFReader.Services;

namespace PDFReader.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var pdfData = PDFReaderService.ReadPdf();
            return View(pdfData);
        }
    }

}
