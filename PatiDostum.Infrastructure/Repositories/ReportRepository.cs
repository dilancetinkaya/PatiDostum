using PatiDostum.Core.Context;
using PatiDostum.Core.Dto;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class ReportRepository : IReportRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public ReportRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public List<CountAdByCity> GetAdByAdNumber()
    {
        var query = (from ad in _applicationDbContext.Advert

                     group ad by ad.Address.Province.ProvinceName into Grup
                     select new CountAdByCity
                     {
                         Province = Grup.Key,
                         Total = Grup.Count()
                     }).ToList();
        return query;
    }

    public List<GetAdByDate> GetAdByProvinceName(string provinceName)
    {
        var province = from provinceAd in _applicationDbContext.Advert
                       where provinceAd.Address.Province.ProvinceName == provinceName
                       select new GetAdByDate
                       {

                           User = provinceAd.User,
                           AdDate = provinceAd.AdDate,
                           AdName = provinceAd.Title,
                           AdNumber = provinceAd.AdNumber,
                           ProvinceName=provinceAd.Address.Province.ProvinceName,
                           
                           SpeciesBreed = string.Concat(provinceAd.Animal.Species.SpeciesName, provinceAd.Animal.Breed.BreedName),
                          

                       };
        return province.ToList();
    }

    public List<GetAdByDate> GetStartFinish(DateTime? start, DateTime? finish)
    {
        var result = from ad in _applicationDbContext.Advert
                     where (!start.HasValue || ad.AdDate >= start.Value) &&
                     (!finish.HasValue || ad.AdDate <= finish.Value)
                     select new GetAdByDate
                     {
                         User = ad.User,
                         AdDate = ad.AdDate,
                         AdName = ad.Title,
                         AdNumber = ad.AdNumber,
                         ProvinceName = ad.Address.Province.ProvinceName,
                         SpeciesBreed = string.Concat(ad.Animal.Species.SpeciesName, ad.Animal.Breed.BreedName),
                      
                         
                     };
        return result.ToList();
    }
}

