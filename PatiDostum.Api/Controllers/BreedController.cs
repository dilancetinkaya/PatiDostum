using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BreedController : ControllerBase
{
    private readonly IBreedService _breedService;
    public BreedController(IBreedService breedService)
    {
        _breedService = breedService;
    }

    [HttpGet]
    public IActionResult GetBreed()
    {
        var breedList = _breedService.GetBreed();
        return Ok(breedList);

    }
    [HttpGet("{id}")]
    public IActionResult GetBreedById(Guid id)
    {
        var breed = _breedService.GetBreedById(id);
        return Ok(breed);

    }

    [HttpPost]
    public IActionResult CreatedBreed(CreateBreedDto breed)
    {
        var createdBreed = _breedService.CreateBreed(breed);
        return Ok(createdBreed);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateBreed(UpdateBreedDto breed, Guid id)
    {

        var updatedBreed = _breedService.UpdateBreed(breed, id);
        return Ok(updatedBreed);

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteBreed(Guid id)
    {
        _breedService.DeleteBreed(id);
        return Ok();
    }
}

