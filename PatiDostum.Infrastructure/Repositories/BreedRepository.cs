using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class BreedRepository : IBreedRepository
{

    private readonly ApplicationDbContext _applicationDbContext;
    public BreedRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public bool CreateBreed(BreedEntity breed)
    {
        _applicationDbContext.Breed.Add(breed);
        var save = _applicationDbContext.SaveChanges();
        if (save > 0) return true;

        return false;
    }

    public void DeleteBreed(Guid id)
    {

        var breed = _applicationDbContext.Breed.FirstOrDefault(x => x.Id == id);
        if (breed != null)
        {
            _applicationDbContext.Breed.Remove(breed);
            _applicationDbContext.SaveChanges();

        }
    }

    public List<BreedEntity> GetBreed()
    {
        var breeds = _applicationDbContext.Breed.ToList();
        return breeds;
    }

    public BreedEntity GetBreedById(Guid id)
    {
        var breed = _applicationDbContext.Breed.FirstOrDefault(x => x.Id == id);
        return breed;
    }

    public BreedEntity UpdateBreed(BreedEntity breed)
    {
        var updatedBreed = _applicationDbContext.Breed.FirstOrDefault(x => x.Id == breed.Id);
        updatedBreed.Species = breed.Species;
        updatedBreed.BreedName = breed.BreedName;

        _applicationDbContext.Breed.Update(updatedBreed);
        _applicationDbContext.SaveChanges();
        return updatedBreed;
    }
}

