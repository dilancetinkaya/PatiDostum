using AutoMapper;
using PatiDostum.Core.Context;
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

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;
    private readonly IMapper _mapper;
    public AnimalService(IAnimalRepository animalRepository, IMapper mapper)
    {
        _animalRepository = animalRepository;
        _mapper = mapper;
    }
    public bool CreateAnimal(CreateAnimalDto animal)
    {
        var animalDto = _mapper.Map<AnimalEntity>(animal);
        var createdAnimal = _animalRepository.CreateAnimal(animalDto);
        return createdAnimal;
    }

    public bool DeleteAnimal(Guid id)
    {
        _animalRepository.DeleteAnimal(id);
        return true;
    }

    public List<AnimalDto> GetAnimal()
    {
        var animals = _animalRepository.GetAnimal();
        var animalsDto = _mapper.Map<List<AnimalDto>>(animals);
        return animalsDto;
    }
    public List<AnimalDto> GetAnimalByBreedId(Guid id)
    {
        var animalByBreed = _animalRepository.GetAnimalByBreedId(id);
        var animalByBreedDto = _mapper.Map<List<AnimalDto>>(animalByBreed);
        return animalByBreedDto;
    }

    public AnimalDto GetAnimalById(Guid id)
    {
        var animal = _animalRepository.GetAnimalById(id);
        var animalDto = _mapper.Map<AnimalDto>(animal);
        return animalDto;
    }

    public List<AnimalDto> GetAnimalBySpeciesId(Guid id)
    {
        var animalBySpecies = _animalRepository.GetAnimalBySpeciesId(id);
        var animalBySpeciesDto = _mapper.Map<List<AnimalDto>>(animalBySpecies);
        return animalBySpeciesDto;
    }

    public List<AnimalDto> GetAnimalByUserId(string id)
    {
        var animalByUser = _animalRepository.GetAnimalByUserId(id);
        var animalByUserDto = _mapper.Map<List<AnimalDto>>(animalByUser);
        return animalByUserDto;
    }

    public bool UpdateAnimal(UpdateAnimalDto animal, Guid id)
    {
        var updatedAnimalDto = _mapper.Map<AnimalEntity>(animal);
        updatedAnimalDto.Id = id;
        _animalRepository.UpdateAnimal(updatedAnimalDto);
        return true;
    }
}