using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.Entity;

internal class UserDataBaseEntity
{
    [Key]
    public Guid UserId { get; set; } = new Guid();
    public string Name { get; set; }
    public string MiddleName { get; set; } 
    public string Email { get; set; }
    public string Password { get; set; }

    public ICollection<UserFriendsDataBaseEntity> FriendEnt { get; set; }

    public UserDataBaseEntity(string Name, string MiddleName, string Email, string Password)
    {
        this.Name = Name;
        this.MiddleName = MiddleName;
        this.Email = Email; 
        this.Password = Password;
        FriendEnt = new List<UserFriendsDataBaseEntity>();
    }
}
