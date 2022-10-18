using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : ControllerBase
{
    private readonly IAnimalService _animalService;
    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
    [HttpGet]
    public IActionResult GetAnimal()
    {
        var animalList = _animalService.GetAnimal();
        return Ok(animalList);

    }
    [HttpGet("{id}")]
    public IActionResult GetAnimalById(Guid id)
    {
        var animal = _animalService.GetAnimalById(id);
        return Ok(animal);

    }
    [HttpGet("Breed/{id}")]
    public IActionResult GetAnimalByBreedId(Guid id)
    {
        var animalBreed = _animalService.GetAnimalByBreedId(id);
        return Ok(animalBreed);
    }
    [HttpGet("Species/{id}")]
    public IActionResult GetAnimalBySpeciesId(Guid id)
    {
        var animalSpecies = _animalService.GetAnimalBySpeciesId(id);
        return Ok(animalSpecies);
    }
    [HttpGet("User/{id}")]

    public IActionResult GetAnimalByUserId(string id)
    {
        var animal = _animalService.GetAnimalByUserId(id);
        if (animal != null) return Ok(animal);

        return BadRequest();

    }


    [HttpPost]
    public IActionResult CreateAnimal(CreateAnimalDto animal)
    {

        var createdAnimal = _animalService.CreateAnimal(animal);
        return Ok(createdAnimal);
    }
    [HttpPut("{id}")]
    public IActionResult UpdatedAnimal(UpdateAnimalDto animal, Guid id)
    {
       
        var updatedAnimal = _animalService.UpdateAnimal(animal, id);
        return Ok(updatedAnimal);

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(Guid id)
    {

        var deletedAnimal = _animalService.DeleteAnimal(id);
        return Ok(deletedAnimal);
    }

}

