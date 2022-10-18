using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

public interface IBreedRepository
{
    public List<BreedEntity> GetBreed();
    public BreedEntity GetBreedById(Guid id);
    public bool CreateBreed(BreedEntity breed);
    public BreedEntity UpdateBreed(BreedEntity breed);
    public void DeleteBreed(Guid id);
}

