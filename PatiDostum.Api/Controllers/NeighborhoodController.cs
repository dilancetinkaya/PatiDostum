using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NeighborhoodController : ControllerBase
{

    private readonly INeighborhoodService _neighborhoodService;
    public NeighborhoodController(INeighborhoodService neighborhoodService)
    {
        _neighborhoodService = neighborhoodService;
    }
    [HttpGet]
    public IActionResult GetNeighborhood()
    {
        var neighborhoods = _neighborhoodService.GetNeighborhood();
        return Ok(neighborhoods);
    }
    [HttpGet("{id}")]
    public IActionResult GetNeighborhoodById(Guid id)
    {
        var neighborhood = _neighborhoodService.GetNeighborhoodById(id);
        return Ok(neighborhood);

    }
    [HttpPost]
    public IActionResult CreateNeighborhood(CreateNeighborhoodDto neighborhood)
    {
        _neighborhoodService.CreateNeighborhood(neighborhood);
        return Ok();

    }
    [HttpPut("{id}")]
    public IActionResult UpdateNeighborhood(UpdateNeighborhoodDto neighborhood, Guid id)
    {
        _neighborhoodService.UpdateNeighborhood(neighborhood, id);
        return Ok();

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteNeighborhood(Guid id)
    {
        _neighborhoodService.DeleteNeighborhood(id);
        return Ok();
    }
}
