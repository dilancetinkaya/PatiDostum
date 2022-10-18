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
public class AdvertService : IAdvertService
{
    private readonly IAdvertRepository _advertRepository;
    private readonly IMapper _mapper;
    public AdvertService(IAdvertRepository advertRepository, IMapper mapper)
    {
        _advertRepository = advertRepository;
        _mapper = mapper;
    }

    public bool CreateAdvert(CreateAdvertDto ad)
    {
        var adDto = _mapper.Map<AdvertEntity>(ad);
        _advertRepository.CreateAdvert(adDto);
        return true;
    }

    public bool DeleteAdvert(Guid id)
    {
        _advertRepository.DeleteAdvert(id);
        return true;
    }

    public List<AdvertDto> GetAdByAdKindId(Guid id)
    {
        var adByKind = _advertRepository.GetAdByAdKindId(id);
        var adByKindDto = _mapper.Map<List<AdvertDto>>(adByKind);
        return adByKindDto;
    }

    public List<AdvertDto> GetAdByAnimalId(Guid id)
    {

        var adByAnimal = _advertRepository.GetAdByAnimalId(id);
        var adByAnimalDto = _mapper.Map<List<AdvertDto>>(adByAnimal);
        return adByAnimalDto;

    }

    public List<AdvertDto> GetAdByDistrictId(Guid id)
    {
        var adByDistrict = _advertRepository.GetAdByDistrictId(id);
        var adByDistrictDto = _mapper.Map<List<AdvertDto>>(adByDistrict);
        return adByDistrictDto;
    }

    public List<AdvertDto> GetAdByBreedId(Guid id)
    {
        var adByBreed = _advertRepository.GetAdByBreedId(id);
        var adByBreedDto = _mapper.Map<List<AdvertDto>>(adByBreed);
        return adByBreedDto;
    }

    public List<AdvertDto> GetAdByNeighborhoodId(Guid id)
    {
        var adByNeighborhood = _advertRepository.GetAdByNeighborhoodId(id);
        var adByNeighborhoodDto = _mapper.Map<List<AdvertDto>>(adByNeighborhood);
        return adByNeighborhoodDto;

    }

    public List<AdvertDto> GetAdByProvinceId(Guid id)
    {
        var adByProvince = _advertRepository.GetAdByProvinceId(id);
        var adByProvinceDto = _mapper.Map<List<AdvertDto>>(adByProvince);
        return adByProvinceDto;
    }

    public List<AdvertDto> GetAdBySpeciesId(Guid id)
    {
        var adBySpecies = _advertRepository.GetAdBySpeciesId(id);
        var adBySpeciesDto = _mapper.Map<List<AdvertDto>>(adBySpecies);
        return adBySpeciesDto;
    }

    public List<AdvertDto> GetAdByUserId(string id)
    {
        var adByUser = _advertRepository.GetAdByUserId(id);
        var adByUserDto = _mapper.Map<List<AdvertDto>>(adByUser);
        return adByUserDto;
    }

    public List<AdvertDto> GetAdvert()
    {
        var ads = _advertRepository.GetAdvert();
        var adsDto = _mapper.Map<List<AdvertDto>>(ads);
        return adsDto;
    }

    public AdvertDto GetAdvertById(Guid id)
    {
        var ad = _advertRepository.GetAdvertById(id);
        var adDto = _mapper.Map<AdvertDto>(ad);
        return adDto;
    }

    public bool UpdateAdvert(UpdateAdvertDto ad, Guid id)
    {
        var adDto = _mapper.Map<AdvertEntity>(ad);
        adDto.Id = id;
        _advertRepository.UpdateAdvert(adDto);
        return true;
    }
}
