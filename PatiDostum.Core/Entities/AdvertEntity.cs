using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.Entities;

    public class AdvertEntity
    {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string AdNumber { get; set; }
    public string Statement { get; set; }
    public string UserId { get; set; }
    public Guid AddressId { get; set; }
    public Guid AdKindId { get; set; }
    public Guid MessageId { get; set; }
    public Guid AnimalId { get; set; }
    public DateTime AdDate { get; set; }
    [ForeignKey("UserId")]
    public virtual UserEntity User { get; set; }
    [ForeignKey("AnimalId")]
    public virtual AnimalEntity Animal { get; set; }
    [ForeignKey("AddressId")]
    public virtual AddressEntity Address { get; set; }
    [ForeignKey("AdKindId")]
    public virtual AdKindEntity AdKind { get; set; }
    [ForeignKey("MesajId")]
    public virtual List<MessageEntity> Message { get; set; }

   
}

