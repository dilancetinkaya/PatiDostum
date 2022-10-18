using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

public interface IMessageRepository
{
    public List<MessageEntity> GetMessage();
    public MessageEntity GetMessageById(Guid id);
    public List<MessageEntity> GetByReceivedMessage(string id);
    public List<MessageEntity> GetBySendMessage(string id);
    public List<MessageEntity> GetMessageByAdId(Guid id);

    public List<MessageEntity> GetMessageByUserId(string id);
    public void CreateMessage(MessageEntity message);
    public void UpdateMessage(MessageEntity message);
    public void DeleteMessage(Guid id);
}

