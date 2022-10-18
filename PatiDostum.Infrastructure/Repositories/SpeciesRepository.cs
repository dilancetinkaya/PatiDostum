using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class SpeciesRepository : ISpeciesRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public SpeciesRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateSpecies(SpeciesEntity species)
    {
        _applicationDbContext.Add(species);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteSpecies(Guid id)
    {
        var deletedSpecies = _applicationDbContext.Species.FirstOrDefault(x => x.Id == id);
        if (deletedSpecies != null)
        {
            _applicationDbContext.Species.Remove(deletedSpecies);
            _applicationDbContext.SaveChanges();
        }
    }

    public List<SpeciesEntity> GetSpecies()
    {
        var speciesList = _applicationDbContext.Species.ToList();
        return speciesList;
    }

    public SpeciesEntity GetSpeciesById(Guid id)
    {
        var species = _applicationDbContext.Species.FirstOrDefault(x => x.Id == id);
        return species;
    }

    public void UpdateSpecies(SpeciesEntity species)
    {
        var updatedSpecies = _applicationDbContext.Species.FirstOrDefault(x => x.Id == species.Id);
        updatedSpecies.SpeciesName = species.SpeciesName;
        _applicationDbContext.Species.Update(updatedSpecies);
        _applicationDbContext.SaveChanges();


    }
}

