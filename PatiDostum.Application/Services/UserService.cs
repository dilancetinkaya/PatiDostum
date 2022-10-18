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

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }


    public void DeleteUser(string id)
    {
        _userRepository.DeleteUser(id);
    }

    public List<UserDto> GetUser()
    {
        var userList = _userRepository.GetUser();
        var users = _mapper.Map<List<UserDto>>(userList);
        return users;
    }

    public List<AdvertDto> GetUserByAdId(string id)
    {
        var userByAd = _userRepository.GetUserByAdId(id);
        var userAd = _mapper.Map<List<AdvertDto>>(userByAd);
        return userAd;
    }

    public List<AnimalDto> GetUserByAnimalId(Guid id)
    {
        var userByAnimal = _userRepository.GetUserByAnimalId(id);
        var userAnimal = _mapper.Map<List<AnimalDto>>(userByAnimal);
        return userAnimal;
    }

    public UserDto GetUserById(string id)
    {
        var user = _userRepository.GetUserById(id);
        var userDto = _mapper.Map<UserDto>(user);
        return userDto;
    }

    public string Login(UserDto user, string password)
    {
        var userDto = _mapper.Map<UserEntity>(user);
        var userLogin = _userRepository.Login(userDto, password);
        return userLogin;
    }

    public void Logout()
    {
        _userRepository.Logout();
    }

    public List<MessageDto> ReceivedByMe(string userId)
    {
        var message = _userRepository.ReceivedByMe(userId);
        var messageDto = _mapper.Map<List<MessageDto>>(message);
        return messageDto;
    }

    public async Task Register(CreateUserDto user)
    {
        var userDto = _mapper.Map<UserEntity>(user);

        await _userRepository.Register(userDto, user.Password);

    }

    public List<MessageDto> SentByMe(string userId)
    {
        var message = _userRepository.SentByMe(userId);
        return _mapper.Map<List<MessageDto>>(message);
    }

    public async Task UpdateUser(UpdateUserDto user, string id)
    {
        var updatedUser = _mapper.Map<UserEntity>(user);
        updatedUser.Id = id;
        await _userRepository.UpdateUser(updatedUser);
    }
}

