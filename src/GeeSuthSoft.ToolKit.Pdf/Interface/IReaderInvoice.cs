using GeeSuthSoft.ToolKit.Pdf.Models;

namespace GeeSuthSoft.ToolKit.Pdf.Interface;

public interface IReaderInvoice
{
    Task<Invoice> ReadInvoiceAsync(string filePath);
    Task<Invoice> ReadInvoiceAsync(Stream stream);

}