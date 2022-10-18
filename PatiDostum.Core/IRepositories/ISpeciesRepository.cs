using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

public interface ISpeciesRepository
{
    public List<SpeciesEntity> GetSpecies();
    public SpeciesEntity GetSpeciesById(Guid id);
    public void CreateSpecies(SpeciesEntity species);
    public void UpdateSpecies(SpeciesEntity species);
    public void DeleteSpecies(Guid id);
}

