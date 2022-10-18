using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using PatiDostum.Core.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    private readonly UserManager<UserEntity> _userManager;
    private readonly SignInManager<UserEntity> _signInManager;
    private readonly IConfiguration _configuration;

    public UserRepository(ApplicationDbContext applicationDbContext, UserManager<UserEntity> userManager,
        SignInManager<UserEntity> signInManager, IConfiguration configuration)
    {

        _applicationDbContext = applicationDbContext;
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;

    }

    public void DeleteUser(string id)
    {

        var deletedUser = _userManager.Users.FirstOrDefault(x => x.Id == id);
        if (deletedUser != null)
        {
            _applicationDbContext.User.Remove(deletedUser);
            _applicationDbContext.SaveChanges();

        }
    }

    public List<UserEntity> GetUser()
    {
        var userList = _userManager.Users.ToList();
        return userList;
    }

    public List<AdvertEntity> GetUserByAdId(string id)
    {
        var userByAd = (from ad in _applicationDbContext.Advert
                        where ad.User.Id == id
                        select ad).ToList();
        return userByAd;
    }

    public List<AnimalEntity> GetUserByAnimalId(Guid id)
    {
        var userByAnimal = (from animal in _applicationDbContext.Animal
                            where animal.Id == id
                            select animal).ToList();
        return userByAnimal;
    }

    public UserEntity GetUserById(string id)
    {
        var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
        return user;
    }

    public string Login(UserEntity user, string password)
    {
        _signInManager.PasswordSignInAsync(user.UserName, password, false, false);
        var token = GenerateJwt.GetJwtToken(user.UserName, _configuration["Jwt:Key"],
                   _configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], TimeSpan.FromDays(Double.Parse(_configuration["Jwt:ExpirationInDays"]))).ToString();
        return token;
    }

    public void Logout()
    {
        _signInManager.SignOutAsync();
    }

    public List<MessageEntity> ReceivedByMe(string userId)
    {
        var messages = (from message in _applicationDbContext.Message
                        where message.Receiver.Id == userId
                        select message).ToList();
        return messages;
    }

    public async Task Register(UserEntity user, string password)
    {

        await _userManager.CreateAsync(
                      new UserEntity
                      {
                          Email = user.Email,
                          Name = user.Name,
                          Surname = user.Surname,
                          UserName = user.UserName


                      }, password);

    }

    public List<MessageEntity> SentByMe(string userId)
    {
        var messages = (from message in _applicationDbContext.Message
                        where message.Sender.Id == userId
                        select message).ToList();
        return messages;
    }

    public async Task UpdateUser(UserEntity user)
    {

        try
        {
            var updatedUser = await _userManager.FindByIdAsync(user.Id);
            updatedUser.UserName = user.UserName;
            updatedUser.Surname = user.Surname;
            updatedUser.Email = user.Email;
            updatedUser.Address = user.Address;
            updatedUser.PhoneNumber = user.PhoneNumber;
            await _userManager.UpdateAsync(updatedUser);
        }
        catch (Exception)
        {

            throw;
        }


    }
}

