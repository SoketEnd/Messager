using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.Entity;

internal class UserFriendsDataBaseEntity
{
    [Key]
    public Guid FriendID { get; set; } = new Guid();
    public string Name { get; set; }
    public string MiddleName { get; set; }

    [Required]
    public string Email { get; set; }

    [ForeignKey("User")]
    public Guid UserID { get; set; }
    public UserFriendsDataBaseEntity(string name, string middleName, string email, Guid userID)
    {
        Name = name;
        MiddleName = middleName;
        Email = email;
        UserID = userID;
    }
}
