using System.Text;
using GeeSuthSoft.ToolKit.Pdf.Models;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace GeeSuthSoft.ToolKit.Pdf;

public class ReaderWorker
{

    private readonly ReaderWorkerBase _readerWorkderBase = new();
    
    public async Task<Invoice> GetInvoiceAsync(Stream stream , List<string>? NotInterested = null)
    {
        var result = new Models.Invoice();
        try
        {
            var text = await _readerWorkderBase.ReadInvoiceBase(stream);

            var analayze = new AnalyzeText(NotInterested);

            if(await analayze.IsInvoice(text))
            {
                // Date
                var date = analayze.GetDates(text);
                result.InvoiceDate =date[0];


                // Get Person Info 
                result.Person = await analayze.GetPersonInfo(text);

                // Items 
                result.Items = await analayze.GetItems(text);
            }
            else
            {
                return null;
            }

        }
        catch (Exception ex)
        {

        }

        return result;
    }


    public async Task<Invoice> GetInvoiceAsync(Stream stream, RegexPatterns regexPatterns, List<string>? NotInterested = null)
    {
        var result = new Models.Invoice();
        try
        {
            var text = await _readerWorkderBase.ReadInvoiceBase(stream);

            var analayze = new AnalyzeText(regexPatterns , NotInterested);

            if (await analayze.IsInvoice(text))
            {
                // Date
                var date = analayze.GetDates(text);
                result.InvoiceDate = date[0];


                // Get Person Info 
                result.Person = await analayze.GetPersonInfo(text);

                // Items 
                result.Items = await analayze.GetItems(text);
            }
            else
            {
                return null;
            }

        }
        catch (Exception ex)
        {

        }

        return result;
    }


    public async Task<string> GetInvoiceStringAsync(Stream stream)
    {
        return await _readerWorkderBase.ReadInvoiceBase(stream);
    }



}