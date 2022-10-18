using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

    public interface IAdvertRepository
    {
    public List<AdvertEntity> GetAdvert();
    public AdvertEntity GetAdvertById(Guid id);
    public List<AdvertEntity> GetAdByUserId(string id);
    public List<AdvertEntity> GetAdByProvinceId(Guid id);
    public List<AdvertEntity> GetAdByDistrictId(Guid id);
    public List<AdvertEntity> GetAdByNeighborhoodId(Guid id);
    public List<AdvertEntity> GetAdByAdKindId(Guid id);
    public List<AdvertEntity> GetAdByBreedId(Guid id);
    public List<AdvertEntity> GetAdBySpeciesId(Guid id);
    public List<AdvertEntity> GetAdByAnimalId(Guid id);
    public bool CreateAdvert(AdvertEntity ad);
    public bool UpdateAdvert(AdvertEntity ad);
    public bool DeleteAdvert(Guid id);
}

