namespace GeeSuthSoft.ToolKit.Pdf.Models;

public class InvoiceItem
{
    public string ItemCode { get; set; }

    public string? ItemName { get; set; }
    public string? UnitName { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitPrice { get; set; }
    public decimal? UnitDiscount { get; set; }

    public decimal? UnitTotal { get; set; }
}