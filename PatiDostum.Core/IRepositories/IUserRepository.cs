using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

public interface IUserRepository
{
    public List<UserEntity> GetUser();
    public UserEntity GetUserById(string id);
    public List<AdvertEntity> GetUserByAdId(string id);
    public List<AnimalEntity> GetUserByAnimalId(Guid id);
    public List<MessageEntity> SentByMe(string userId);
    public List<MessageEntity> ReceivedByMe(string userId);
    public string Login(UserEntity user, string password);
    public void Logout();
    public Task Register(UserEntity user, string password);

    public Task UpdateUser(UserEntity user);
    public void DeleteUser(string id);
}

