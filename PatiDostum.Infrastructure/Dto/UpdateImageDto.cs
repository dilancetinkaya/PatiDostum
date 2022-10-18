using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

public class UpdateImageDto
{
    public Guid AdId { get; set; }
    public string ImgPath { get; set; }
    public string ImgName { get; set; }
}

