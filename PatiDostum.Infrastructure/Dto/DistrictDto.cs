using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;
public class DistrictDto
{
    public Guid Id { get; set; }
    public string DistrictName { get; set; }
    public int DistrictKey { get; set; }

    public Guid ProvinceId { get; set; }
}

