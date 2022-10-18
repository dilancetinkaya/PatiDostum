using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class AnimalRepository : IAnimalRepository
{

    private readonly ApplicationDbContext _applicationDbContext;

    public AnimalRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;

    }
    public bool CreateAnimal(AnimalEntity animal)
    {
        _applicationDbContext.Animal.Add(animal);
        var save = _applicationDbContext.SaveChanges();
        if (save > 0) return true;

        return false;
    }

    public bool DeleteAnimal(Guid id)
    {
        var animal = _applicationDbContext.Animal.FirstOrDefault(x => x.Id == id);
        if (animal != null)
        {
            _applicationDbContext.Animal.Remove(animal);
            var save = _applicationDbContext.SaveChanges();
            if (save > 0) return true;

        }
        return false;
    }

    public List<AnimalEntity> GetAnimal()
    {
        var animals = _applicationDbContext.Animal.ToList();
        return animals;
    }

    public AnimalEntity GetAnimalById(Guid id)
    {
        var animal = _applicationDbContext.Animal.FirstOrDefault(x => x.Id == id);
        return animal ;
    }

    public List<AnimalEntity> GetAnimalByBreedId(Guid id)
    {
        var animalByKind = _applicationDbContext.Animal.Where(x => x.Breed.Id == id).ToList();
        return animalByKind;
    }

    public List<AnimalEntity> GetAnimalBySpeciesId(Guid id)
    {
        var animalBySpecies = _applicationDbContext.Animal.Where(x => x.Species.Id == id).ToList();
        return animalBySpecies;
    }

    public List<AnimalEntity> GetAnimalByUserId(string id)
    {
        var animalByUser = (from kullanici in _applicationDbContext.User
                     where kullanici.Id == id
                     select kullanici.Animal).ToList();


        return animalByUser;
    }

    public bool UpdateAnimal(AnimalEntity animal)
    {
        var updatedAnimal = _applicationDbContext.Animal.FirstOrDefault(x => x.Id == animal.Id);
        updatedAnimal.Breed = animal.Breed;
        updatedAnimal.Gender = animal.Gender;
        updatedAnimal.BirthDate = animal.BirthDate;
        updatedAnimal.Name = animal.Name;
        updatedAnimal.Species = animal.Species;
        _applicationDbContext.Animal.Update(updatedAnimal);
        var save = _applicationDbContext.SaveChanges();

        if (save > 0) return true;

        return false;
    }
}

