using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

    public class MessageEntity
    {
    public Guid Id { get; set; }
    public string ReceiverId { get; set; }
    public string SenderId { get; set; }
    public Guid RepliesId { get; set; }
    [ForeignKey("ReceiverId")]
    public virtual UserEntity Receiver { get; set; }
    [ForeignKey("SenderId")]
    public virtual UserEntity Sender { get; set; }
    public string Content { get; set; }
    public DateTime SendData { get; set; }
    public DateTime ReadDate { get; set; }
    [ForeignKey("RepliesId")]

    public virtual List<MessageReplyEntity> Replies { get; set; }//?
}

public class MessageReplyEntity//dbset
{
    public Guid Id { get; set; }
    //public Guid MesajId { get; set; }
    public string ReplyingId { get; set; }
    //[ForeignKey("MesajId")]
    //public virtual MesajEntity Mesaj { get; set; }
    [ForeignKey("ReplyingId")]
    public UserEntity ReplyingUser { get; set; }
    public string Reply { get; set; }
}
    

