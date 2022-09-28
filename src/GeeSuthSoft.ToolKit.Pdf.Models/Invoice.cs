using System;
using System.Collections.Generic;

namespace GeeSuthSoft.ToolKit.Pdf.Models;

public class Invoice
{
    public Invoice()
    {
        Items = new List<InvoiceItem>();
    }
    public string? InvoiceCode { get; set; }
    public DateTime InvoiceDate { get; set; }

    public int ItemsCount { get; set; }

    public decimal? ItemsQty { get; set; }
    public string? InvoiceNote { get; set; }

    public string? InvoiceVatNo { get; set; }
    
    public string? InvoiceTotal { get; set; }

    public string? InvoiceTotalVat { get; set; }

    public List<InvoiceItem>? Items { get; set; }

    public PersonInfo Person { get; set; }

    public CreatorInfo CreatorInfo { get; set; }

}