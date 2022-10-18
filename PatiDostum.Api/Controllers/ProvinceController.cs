using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService _provinceService;
        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }
        [HttpGet]
        public IActionResult GetProvince()
        {
            var provinces = _provinceService.GetProvince();
            return Ok(provinces);
        }
        [HttpGet("{id}")]
        public IActionResult GetProvinceById(Guid id)
        {
            var province = _provinceService.GetProvinceById(id);
            return Ok(province);

        }
        [HttpPost]
        public IActionResult CreateProvince(CreateProvinceDto province)
        {
            _provinceService.CreateProvince(province);
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult UpdateProvince(UpdateProvinceDto province, Guid id)
        {
            _provinceService.UpdateProvince(province, id);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProvince(Guid id)
        {
            _provinceService.DeleteProvince(id);
            return Ok();
        }
    }
}
