using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

    public interface IAnimalRepository
    {
    public List<AnimalEntity> GetAnimal();
    public AnimalEntity GetAnimalById(Guid id);
    public List<AnimalEntity> GetAnimalByBreedId(Guid id);
    public List<AnimalEntity> GetAnimalBySpeciesId(Guid id);
    public List<AnimalEntity> GetAnimalByUserId(string id);
    public bool CreateAnimal(AnimalEntity animal);
    public bool UpdateAnimal(AnimalEntity animal);
    public bool DeleteAnimal(Guid id);
}

