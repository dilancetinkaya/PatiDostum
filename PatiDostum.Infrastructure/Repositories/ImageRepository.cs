using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class ImageRepository : IImageRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public ImageRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateImage(ImageEntity img)
    {
        _applicationDbContext.Image.Add(img);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteImage(Guid id)
    {
        var deletedImg = _applicationDbContext.Image.FirstOrDefault(x => x.Id == id);
        if (deletedImg != null)
        {
            _applicationDbContext.Image.Remove(deletedImg);
            _applicationDbContext.SaveChanges();

        }
    }

    public List<ImageEntity> GetImage()
    {
        var imgList = _applicationDbContext.Image.ToList();
        return imgList;
    }

    public List<ImageEntity> GetImageByAdId(Guid id)
    {
        var imgByAdList = _applicationDbContext.Image.Where(x => x.Advert.Id == id).ToList();
        return imgByAdList;

    }

    public ImageEntity GetImageById(Guid id)
    {
        var img = _applicationDbContext.Image.FirstOrDefault(x => x.Id == id);
        return img;
    }

    public void UpdateImage(ImageEntity img)
    {
        var updatedImg = _applicationDbContext.Image.FirstOrDefault(x => x.Id == img.Id);
        updatedImg.Advert = img.Advert;
        updatedImg.ImgPath = img.ImgPath;
        updatedImg.ImgName = img.ImgName;
        _applicationDbContext.Update(updatedImg);
        _applicationDbContext.SaveChanges();

    }
}

