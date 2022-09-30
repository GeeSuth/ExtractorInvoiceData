using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeSuthSoft.ToolKit.Pdf
{
    internal class ReaderWorkerBase
    {
        public async Task<string> ReadInvoiceBase(Stream stream)
        {

            try
            {
                var pdfDocument = new iText.Kernel.Pdf.PdfDocument(new PdfReader(stream));
                StringBuilder processed = new StringBuilder();
                var strategy = new LocationTextExtractionStrategy();
                //strategy.SetRightToLeftRunDirection(true);
                strategy.SetUseActualText(true);
                string text = "";
                for (int i = 1; i <= pdfDocument.GetNumberOfPages(); ++i)
                {
                    var page = pdfDocument.GetPage(i);
                    text += PdfTextExtractor.GetTextFromPage(page, strategy);
                    processed.Append(text);
                }


                return text;



            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
