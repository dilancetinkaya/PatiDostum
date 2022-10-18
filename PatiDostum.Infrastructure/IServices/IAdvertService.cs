using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

    public interface IAdvertService
    {

    public List<AdvertDto> GetAdvert();
    public AdvertDto GetAdvertById(Guid id);
    public List<AdvertDto> GetAdByUserId(string id);
    public List<AdvertDto> GetAdByProvinceId(Guid id);
    public List<AdvertDto> GetAdByDistrictId(Guid id);
    public List<AdvertDto> GetAdByNeighborhoodId(Guid id);
    public List<AdvertDto> GetAdByAdKindId(Guid id);
    public List<AdvertDto> GetAdByBreedId(Guid id);
    public List<AdvertDto> GetAdBySpeciesId(Guid id);
    public List<AdvertDto> GetAdByAnimalId(Guid id);
    public bool CreateAdvert(CreateAdvertDto ad);
    public bool UpdateAdvert(UpdateAdvertDto ad,Guid id);
    public bool DeleteAdvert(Guid id);
}

