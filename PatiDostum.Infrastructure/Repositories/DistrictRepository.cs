using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class DistrictRepository : IDistrictRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public DistrictRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateDistrict(DistrictEntity district)
    {
        _applicationDbContext.District.Add(district);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteDistrict(Guid id)
    {
        var deletedDistrict = _applicationDbContext.District.FirstOrDefault(x => x.Id == id);
        if (deletedDistrict != null)
        {
            _applicationDbContext.District.Remove(deletedDistrict);
            _applicationDbContext.SaveChanges();
        }
    }

    public List<DistrictEntity> GetDistrict()
    {
        var districts = _applicationDbContext.District.ToList();
        return districts;
    }

    public DistrictEntity GetDistrictById(Guid id)
    {
        var district = _applicationDbContext.District.FirstOrDefault(x => x.Id == id);
        return district;
    }

    public void UpdateDistrict(DistrictEntity district)
    {
        var updatedDistrict = _applicationDbContext.District.FirstOrDefault(x => x.Id == district.Id);
        updatedDistrict.DistrictName = district.DistrictName;
        updatedDistrict.DistrictKey = district.DistrictKey;
        updatedDistrict.Province = district.Province;

        _applicationDbContext.District.Update(updatedDistrict);
        _applicationDbContext.SaveChanges();
    }
}

