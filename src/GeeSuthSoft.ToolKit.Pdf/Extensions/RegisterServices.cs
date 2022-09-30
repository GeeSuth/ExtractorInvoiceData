using GeeSuthSoft.ToolKit.Pdf.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeSuthSoft.ToolKit.Pdf.Extensions
{
    public static class RegisterServices
    {
        public static void AddToolKitPdfRegisterService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ReaderWorker>();
            serviceCollection.AddTransient<IReaderInvoice,ReaderInvoice>();
        }
    }
}
