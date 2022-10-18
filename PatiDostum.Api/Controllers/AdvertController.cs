using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

//[Authorize]
[Route("api/[controller]")]
[ApiController]
public class AdvertController : ControllerBase
{
    private readonly IAdvertService _advertService;
    public AdvertController(IAdvertService advertService)
    {
        _advertService = advertService;
    }
    [HttpGet]
    public IActionResult GetAdvert()
    {
        var adList = _advertService.GetAdvert();
        return Ok(adList);
    }
    [HttpGet("{id}")]
    public IActionResult GetAdvertById(Guid id)
    {
        var ad = _advertService.GetAdvertById(id);
        return Ok(ad);

    }
    [HttpGet("User/{id}")]
    public IActionResult GetAdvertByUserId(string id)
    {
        var userAd = _advertService.GetAdByUserId(id);
        return Ok(userAd);
    }

    [HttpGet("Province/{id}")]
    public IActionResult GetAdvertByProvinceId(Guid id)
    {
        var provinceAd = _advertService.GetAdByProvinceId(id);
        return Ok(provinceAd);
    }
    [HttpGet("District/{id}")]
    public IActionResult GetAdvertByDistrictId(Guid id)
    {
        var districtAd = _advertService.GetAdByDistrictId(id);
        return Ok(districtAd);
    }
    [HttpGet("Neighborhood/{id}")]
    public IActionResult GetAdvertByNeighborhoodId(Guid id)
    {
        var nbhoodAd = _advertService.GetAdByNeighborhoodId(id);
        return Ok(nbhoodAd);
    }

    [HttpGet("AdKind/{id}")]
    public IActionResult GetAdvertByAdKindId(Guid id)
    {
        var adKindAd = _advertService.GetAdByAdKindId(id);
        return Ok(adKindAd);
    }

    [HttpGet("Breed/{id}")]
    public IActionResult GetAdvertByBreedId(Guid id)
    {
        var breedAd = _advertService.GetAdByBreedId(id);
        return Ok(breedAd);
    }
    [HttpGet("Species/{id}")]
    public IActionResult GetAdvertBySpeciesId(Guid id)
    {
        var speciesAd = _advertService.GetAdBySpeciesId(id);
        return Ok(speciesAd);
    }
    [HttpGet("Animal/{id}")]
    public IActionResult GetAdvertByAnimalId(Guid id)
    {
        var animalAd = _advertService.GetAdByAnimalId(id);
        return Ok(animalAd);
    }


    [HttpPost]
    public IActionResult CreateAdvert(CreateAdvertDto ad)
    {

        var createdAd = _advertService.CreateAdvert(ad);
        return Ok(createdAd);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateAdvert(UpdateAdvertDto ad, Guid id)
    {

        var updatedAd = _advertService.UpdateAdvert(ad, id);
        return Ok(updatedAd);

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteAdvert(Guid id)
    {

        var deletedAd = _advertService.DeleteAdvert(id);
        return Ok(deletedAd);
    }

}

