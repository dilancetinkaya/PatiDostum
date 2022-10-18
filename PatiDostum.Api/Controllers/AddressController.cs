using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

//[Authorize]
[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;
    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }
    [HttpGet]
    public IActionResult GetAddress()
    {
        var addressList = _addressService.GetAddress();
        return Ok(addressList);

    }
    [HttpGet("{id}")]
    public IActionResult GetAddressById(Guid id)
    {
        var address = _addressService.GetAddressById(id);
        return Ok(address);

    }
    [HttpGet("User/{id}")]
    [AllowAnonymous]
    public IActionResult GetAddressByUserId(string id)
    {
        var userAddress = _addressService.GetAddressByUserId(id);

        if (userAddress == null) return BadRequest();

        return Ok(userAddress);

    }

    [HttpPost]
    public async Task<IActionResult> CreateAddress(CreateAddressDto address)
    {
        await _addressService.CreateAddress(address);
        return Ok();
    }
    [HttpPut("{id}")]
    public IActionResult UpdateAddress(UpdateAddressDto address, Guid id)
    {

        var updatedAddress = _addressService.UpdateAddress(address, id);
        return Ok(updatedAddress);


    }
    [HttpDelete("{id}")]
    public IActionResult DeleteAddress(Guid id)
    {

        var deletedAddress=_addressService.DeleteAddress(id);
        return Ok(deletedAddress);
    }

}

