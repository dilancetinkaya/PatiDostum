using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

public class BreedEntity
{
    public Guid Id { get; set; }
    public string BreedName { get; set; }
    public Guid SpeciesId { get; set; }
    [ForeignKey("SpeciesId")]
    public virtual SpeciesEntity Species { get; set; }
}

