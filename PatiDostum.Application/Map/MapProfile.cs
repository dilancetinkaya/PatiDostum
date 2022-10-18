using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PatiDostum.Core.Entities;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Map;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<AddressDto, AddressEntity>().ForMember(src => src.Province, member => member.Ignore()).
          ForMember(src => src.District, member => member.Ignore())
          .ForMember(src => src.Neighborhood, member => member.Ignore()).ReverseMap();

        CreateMap<CreateAddressDto, AddressEntity>().ForMember(src => src.Province, member => member.Ignore()).
        ForMember(src => src.District, member => member.Ignore())
        .ForMember(src => src.Neighborhood, member => member.Ignore()).ReverseMap();

        CreateMap<UpdateAddressDto, AddressEntity>().ForMember(src => src.Province, member => member.Ignore()).
      ForMember(src => src.District, member => member.Ignore())
      .ForMember(src => src.Neighborhood, member => member.Ignore()).ReverseMap();

        CreateMap<AdvertEntity, AdvertDto>();
        CreateMap<AdvertDto, AdvertEntity>();
        CreateMap<CreateAdvertDto, AdvertEntity>();
        CreateMap<UpdateAdvertDto, AdvertEntity>();

        CreateMap<BreedEntity, BreedDto>();
        CreateMap<BreedDto, BreedEntity>();
        CreateMap<CreateBreedDto, BreedEntity>();
        CreateMap<UpdateBreedDto, BreedEntity>();

        CreateMap<AdKindEntity, AdKindDto>();
        CreateMap<AdKindDto, AdKindEntity>();
        CreateMap<CreateAdKindDto, AdKindEntity>();
        CreateMap<UpdateAdKindDto, AdKindEntity>();

        CreateMap<AnimalEntity, AnimalDto>();
        CreateMap<AnimalDto, AnimalEntity>();
        CreateMap<CreateAnimalDto, AnimalEntity>();
        CreateMap<UpdateAnimalDto, AnimalEntity>();

        CreateMap<DistrictEntity, DistrictDto>();
        CreateMap<DistrictDto, DistrictEntity>();
        CreateMap<CreateDistrictDto, DistrictEntity>();
        CreateMap<UpdateDistrictDto, DistrictEntity>();

        CreateMap<ImageEntity, ImageDto>();
        CreateMap<ImageDto, ImageEntity>();
        CreateMap<CreateImageDto, ImageEntity>();
        CreateMap<UpdateImageDto, ImageEntity>();

        CreateMap<MessageEntity, MessageDto>();
        CreateMap<MessageDto, MessageDto>();
        CreateMap<CreateMessageDto, MessageDto>();
        CreateMap<UpdateMessageDto, MessageDto>();

        CreateMap<NeighborhoodEntity, NeighborhoodDto>();
        CreateMap<NeighborhoodDto, NeighborhoodEntity>();
        CreateMap<CreateNeighborhoodDto, NeighborhoodEntity>();
        CreateMap<UpdateNeighborhoodDto, NeighborhoodEntity>();

        CreateMap<ProvinceEntity, ProvinceDto>();
        CreateMap<ProvinceDto, ProvinceEntity>();
        CreateMap<CreateProvinceDto, ProvinceEntity>();
        CreateMap<UpdateProvinceDto, ProvinceEntity>();

        CreateMap<SpeciesEntity, SpeciesDto>();
        CreateMap<SpeciesDto, SpeciesEntity>();
        CreateMap<CreateSpeciesDto, SpeciesEntity>();
        CreateMap<UpdateSpeciesDto, SpeciesEntity>();

        CreateMap<UserEntity, UserDto>();
        CreateMap<UserDto, UserEntity>();
        CreateMap<CreateUserDto, UserEntity>();
        CreateMap<UpdateUserDto, UserEntity>();


    }

}

