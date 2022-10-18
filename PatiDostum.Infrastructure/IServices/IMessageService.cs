using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface IMessageService
{
    public List<MessageDto> GetMessage();
    public MessageDto GetMessageById(Guid id);
    public List<MessageDto> GetMessageByReceivedId(string id);
    public List<MessageDto> GetMessageBySendId(string id);
    public List<MessageDto> GetMessageByAdId(Guid id);
    public List<MessageDto> GetMessageByUserId(string id);
    public void CreateMessage(CreateMessageDto message);
    public void UpdateMessage(UpdateMessageDto message,Guid id);
    public void DeleteMessage(Guid id);
}

