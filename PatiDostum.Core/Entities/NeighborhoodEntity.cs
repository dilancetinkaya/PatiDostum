using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

    public class NeighborhoodEntity
    { 
       public Guid Id { get; set; }
        public string NeighborhoodName { get; set; }
        public int NeighborhoodKey { get; set; }
        [ForeignKey("DistrictId")]
        public virtual DistrictEntity District { get; set; }
        public Guid DistrictId { get; set; }
    }

