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

public class NeighborhoodService : INeighborhoodService
{
    private readonly INeighborhoodRepository _neighborhoodRepository;
    private readonly IMapper _mapper;
    public NeighborhoodService(INeighborhoodRepository neighborhoodRepository, IMapper mapper)
    {
        _neighborhoodRepository = neighborhoodRepository;
        _mapper = mapper;

    }
    public void CreateNeighborhood(CreateNeighborhoodDto neighborhood)
    {
        var createdNbhood = _mapper.Map<NeighborhoodEntity>(neighborhood);
        _neighborhoodRepository.CreateNeighborhood(createdNbhood);
    }

    public void DeleteNeighborhood(Guid id)
    {
        _neighborhoodRepository.DeleteNeighborhood(id);
    }

    public List<NeighborhoodDto> GetNeighborhood()
    {
        var nbhoodList = _neighborhoodRepository.GetNeighborhood();
        var nbhoodListDto = _mapper.Map<List<NeighborhoodDto>>(nbhoodList);
        return nbhoodListDto;
    }

    public NeighborhoodDto GetNeighborhoodById(Guid id)
    {
        var nbhood = _neighborhoodRepository.GetNeighborhoodById(id);
        var nbhoodDto = _mapper.Map<NeighborhoodDto>(nbhood);
        return nbhoodDto;
    }

    public void UpdateNeighborhood(UpdateNeighborhoodDto neighborhood, Guid id)
    {
        var updatedNbhood = _mapper.Map<NeighborhoodEntity>(neighborhood);
        updatedNbhood.Id = id;
        _neighborhoodRepository.UpdateNeighborhood(updatedNbhood);

    }
}

