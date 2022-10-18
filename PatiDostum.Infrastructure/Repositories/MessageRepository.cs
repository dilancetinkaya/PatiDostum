using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class MessageRepository : IMessageRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public MessageRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateMessage(MessageEntity message)
    {
        _applicationDbContext.Message.Add(message);
        _applicationDbContext.SaveChanges();
    }

    public void DeleteMessage(Guid id)
    {
        var deletedMessage = _applicationDbContext.Message.FirstOrDefault(x => x.Id == id);
        if (deletedMessage != null)
        {
            _applicationDbContext.Message.Remove(deletedMessage);
            _applicationDbContext.SaveChanges();

        }
    }

    public List<MessageEntity> GetByReceivedMessage(string id)
    {
        var messagesByReceiver = _applicationDbContext.Message.Where(x => x.Receiver.Id == id).ToList();
        return messagesByReceiver;
    }

    public List<MessageEntity> GetBySendMessage(string id)
    {
        var messagesBySend = _applicationDbContext.Message.Where(x => x.Sender.Id == id).ToList();
        return messagesBySend;
    }

    public List<MessageEntity> GetMessage()
    {
        var messageList = _applicationDbContext.Message.ToList();
        return messageList;
    }

    public List<MessageEntity> GetMessageByAdId(Guid id)
    {
        var ilans = (from ad in _applicationDbContext.Advert
                     where ad.Id == id
                     select ad).FirstOrDefault();
        return ilans.Message;
    }

    public MessageEntity GetMessageById(Guid id)
    {
        var message = _applicationDbContext.Message.FirstOrDefault(x => x.Id == id);
        return message;
    }

    public List<MessageEntity> GetMessageByUserId(string id)
    {
        var messagesByUser = (from message in _applicationDbContext.Message
                              where message.Receiver.Id == id
                              select message).ToList();
        return messagesByUser;
    }

    public void UpdateMessage(MessageEntity message)
    {
        var updatedMessage = _applicationDbContext.Message.FirstOrDefault(x => x.Id == message.Id);
        updatedMessage.Receiver = message.Receiver;
        updatedMessage.Sender = message.Sender;
        updatedMessage.Content = message.Content;
        _applicationDbContext.Message.Update(updatedMessage);
        _applicationDbContext.SaveChanges();
    }
}

