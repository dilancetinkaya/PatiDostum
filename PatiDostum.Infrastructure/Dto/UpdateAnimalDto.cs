using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

public class UpdateAnimalDto
{
    public string Name { get; set; }
    public Guid SpeciesId { get; set; }
    public Guid BreedId { get; set; }
    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }
}

