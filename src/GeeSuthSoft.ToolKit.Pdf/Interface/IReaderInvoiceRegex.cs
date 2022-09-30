using GeeSuthSoft.ToolKit.Pdf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeSuthSoft.ToolKit.Pdf.Interface
{
    public abstract class IReaderInvoiceRegex
    {

        /// <summary>
        /// Read Invoice with Custom Regex Pattern to extractor the values 
        /// </summary>
        /// <param name="filePath"> file path with extestion  </param>
        /// <param name="regexPatterns"> The Custom Regex Petterns </param>
        /// <param name="NotInterestedValues"> The Values not cared and deprecated   </param>
        /// <returns></returns>
        public abstract Task<Invoice> ReadInvoiceAsync(string filePath, RegexPatterns regexPatterns, List<string>? NotInterestedValues = null);



        /// <summary>
        /// Read Invoice with Custom Regex Pattern to extractor the values 
        /// </summary>
        /// <param name="stream"> stream pdf file   </param>
        /// <param name="regexPatterns"> The Custom Regex Petterns </param>
        /// <param name="NotInterestedValues"> The Values not cared and deprecated   </param>
        /// <returns></returns>
        public abstract Task<Invoice> ReadInvoiceAsync(Stream stream, RegexPatterns regexPatterns, List<string>? NotInterestedValues = null);



        /// <summary>
        ///  Read Invoice extractor In Json string  
        /// </summary>
        /// <param name="stream"> stream pdf file   </param>
        /// <param name="regexPatterns"> The Custom Regex Petterns </param>
        /// <param name="NotInterestedValues"> The Values not cared and deprecated   </param>
        /// <returns></returns>
        public abstract Task<string> ReadInvoiceJsonAsync(Stream stream, RegexPatterns regexPatterns, List<string>? NotInterestedValues = null);

    }
}
