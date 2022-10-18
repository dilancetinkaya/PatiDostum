using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class AdvertRepository : IAdvertRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public AdvertRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public bool CreateAdvert(AdvertEntity ad)
    {
        _applicationDbContext.Advert.Add(ad);
        var result = _applicationDbContext.SaveChanges();
        if (result > 0) return true;

        return false;
    }

    public bool DeleteAdvert(Guid id)
    {
        var result = _applicationDbContext.Advert.FirstOrDefault(x => x.Id == id);
        if (result != null)
        {
            _applicationDbContext.Advert.Remove(result);
            var save = _applicationDbContext.SaveChanges();
            if (save > 0) return true;
        }
        return false;
    }

    public List<AdvertEntity> GetAdByBreedId(Guid id)
    {
        var kind = _applicationDbContext.Advert.Where(x => x.Animal.Breed.Id == id).ToList();
        return kind;
    }

    public List<AdvertEntity> GetAdByAnimalId(Guid id)
    {
        var kindByAnimal = _applicationDbContext.Advert.Where(x => x.Animal.Id == id).ToList();
        return kindByAnimal;
    }

    public List<AdvertEntity> GetAdByDistrictId(Guid id)
    {
        var adByDistrict = _applicationDbContext.Advert.Where(x => x.Address.District.Id == id).ToList();
        return adByDistrict;
    }

    public List<AdvertEntity> GetAdByAdKindId(Guid id)
    {
        var result = _applicationDbContext.Advert.Where(x => x.AdKind.Id == id).ToList();
        return result;
    }

    public List<AdvertEntity> GetAdByNeighborhoodId(Guid id)
    {
        var adByNeighborhood = _applicationDbContext.Advert.Where(x => x.Address.Neighborhood.Id == id).ToList();
        return adByNeighborhood;
    }

    public List<AdvertEntity> GetAdByProvinceId(Guid id)
    {
        var adByProvince = _applicationDbContext.Advert.Where(x => x.Address.Province.Id == id).ToList();
        return adByProvince;
    }

    public List<AdvertEntity> GetAdBySpeciesId(Guid id)
    {
       
        var adBySpecies = _applicationDbContext.Advert.Where(x => x.Animal.Species.Id == id).ToList();
        return adBySpecies;
    }

    public List<AdvertEntity> GetAdByUserId(string id)
    {
        var result = _applicationDbContext.Advert.Where(x => x.User.Id == id).ToList();
        return result;
    }

    public List<AdvertEntity> GetAdvert()
    {
        var ads = _applicationDbContext.Advert.ToList();
        return ads;
    }

    public AdvertEntity GetAdvertById(Guid id)
    {
        var ad = _applicationDbContext.Advert.FirstOrDefault(x => x.Id == id);
        return ad;
    }

    public bool UpdateAdvert(AdvertEntity ad)
    {
        var advert = _applicationDbContext.Advert.FirstOrDefault(x => x.Id == ad.Id);
        advert.Statement = ad.Statement;
        advert.Title = ad.Title;
        advert.AnimalId = ad.AnimalId;
        advert.UserId = ad.UserId;
        advert.AdNumber = ad.AdNumber;
        advert.AdDate = ad.AdDate;
        advert.AdKindId = ad.AdKindId;
        advert.AddressId = ad.AddressId;
        _applicationDbContext.Advert.Update(advert);
        var save = _applicationDbContext.SaveChanges();
        if (save > 0) return true;

        return false;
    }
}

