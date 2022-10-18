using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class NeighborhoodRepository : INeighborhoodRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public NeighborhoodRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateNeighborhood(NeighborhoodEntity neighborhood)
    {
        _applicationDbContext.Neighborhood.Add(neighborhood);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteNeighborhood(Guid id)
    {
        var nbhood = _applicationDbContext.Neighborhood.FirstOrDefault(x => x.Id == id);
        if (nbhood != null)
        {
            _applicationDbContext.Neighborhood.Remove(nbhood);
            _applicationDbContext.SaveChanges();
        }
    }

    public List<NeighborhoodEntity> GetNeighborhood()
    {
        var nbhoodList = _applicationDbContext.Neighborhood.ToList();
        return nbhoodList;
    }

    public NeighborhoodEntity GetNeighborhoodById(Guid id)
    {
        var nbhood = _applicationDbContext.Neighborhood.FirstOrDefault(x => x.Id == id);
        return nbhood;
    }

    public void UpdateNeighborhood(NeighborhoodEntity neighborhood)
    {
        var updatedNbhood = _applicationDbContext.Neighborhood.FirstOrDefault(x => x.Id == neighborhood.Id);
        updatedNbhood.District = neighborhood.District;
        updatedNbhood.NeighborhoodName = neighborhood.NeighborhoodName;
        updatedNbhood.NeighborhoodKey = neighborhood.NeighborhoodKey;

        _applicationDbContext.Neighborhood.Update(updatedNbhood);
        _applicationDbContext.SaveChanges();
    }
}

