using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

public class CreateNeighborhoodDto
{
    public string NeighborhoodName { get; set; }
    public int NeighborhoodKey { get; set; }
    public Guid DistrictId { get; set; }
}

