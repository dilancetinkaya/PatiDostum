using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

public class AddressDto
{
    public Guid Id { get; set; }
    public string Detail { get; set; }
    public Guid ProvinceId { get; set; }//id şekşinde
    public Guid DistrictId { get; set; }
    public Guid NeighborhoodId { get; set; }



}

