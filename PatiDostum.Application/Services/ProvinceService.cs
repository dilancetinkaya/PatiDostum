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

public class ProvinceService : IProvinceService
{
    private readonly IProvinceRepository _provinceRepository;
    private readonly IMapper _mapper;
    public ProvinceService(IProvinceRepository provinceRepository, IMapper mapper)
    {
        _provinceRepository = provinceRepository;
        _mapper = mapper;
    }
    public void CreateProvince(CreateProvinceDto province)
    {
        var createdProvince = _mapper.Map<ProvinceEntity>(province);
        _provinceRepository.CreateProvince(createdProvince);
    }

    public void DeleteProvince(Guid id)
    {
        _provinceRepository.DeleteProvince(id);
    }

    public List<ProvinceDto> GetProvince()
    {
        var provinceList = _provinceRepository.GetProvince();
        var provinces=_mapper.Map<List<ProvinceDto>>(provinceList);
        return provinces;
    }

    public ProvinceDto GetProvinceById(Guid id)
    {

        var province = _provinceRepository.GetProvinceById(id);
        var provinceDto = _mapper.Map<ProvinceDto>(province);
        return provinceDto;
    }

    public void UpdateProvince(UpdateProvinceDto province,Guid id)
    {
        var updatedProvince = _mapper.Map<ProvinceEntity>(province);
        updatedProvince.Id = id;
        _provinceRepository.UpdateProvince(updatedProvince);

    }
}

