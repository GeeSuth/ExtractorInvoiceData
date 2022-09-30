using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeSuthSoft.ToolKit.Pdf.Extensions
{
    public static class ConverterExt
    {
        public static decimal? GetValue(this string value)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return 0;
            }
        }
    }
}
