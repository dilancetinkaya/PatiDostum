using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;
public class UserDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public Guid? AddressId { get; set; }
    public Guid? MessageId { get; set; }
    public Guid? AnimalId { get; set; }
}

