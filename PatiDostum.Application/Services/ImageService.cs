using AutoMapper;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Services;

public class ImageService : IImageService
{
    private readonly IImageRepository _imageRepository;
    private readonly IMapper _mapper;
    public ImageService(IImageRepository imageRepository, IMapper mapper)
    {
        _imageRepository = imageRepository;
        _mapper = mapper;
    }
    public void CreateImage(CreateImageDto img)
    {
        var createdImg = _mapper.Map<ImageEntity>(img);
        _imageRepository.CreateImage(createdImg);
    }

    public void DeleteImage(Guid id)
    {
        _imageRepository.DeleteImage(id);
    }

    public List<ImageDto> GetImage()
    {
        var imageList = _imageRepository.GetImage();
        var images = _mapper.Map<List<ImageDto>>(imageList);
        return images;
    }

    public List<ImageDto> GetImageByAdId(Guid id)
    {
        var imgByAdList = _imageRepository.GetImageByAdId(id);
        var imgByAdDto = _mapper.Map<List<ImageDto>>(imgByAdList);
        return imgByAdDto;
    }

    public ImageDto GetImageById(Guid id)
    {
        var img = _imageRepository.GetImageById(id);
        var imgDto = _mapper.Map<ImageDto>(img);
        return imgDto;
    }

    public void UpdateImage(UpdateImageDto img,Guid id)
    {
        var imgDto = _mapper.Map<ImageEntity>(img);
        imgDto.Id = id;
         _imageRepository.UpdateImage(imgDto);
        

    }
}

