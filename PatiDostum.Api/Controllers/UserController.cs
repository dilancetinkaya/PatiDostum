using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet]
    public IActionResult GetUser()
    {
        var users = _userService.GetUser();
        users?.Select(x => new UserDto
        {
            AddressId = x.AddressId,
            AnimalId = x.AnimalId,
            MessageId = x.MessageId,
            Name = x.Name,
            Surname = x.Surname,


        }).ToList();
        return Ok(users);
    }
    [HttpGet("{id}")]
    public IActionResult GetUserById(string id)
    {
        var user = _userService.GetUserById(id);
        return Ok(user);

    }
    [HttpGet("Advert/{id}")]
    public IActionResult GetUserByAdId(string id)
    {

        var userAd = _userService.GetUserByAdId(id);
        return Ok(userAd);

    }
    [HttpGet("Animal/{id}")]
    public IActionResult GetUserByAnimalId(Guid id)
    {

        var userAnimals = _userService.GetUserByAnimalId(id);
        return Ok(userAnimals);

    }

    [HttpGet("Receiver/{userId}")]
    public IActionResult ReceivedByMe(string userId)
    {
        var userMessages = _userService.ReceivedByMe(userId);
        return Ok(userMessages);
    }


    [HttpGet("Sender/{userId}")]
    public IActionResult SentByMe(string userId)
    {

        var userMessages = _userService.SentByMe(userId);
        return Ok(userMessages);
    }
    [HttpGet("Login")]

    [AllowAnonymous]
    public IActionResult Login(UserDto user, string password)
    {
        var loginUser = _userService.Login(user, password);
        if (loginUser == null) return BadRequest();

        return Ok(loginUser);
    }
    [HttpGet("Logout")]
    [AllowAnonymous]
    public IActionResult Logout()
    {
        _userService.Logout();
        return Ok();
    }
    [HttpPost("Register")]
    [AllowAnonymous]
    public async Task<ActionResult> Register(CreateUserDto user)
    {
        await _userService.Register(user);
        return Ok();
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(UpdateUserDto user,string id)
    {
         _userService.UpdateUser(user,id);
        return Ok();

    }
    [HttpDelete("{id}")]
    public IActionResult DeleteUser(string id)
    {
        _userService.DeleteUser(id);
        return Ok();
    }
}

