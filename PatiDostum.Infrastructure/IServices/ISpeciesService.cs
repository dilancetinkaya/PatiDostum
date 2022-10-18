using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface ISpeciesService
{
    public List<SpeciesDto> GetSpecies();
    public SpeciesDto GetSpeciesById(Guid id);
    public void CreateSpecies(CreateSpeciesDto species);
    public void UpdateSpecies(UpdateSpeciesDto species,Guid id);
    public void DeleteSpecies(Guid id);
}

