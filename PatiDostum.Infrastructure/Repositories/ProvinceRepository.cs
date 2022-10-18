using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class ProvinceRepository : IProvinceRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public ProvinceRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateProvince(ProvinceEntity province)
    {
        var createdProvince = _applicationDbContext.Province.Add(province);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteProvince(Guid id)
    {
        var deletedProvince = _applicationDbContext.Province.FirstOrDefault(x => x.Id == id);
        if (deletedProvince != null)
        {
            _applicationDbContext.Province.Remove(deletedProvince);
            _applicationDbContext.SaveChanges();
        }
    }

    public List<ProvinceEntity> GetProvince()
    {
        var provinceList = _applicationDbContext.Province.ToList();
        return provinceList;
    }

    public ProvinceEntity GetProvinceById(Guid id)
    {
        var province = _applicationDbContext.Province.FirstOrDefault(x => x.Id == id);
        return province;
    }

    public void UpdateProvince(ProvinceEntity province)
    {
        var updatedProvince = _applicationDbContext.Province.FirstOrDefault(x => x.Id == province.Id);
        updatedProvince.ProvinceName = province.ProvinceName;
        updatedProvince.ProvinceKey = province.ProvinceKey;
        _applicationDbContext.Province.Update(updatedProvince);
        _applicationDbContext.SaveChanges();
    }
}

