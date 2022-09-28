using GeeSuthSoft.ToolKit.Pdf.Interface;
using GeeSuthSoft.ToolKit.Pdf.Models;

namespace GeeSuthSoft.ToolKit.Pdf;

public class Read : IReaderInvoice
{
    private readonly ReaderWorker _readWorker;
    public Read(ReaderWorker readworker)
    {
        _readWorker = readworker;
    }

    public async Task<Invoice> ReadInvoiceAsync(string filePath)
    {
        throw new NotImplementedException();
    }

    public async Task<Invoice> ReadInvoiceAsync(Stream stream)
    {
        return await _readWorker.GetInvoice(stream);
    }
}