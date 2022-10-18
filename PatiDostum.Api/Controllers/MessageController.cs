using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;

namespace PatiDostum.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IMessageService _messageService;
    public MessageController(IMessageService messageService)
    {
        _messageService = messageService;
    }
    [HttpGet]
    public IActionResult GetMessage()
    {
        var messages = _messageService.GetMessage();
        return Ok(messages);

    }
    [HttpGet("{id}")]
    public IActionResult GetMessageById(Guid id)
    {
        var message =_messageService.GetMessageById(id);
        return Ok(message);

    }
    [HttpGet("Receiver/{id}")]
    public IActionResult GetMessageByReceivedId(string id)
    {
        var receivedMessages = _messageService.GetMessageByReceivedId(id);
        return Ok(receivedMessages);

    }
    [HttpGet("Sender/{id}")]
    public IActionResult GetMessageBySendId(string id)
    {
        var sendMessages =_messageService.GetMessageBySendId(id);
        return Ok(sendMessages);
    }
    [HttpGet("AdRepies/{id}")]
    public IActionResult GetMessageByAdId(Guid id)
    {
        var adMessages = _messageService.GetMessageByAdId(id);

        return Ok(adMessages);
    }
    [HttpGet("User/{id}")]
    public IActionResult GetMessageByUserId(string id)
    {
        var userMessages = _messageService.GetMessageByUserId(id);
        return Ok(userMessages);

    }

    [HttpPost]
    public IActionResult CreateMessage(CreateMessageDto message)
    {
        _messageService.CreateMessage(message);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMessage (UpdateMessageDto message, Guid id)
    {
        _messageService.UpdateMessage(message, id);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteMessage(Guid id)
    {
        _messageService.DeleteMessage(id);
        return Ok();
    }
}

