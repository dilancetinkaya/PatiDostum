using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface IUserService
{
    public List<UserDto> GetUser();
    public UserDto GetUserById(string id);
    public List<AdvertDto> GetUserByAdId(string id);
    public List<AnimalDto> GetUserByAnimalId(Guid id);
    public List<MessageDto> SentByMe(string userId);
    public List<MessageDto> ReceivedByMe(string userId);
    public string Login(UserDto user, string password);
    public void Logout();
    public Task Register(CreateUserDto user);
   
    public Task UpdateUser(UpdateUserDto user,string id);
    public void DeleteUser(string id);
}

