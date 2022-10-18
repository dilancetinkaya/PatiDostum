using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
    private readonly IImageService _imageService;
    public ImageController(IImageService imageService)
    {
        _imageService = imageService;
    }
    [HttpGet]
    public IActionResult GetImage()
    {
        var images=_imageService.GetImage();
        return Ok(images);

    }
    [HttpGet("{id}")]
    public IActionResult GetImageById(Guid id)
    {
        var img = _imageService.GetImageById(id);
        return Ok(img);

    }
    [HttpGet("Advert/{id}")]
    public IActionResult GetImageByAdId(Guid id)
    {
        var imgAd = _imageService.GetImageById(id);
        return Ok(imgAd);
    }

    [HttpPost]
    public IActionResult CreateImage(CreateImageDto image)
    {
        
        _imageService.CreateImage(image);
        return Ok();
    }
    [HttpPut("{id}")]
    public IActionResult UpdateImage(UpdateImageDto img, Guid id)
    {
        _imageService.UpdateImage(img, id);
        return Ok();

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteImage(Guid id)
    {
        _imageService.DeleteImage(id);
        return Ok();
    }
}
