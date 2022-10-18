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

public class BreedService : IBreedService
{

    private readonly IBreedRepository _breedrepository;
    private readonly IMapper _mapper;
    public BreedService(IBreedRepository breedRepository, IMapper mapper)
    {
        _breedrepository = breedRepository;
        _mapper = mapper;
    }

    public bool CreateBreed(CreateBreedDto breed)
    {
        var createdBreed = _mapper.Map<BreedEntity>(breed);
        _breedrepository.CreateBreed(createdBreed);
        return true;
    }

    public void DeleteBreed(Guid id)
    {
        _breedrepository.DeleteBreed(id);
    }

    public List<BreedDto> GetBreed()
    {
        var breeds = _breedrepository.GetBreed();
        var breedsDto = _mapper.Map<List<BreedDto>>(breeds);
        return breedsDto;
    }

    public BreedDto GetBreedById(Guid id)
    {
        var breed = _breedrepository.GetBreedById(id);
        var breedDto = _mapper.Map<BreedDto>(breed);
        return breedDto;
    }

    public bool UpdateBreed(UpdateBreedDto breed, Guid id)
    {
        var updatedBreedDto = _mapper.Map<BreedEntity>(breed);
        updatedBreedDto.Id = id;
        _breedrepository.UpdateBreed(updatedBreedDto);
        return true;
    }
}
