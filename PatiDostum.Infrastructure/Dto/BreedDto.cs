using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;
public class BreedDto
{
    public Guid Id { get; set; }
    public string BreedName { get; set; }
    public Guid SpeciesId { get; set; }
}

