
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface IImageService
{
    public List<ImageDto> GetImage();
    public ImageDto GetImageById(Guid id);
    public List<ImageDto> GetImageByAdId(Guid id);
    public void CreateImage(CreateImageDto img);
    public void UpdateImage(UpdateImageDto img,Guid id);
    public void DeleteImage(Guid id);
}

