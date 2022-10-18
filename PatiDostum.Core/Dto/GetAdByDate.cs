using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Dto;

    public class GetAdByDate
    {
    public string AdNumber { get; set; }
    public virtual UserEntity User { get; set; }
    public string AdName { get; set; }
    public string ProvinceName { get; set; }
    public string SpeciesBreed { get; set; }
    public DateTime AdDate { get; set; }
}

