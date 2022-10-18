using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

    public class ImageEntity
    {
    public Guid Id { get; set; }
    public Guid AdId { get; set; }
    [ForeignKey("AdId")]
    public virtual AdvertEntity Advert { get; set; }
    public string ImgPath { get; set; }
    public string ImgName { get; set; }
}

