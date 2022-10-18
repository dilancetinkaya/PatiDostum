using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

    public class AnimalEntity
    {

     public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BreedId { get; set; }
        public Guid SpeciesId { get; set; }
        [ForeignKey("BreedId")]
        public virtual BreedEntity Breed { get; set; }
        [ForeignKey("SpeciesId")]
        public virtual SpeciesEntity Species { get; set; }
        public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }

     }
    public enum Gender
    {
    Female, Male
    }


