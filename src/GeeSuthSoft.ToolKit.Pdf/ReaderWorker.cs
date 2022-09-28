using System.Text;
using GeeSuthSoft.ToolKit.Pdf.Models;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace GeeSuthSoft.ToolKit.Pdf;

public class ReaderWorker
{
    public async Task<Invoice> GetInvoice(Stream stream)
    {
        var result = new Models.Invoice();
        try
        {
            var pdfDocument = new iText.Kernel.Pdf.PdfDocument(new PdfReader(stream));
	        StringBuilder processed = new StringBuilder();
	        var strategy = new LocationTextExtractionStrategy();
	        string text = "";
	        for (int i = 1; i <= pdfDocument.GetNumberOfPages(); ++i)
	        {
	            var page = pdfDocument.GetPage(i);
	            text += PdfTextExtractor.GetTextFromPage(page, strategy);
	            processed.Append(text);
	        }
	        //var lines= text.Split('\n');

            if(await AnalyzeText.IsInvoice(text))
            {
                // Date
                var date = await AnalyzeText.GetDates(text);
                result.InvoiceDate = DateTime.Parse(date[0]);



                //
            }

        }
        catch (Exception ex)
        {

        }

        return result;
    }
}