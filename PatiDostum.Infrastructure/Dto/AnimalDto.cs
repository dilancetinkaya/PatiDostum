using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;
public class AnimalDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid SpeciesId { get; set; }
    public Guid BreedId { get; set; }
    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }



}
public enum Gender
{
    Disi, Erkek
}

