using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

public class UpdateUserDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public Guid AddressId { get; set; }
    public Guid AnimalId { get; set; }
}

