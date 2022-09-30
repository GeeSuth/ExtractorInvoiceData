using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeSuthSoft.ToolKit.Pdf.Models
{
    public class RegexPatterns
    {
        /// <summary>
        /// Because the Improtant thing in Invoice is Items. So No All Invoice has a simple desgin for that you can send the regex pattern for items lines 
        /// </summary>
        public string RegexPatternForItemsLine { get; set; } = @"[1-9].*([A-Z]|[a-z])(.*[0-9])";

        /// <summary>
        /// To Get Dates 
        /// </summary>
        public string RegexPatternForDates { get; set; } = @"(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}( \d{1,2}[:-]\d{2}([:-]\d{2,3})*)?";



        /// <summary>
        /// To Get Vat For Person 
        /// </summary>
        public string RegexPatternForPersonVatNo { get; set; } = @"([0-9]{14})3";


        /// <summary>
        /// To Get Phone For Person 
        /// </summary>
        public string RegexPatternForPersonPhoneNo { get; set; } = @"(05|00966)([0-9]{8})";


    }
}
