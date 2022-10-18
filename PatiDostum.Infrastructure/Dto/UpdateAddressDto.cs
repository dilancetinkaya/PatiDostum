using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

    public class UpdateAddressDto
    {
    public string Detail { get; set; }
    public Guid ProvinceId { get; set; }
    public Guid DistrictId { get; set; }
    public Guid NeighborhoodId { get; set; }
}

