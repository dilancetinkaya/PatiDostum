using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class AdKindRepository : IAdKindRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public AdKindRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateAdKind(AdKindEntity adKind)
    {
        _applicationDbContext.AdKind.Add(adKind);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteAdKind(Guid id)
    {
        var result = _applicationDbContext.AdKind.FirstOrDefault(x => x.Id == id);
        if (result != null)
        {
            _applicationDbContext.AdKind.Remove(result);
            _applicationDbContext.SaveChanges();

        }
    }

    public List<AdKindEntity> GetAdKind()
    {
        var result = _applicationDbContext.AdKind.ToList();
        return result;
    }

    public AdKindEntity GetAdKindById(Guid id)
    {
        var result = _applicationDbContext.AdKind.FirstOrDefault(x => x.Id == id);
        return result;
    }

    public void UpdateAdKind(AdKindEntity adKind)
    {
        var result = _applicationDbContext.AdKind.FirstOrDefault(x => x.Id == adKind.Id);
        result.AdName = adKind.AdName;
        _applicationDbContext.AdKind.Update(result);
        _applicationDbContext.SaveChanges();
    }
}

