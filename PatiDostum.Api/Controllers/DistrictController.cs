using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DistrictController : ControllerBase
{
    private readonly IDistrictService _districtService;
    public DistrictController(IDistrictService districtService)
    {
        _districtService = districtService;
    }
    [HttpGet]
    public IActionResult GetDistrict()
    {
        var districtList =_districtService.GetDistrict();
        return Ok(districtList);
    }
    [HttpGet("{id}")]
    public IActionResult GetDistrictById(Guid id)
    {

        var district =_districtService.GetDistrictById(id);
        return Ok(district);

    }
    [HttpPost]
    public IActionResult CreateDistrict(CreateDistrictDto district)
    {
        _districtService.CreateDistrict(district);
        return Ok();

    }
    [HttpPut("{id}")]
    public IActionResult UpdateDistrict(UpdateDistrictDto district, Guid id)
    {

        _districtService.UpdateDistrict(district, id);
        return Ok();

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteDistrict(Guid id)
    {

       _districtService.DeleteDistrict(id);
        return Ok();
    }
}

