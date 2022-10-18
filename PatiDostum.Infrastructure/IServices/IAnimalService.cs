using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

    public interface IAnimalService
    {
    public List<AnimalDto> GetAnimal();
    public AnimalDto GetAnimalById(Guid id);
    public List<AnimalDto> GetAnimalByBreedId(Guid id);
    public List<AnimalDto> GetAnimalBySpeciesId(Guid id);
    public List<AnimalDto> GetAnimalByUserId(string id);
    public bool CreateAnimal(CreateAnimalDto animal);
    public bool UpdateAnimal(UpdateAnimalDto animal,Guid id);
    public bool DeleteAnimal(Guid id);
}

