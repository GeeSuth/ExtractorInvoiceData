using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GeeSuthSoft.ToolKit.Pdf.Extensions
{
    public static class RegexCheckerExt
    {
        public static List<string> FoundValue(this string content, string regexPattern)
        {
            if (string.IsNullOrEmpty(content)) return new List<string>();

            Regex matches = new Regex(regexPattern);
            var collection = matches.Matches(content);
            var result = new List<string>();
            foreach (var item in collection)
            {
                result.Add(item.ToString());
            }

            return result;
        }
    }
}
