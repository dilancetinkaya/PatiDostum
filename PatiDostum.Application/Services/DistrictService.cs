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

public class DistrictService : IDistrictService
{
    private readonly IDistrictRepository _districtRepository;
    private readonly IMapper _mapper;
    public DistrictService(IDistrictRepository districtRepository, IMapper mapper)
    {
        _districtRepository = districtRepository;
        _mapper = mapper;
    }

    public void CreateDistrict(CreateDistrictDto district)
    {
        var createdDistrict = _mapper.Map<DistrictEntity>(district);
        _districtRepository.CreateDistrict(createdDistrict);

    }

    public void DeleteDistrict(Guid id)
    {
        _districtRepository.DeleteDistrict(id);
    }

    public List<DistrictDto> GetDistrict()
    {
        var districtList = _districtRepository.GetDistrict();
        var districts = _mapper.Map<List<DistrictDto>>(districtList);
        return districts;

    }

    public DistrictDto GetDistrictById(Guid id)
    {
        var district = _districtRepository.GetDistrictById(id);
        var districtDto = _mapper.Map<DistrictDto>(district);
        return districtDto;
    }

    public void UpdateDistrict(UpdateDistrictDto district, Guid id)
    {
        var updatedDistrict = _mapper.Map<DistrictEntity>(district);
        updatedDistrict.Id = id;
        _districtRepository.UpdateDistrict(updatedDistrict);
    }
}

