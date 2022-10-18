using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

public class CreateAdvertDto
{
     public string Title { get; set; }
    public string AdNumber { get; set; }
    public DateTime AdDate { get; set; }
    public string Statement { get; set; }
    public string UserId { get; set; }
    public Guid AddressId { get; set; }
    public Guid AdKindId { get; set; }
    public Guid? MessageId { get; set; }
    public Guid AnimalId { get; set; }
}

