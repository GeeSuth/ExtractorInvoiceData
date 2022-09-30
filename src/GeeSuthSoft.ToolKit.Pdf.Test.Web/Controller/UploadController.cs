using GeeSuthSoft.ToolKit.Pdf.Interface;
using GeeSuthSoft.ToolKit.Pdf.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeeSuthSoft.ToolKit.Pdf.Test.Web.Controller
{
    [Route("upload")]
    [Produces("application/json")]
    public class UploadController : ControllerBase
    {

        private readonly IReaderInvoice _readerInvoice;
        public UploadController(IReaderInvoice readerInvoice)
        {
            _readerInvoice = readerInvoice;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test");
        }


        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            var tt = new RegexPatterns() 
            { 
                RegexPatternForDates="",
                RegexPatternForItemsLine = "", 
                RegexPatternForPersonPhoneNo ="" , 
                RegexPatternForPersonVatNo =""
            };

            return Content(await _readerInvoice.ReadInvoiceJsonAsync(file.OpenReadStream(), new Models.RegexPatterns()),"application/json");
        }

    }
}
