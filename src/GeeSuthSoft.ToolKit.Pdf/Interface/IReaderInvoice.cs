using GeeSuthSoft.ToolKit.Pdf.Models;

namespace GeeSuthSoft.ToolKit.Pdf.Interface;

public abstract class IReaderInvoice : IReaderInvoiceRegex
{
    public readonly ReaderWorker _readWorker;
    public IReaderInvoice(ReaderWorker readworker)
    {
        _readWorker = readworker;
    }


    /// <summary>
    /// Read Invoice extractor the values 
    /// </summary>
    /// <param name="filePath"> file path with extestion  </param>
    /// <param name="NotInterestedValues"> The Values not cared and deprecated   </param>
    /// <returns></returns>
    public abstract Task<Invoice> ReadInvoiceAsync(string filePath, List<string>? NotInterestedValues = null);


    /// <summary>
    /// Read Invoice extractor the values 
    /// </summary>
    /// <param name="stream"> stream pdf file  </param>
    /// <param name="NotInterestedValues"> The Values not cared and deprecated   </param>
    /// <returns></returns>
    public abstract Task<Invoice> ReadInvoiceAsync(Stream stream , List<string>? NotInterestedValues = null);



    /// <summary>
    /// Read Invoice extractor string 
    /// </summary>
    /// <param name="stream"> stream pdf file  </param>
    /// <returns></returns>
    public abstract Task<string> ReadInvoiceStringAsync(Stream stream);


    /// <summary>
    /// Read Invoice extractor string 
    /// </summary>
    /// <param name="fileName"> fileName for pdf  </param>
    /// <returns></returns>
    public abstract Task<string> ReadInvoiceStringAsync(string fileName);




}