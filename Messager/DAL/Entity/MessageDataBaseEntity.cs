using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.Entity;

internal class MessageDataBaseEntity
{
    [Key]
    public Guid MessegeID { get; set; } = new Guid();

    public string SenderEmail { get; set; }
    public string Content   { get; set; }

    public MessageDataBaseEntity(string senderEmail, string content)
    {
        SenderEmail = senderEmail;
        Content = content;
    }
}
