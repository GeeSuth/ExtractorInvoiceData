using GeeSuthSoft.ToolKit.Pdf.Interface;
using GeeSuthSoft.ToolKit.Pdf.Models;

namespace GeeSuthSoft.ToolKit.Pdf;

public class ReaderInvoice : IReaderInvoice
{

    public ReaderInvoice(ReaderWorker readworker) : base(readworker)
    {

    }


    public override async Task<Invoice> ReadInvoiceAsync(string filePath, List<string>? NotInterested = null)
    {
        var stream = new StreamReader(filePath).BaseStream;
        return await _readWorker.GetInvoiceAsync(stream, NotInterested);
    }

    public override async Task<Invoice> ReadInvoiceAsync(Stream stream, List<string>? NotInterested = null)
    {
        return await _readWorker.GetInvoiceAsync(stream , NotInterested);
    }

    public override async Task<Invoice> ReadInvoiceAsync(string filePath, RegexPatterns regexPatterns, List<string>? NotInterestedValues = null)
    {
        var st = new StreamReader(filePath);
        return await _readWorker.GetInvoiceAsync(st.BaseStream, regexPatterns,NotInterestedValues);
    }

    public override async Task<Invoice> ReadInvoiceAsync(Stream stream, RegexPatterns regexPatterns, List<string>? NotInterestedValues = null)
    {
        return await _readWorker.GetInvoiceAsync(stream, regexPatterns, NotInterestedValues);
    }

    public override async Task<string> ReadInvoiceJsonAsync(Stream stream, RegexPatterns regexPatterns, List<string>? NotInterestedValues = null)
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject( await this.ReadInvoiceAsync(stream,regexPatterns,NotInterestedValues));
    }

    public override async Task<string> ReadInvoiceStringAsync(Stream stream)
    {
        return await _readWorker.GetInvoiceStringAsync(stream);
    }

    public override async Task<string> ReadInvoiceStringAsync(string fileName)
    {
        var st = new StreamReader(fileName);
        return await _readWorker.GetInvoiceStringAsync(st.BaseStream);
    }
}