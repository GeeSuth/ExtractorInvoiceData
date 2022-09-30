using GeeSuthSoft.ToolKit.Pdf.Models;
using GeeSuthSoft.ToolKit.Pdf.Extensions;


namespace GeeSuthSoft.ToolKit.Pdf;

public class AnalyzeText
{

    List<string> _notInterested = new List<string>();
    RegexPatterns _regexPatterns = new();

    public AnalyzeText(RegexPatterns regexPatterns , List<string>? NotInterested)
    {
        if (NotInterested == null)
        {
            _notInterested = new List<string>();
        }
        else
        {
            _notInterested = NotInterested;
        }

        _regexPatterns = regexPatterns;
    }

    public AnalyzeText(List<string>? NotInterested)
    {
        if(NotInterested == null)
        {
            _notInterested = new List<string>();
        }
        else
        {
            _notInterested = NotInterested;
        }

        
    }

    public async Task<bool> IsInvoice(string content)
    {
        //Check if the content has a date 
        if (!GetDates(content).Any())
            return false;




        return true;

    }
    public List<string> GetDates(string content)
    {
        return content.FoundValue(_regexPatterns.RegexPatternForDates)
            .Where(w=> !_notInterested.Contains(w))
            .ToList();
    }

    public async  Task<PersonInfo> GetPersonInfo(string content)
    {
        return new PersonInfo()
        {
            PersonVatNo = content.FoundValue(_regexPatterns.RegexPatternForPersonVatNo).Where(w=> !_notInterested.Contains(w)).FirstOrDefault(),
            PersonPhone = content.FoundValue(_regexPatterns.RegexPatternForPersonPhoneNo).Where(w => !_notInterested.Contains(w)).FirstOrDefault(),

        };
    }

    public async Task<CreatorInfo> GetCreatorInfo(string content)
    {
        throw new NullReferenceException();
    }

    public async Task<List<InvoiceItem>> GetItems(string content)
    {
        var result = new List<InvoiceItem>();
        var items = content.FoundValue(_regexPatterns.RegexPatternForItemsLine);
        foreach (var row in items)
        {
            try
            {
                var splitedLine = row.Split(" ");
                // TODO : Make this work using length
                if (splitedLine.Length == 5)
                {
                    // Templete without discount for unit

                }

                var item = new InvoiceItem();

                //Sn
                item.Sn = int.Parse(splitedLine[0]);


                //ItemCode
                item.ItemCode = splitedLine[1];


                // Qty 
                item.Qty = splitedLine[2].GetValue();



                // UnitPrice 
                item.UnitPrice = splitedLine[3].GetValue();


                // Vat Amount
                item.UnitVatAmount = splitedLine[4].GetValue();


                // Total Amount 
                item.UnitTotal = splitedLine[5].GetValue();





                result.Add(item);
            }
            catch
            {
            }
        }


        return result;
    }
}