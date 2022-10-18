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

public class MessageService : IMessageService
{
    private readonly IMessageRepository _messageRepository;
    private readonly IMapper _mapper;
    public MessageService(IMessageRepository messageRepository,IMapper mapper)
    {
        _messageRepository = messageRepository; 
        _mapper = mapper;   
    }
    public void CreateMessage(CreateMessageDto message)
    {
        var cretedMessage=_mapper.Map<MessageEntity>(message);
        _messageRepository.CreateMessage(cretedMessage);
    }

    public void DeleteMessage(Guid id)
    {
        _messageRepository.DeleteMessage(id);
    }

    public List<MessageDto> GetMessageByReceivedId(string id)
    {
       var receivedMessage=_messageRepository.GetByReceivedMessage(id);
       var receivedMessageDto= _mapper.Map<List<MessageDto>>(receivedMessage);
        return receivedMessageDto;

    }

    public List<MessageDto> GetMessageBySendId(string id)
    {
        var sentMessage = _messageRepository.GetBySendMessage(id);
        var sentMessageDto = _mapper.Map<List<MessageDto>>(sentMessage);
        return sentMessageDto;
    }

    public List<MessageDto> GetMessage()
    {
       var messageList= _messageRepository.GetMessage();
        var messages=_mapper.Map<List<MessageDto>>(messageList);
        return messages;
    }

    public List<MessageDto> GetMessageByAdId(Guid id)
    {
        var messageByAd = _messageRepository.GetMessageByAdId(id);
        var messages = _mapper.Map<List<MessageDto>>(messageByAd);
        return messages;
    }

    public MessageDto GetMessageById(Guid id)
    {

        var message = _messageRepository.GetMessageById(id);
        var messageDto = _mapper.Map<MessageDto>(message);
        return messageDto;
    }

    public List<MessageDto> GetMessageByUserId(string id)
    {
        var messageByUser = _messageRepository.GetMessageByUserId(id);
        var messages = _mapper.Map<List<MessageDto>>(messageByUser);
        return messages;
    }

    public void UpdateMessage(UpdateMessageDto message,Guid id)
    {
        var updatedMessage=_mapper.Map<MessageEntity>(message);
        updatedMessage.Id= id;
        _messageRepository.UpdateMessage(updatedMessage);
    }
}
