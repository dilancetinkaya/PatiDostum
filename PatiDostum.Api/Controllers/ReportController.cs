using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        [HttpGet("filter")]
        public IActionResult GetStartFinish(DateTime? start, DateTime? finish)
        {
            var result = _reportService.GetStartFinish(start, finish);
            return Ok(result);
        }

        [HttpGet("province")]
        public IActionResult IlAd(string provinceName)
        {
            var result = _reportService.GetAdByProvinceName(provinceName);
            return Ok(result);

        }

        [HttpGet("ilAd")]
        public IActionResult GetAdByNumber()
        {
            var query = _reportService.GetAdByAdNumber();
            return Ok(query);
        }
    }
}
