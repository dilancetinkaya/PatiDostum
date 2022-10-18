using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdKindController : ControllerBase
{
    private readonly IAdKindService _adKindService;
    public AdKindController(IAdKindService adKindService)
    {
        _adKindService = adKindService;
    }
    [HttpGet]
    public IActionResult GetAdKind()
    {
        var adKindList = _adKindService.GetAdKind();
        return Ok(adKindList);

    }
    [HttpGet("{id}")]
    public IActionResult GetAdKindById(Guid id)
    {
        var adKind = _adKindService.GetAdKindById(id);
        return Ok(adKind);

    }

    [HttpPost]
    public IActionResult CreateAdKind(CreateAdKindDto adKind)
    {
        _adKindService.CreateAdKind(adKind);
        return Ok();
    }
    [HttpPut("{id}")]
    public IActionResult UpdateAdKind(UpdateAdKindDto adKind, Guid id)
    {

        _adKindService.UpdateAdKind(adKind, id);
        return Ok();

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteAdKindd(Guid id)
    {
        _adKindService.DeleteAdKind(id);
        return Ok();
    }
}

