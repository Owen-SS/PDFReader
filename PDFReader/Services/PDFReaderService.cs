using Microsoft.AspNetCore.Mvc;
using PDFReader.Controllers;
using PDFReader.Models;




using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Colorspace;
using iText.Kernel.Pdf.Canvas.Parser;
using System.Text;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace PDFReader.Services
{
    public class PDFReaderService
    {
        public static PDF ReadPdf()
        {
            var src = "Enter PDF Path here";
            var pdfDocument = new PdfDocument(new PdfReader(src));
            var strategy = new SimpleTextExtractionStrategy();

            StringBuilder processed = new StringBuilder();

            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); ++i)
            {
                var page = pdfDocument.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page, strategy);
                processed.Append(text);
            }

            return new PDF { 
                Words = processed.ToString().Split(' ') 
            };
        }
    }
}
