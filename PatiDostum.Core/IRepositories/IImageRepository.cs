using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

    public interface IImageRepository
    {
    public List<ImageEntity> GetImage();
    public ImageEntity GetImageById(Guid id);
    public List<ImageEntity> GetImageByAdId(Guid id);
    public void CreateImage(ImageEntity img);
    public void UpdateImage(ImageEntity img);
    public void DeleteImage(Guid id);
}

