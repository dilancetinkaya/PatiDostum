using AutoMapper;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Services;

public class SpeciesService : ISpeciesService
{
    private readonly ISpeciesRepository _speciesRepository;
    private readonly IMapper _mapper;
    public SpeciesService(ISpeciesRepository speciesRepository, IMapper mapper)
    {
        _speciesRepository = speciesRepository;
        _mapper = mapper;
    }
    public void CreateSpecies(CreateSpeciesDto species)
    {
        var createdSpecies = _mapper.Map<SpeciesEntity>(species);
        _speciesRepository.CreateSpecies(createdSpecies);
    }


    public void DeleteSpecies(Guid id)
    {
        _speciesRepository.DeleteSpecies(id);
    }

    public List<SpeciesDto> GetSpecies()
    {
        var speciesList = _speciesRepository.GetSpecies();
        var species = _mapper.Map<List<SpeciesDto>>(speciesList);
        return species;
    }

    public SpeciesDto GetSpeciesById(Guid id)
    {
        var species = _speciesRepository.GetSpeciesById(id);
        var speciesDto = _mapper.Map<SpeciesDto>(species);
        return speciesDto;
    }

    public void UpdateSpecies(UpdateSpeciesDto species,Guid id)
    {
        var updatedSpecies = _mapper.Map<SpeciesEntity>(species);
        updatedSpecies.Id = id;
        _speciesRepository.UpdateSpecies(updatedSpecies);
    }
}

