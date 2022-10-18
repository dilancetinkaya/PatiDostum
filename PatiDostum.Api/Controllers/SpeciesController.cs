using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private readonly ISpeciesService _speciesService;
        public SpeciesController(ISpeciesService speciesService)
        {
            _speciesService = speciesService;
        }
        [HttpGet]
        public IActionResult GetSpecies()
        {
            var speciesList = _speciesService.GetSpecies();
            return Ok(speciesList);

        }
        [HttpGet("{id}")]
        public IActionResult GetSpeciesById(Guid id)
        {
            var species = _speciesService.GetSpeciesById(id);
            return Ok(species);

        }

        [HttpPost]
        public IActionResult CreateSpecies(CreateSpeciesDto species)
        {
            _speciesService.CreateSpecies(species);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateSpecies(UpdateSpeciesDto species, Guid id)
        {
            _speciesService.UpdateSpecies(species, id);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSpecies(Guid id)
        {
            _speciesService.DeleteSpecies(id);
            return Ok();
        }
    }

