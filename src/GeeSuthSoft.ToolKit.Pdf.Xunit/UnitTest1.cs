using Xunit;
using GeeSuthSoft.ToolKit.Pdf.Interface;
using System.IO;
using GeeSuthSoft.ToolKit.Pdf.Models;

namespace GeeSuthSoft.ToolKit.Pdf.Xunit;

public class UnitTest1
{
    private readonly IReaderInvoice readerInvoice;

    public UnitTest1()
    {
        readerInvoice = new ReaderInvoice(new ReaderWorker());
    }
    

    [Fact]
    public async void Test1()
    {
        var st = new StreamReader(@"C:/Users/GeeSuth-Acer/Desktop/Temp/pdf/bin/Debug/net6.0/t2.pdf");
        var tt = await readerInvoice.ReadInvoiceAsync(st.BaseStream);
        Assert.NotNull(tt);
        Assert.NotNull(tt.InvoiceDate);
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(tt);
        Assert.NotNull(json);
    }


    [Fact]
    public async void TestUseCustomRegex()
    {
        var st = new StreamReader(@"C:/Users/GeeSuth-Acer/Desktop/Temp/pdf/bin/Debug/net6.0/t4.pdf");
        var tt = await readerInvoice.ReadInvoiceAsync(st.BaseStream, 
            new RegexPatterns() 
            { 
               RegexPatternForItemsLine=@""
            }
            );
        Assert.NotNull(tt);
        Assert.NotNull(tt.InvoiceDate);
    }


    [Fact]
    public async void Test2()
    {
        var st = new StreamReader(@"C:/Users/GeeSuth-Acer/Desktop/Temp/pdf/bin/Debug/net6.0/t3.PDF");
        var tt = await readerInvoice.ReadInvoiceAsync(st.BaseStream);
        Assert.NotNull(tt);
        Assert.NotNull(tt.InvoiceDate);
    }


    [Fact]
    public async void Test3()
    {
        var st = new StreamReader(@"C:/Users/GeeSuth-Acer/Desktop/Temp/pdf/bin/Debug/net6.0/t4.PDF");
        var tt = await readerInvoice.ReadInvoiceStringAsync(st.BaseStream);
        Assert.NotNull(tt);
        //Assert.NotNull(tt.InvoiceDate);
    }
}