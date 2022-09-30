namespace GeeSuthSoft.ToolKit.Pdf.Models;

public class InvoiceItem
{
    public int Sn { get; set; }
    public string ItemCode { get; set; }

    public string? ItemName { get; set; }
    public string? UnitName { get; set; }

    /// <summary>
    /// الكمية
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// سعر الوحدة 
    /// </summary>
    public decimal? UnitPrice { get; set; }


    /// <summary>
    /// خصم الوحدة
    /// </summary>
    public decimal? UnitDiscount { get; set; }


    /// <summary>
    /// الضريبة للوحدة
    /// </summary>
    public decimal? UnitVatAmount { get; set; }



    /// <summary>
    /// اجمالي الوحدة
    /// </summary>
    public decimal? UnitTotal { get; set; }
}