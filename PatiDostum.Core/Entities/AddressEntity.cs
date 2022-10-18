using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

    public class AddressEntity
    {
    public Guid Id { get; set; }
    public string Detail { get; set; }//bina ad kapı no
    public Guid ProvinceId { get; set; }
    public Guid DistrictId { get; set; }
    public Guid NeighborhoodId { get; set; }
    [ForeignKey("ProvinceId")]
    public virtual ProvinceEntity Province { get; set; }
    [ForeignKey("DistrictId")]
    public virtual DistrictEntity District { get; set; }
    [ForeignKey("NeighborhoodId")]
    public virtual NeighborhoodEntity Neighborhood { get; set; }

      }

