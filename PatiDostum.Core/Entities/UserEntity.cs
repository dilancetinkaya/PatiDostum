using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

public class UserEntity : IdentityUser
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public Guid? AddressId { get; set; }
    public Guid? AnimalId { get; set; }

    [ForeignKey("AddressId")]
    public virtual AddressEntity Address { get; set; }
    [ForeignKey("AnimalId")]
    public virtual AnimalEntity Animal { get; set; }
}

