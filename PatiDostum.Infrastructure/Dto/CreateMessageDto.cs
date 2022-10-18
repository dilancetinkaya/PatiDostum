using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Dto;

public class CreateMessageDto
{
    public string ReceiverId { get; set; }
    public string SenderId { get; set; }
    public Guid RepliesId { get; set; }
    public string Content { get; set; }
    public DateTime SendData { get; set; }
    public DateTime ReadDate { get; set; }
}

