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
    public string InvoiceDate { get; set; }

    public int ItemsCount { get => this.Items.Count; }

    public decimal? ItemsQty { get => this.Items.Sum(s=>s.Qty); }
    public string? InvoiceNote { get; set; }

    public string? InvoiceVatNo { get => this.Person.PersonVatNo; }
    
    public decimal? InvoiceTotal { get => this.Items.Sum(s=>s.UnitTotal);  }

    public decimal? InvoiceTotalVat { get => this.Items.Sum(s=>s.UnitVatAmount); }

    public List<InvoiceItem>? Items { get; set; }

    public PersonInfo Person { get; set; }

    public CreatorInfo CreatorInfo { get; set; }

}