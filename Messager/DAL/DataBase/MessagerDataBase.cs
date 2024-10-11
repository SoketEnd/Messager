using Messager.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.DataBase;

class MessagerDataBase : DbContext
{
    public MessagerDataBase() 
    {
        Database.EnsureCreated();
    }

    public DbSet<UserDataBaseEntity> UserDataBase { get; set; }
    public DbSet<UserFriendsDataBaseEntity> UserFriendsDataBase { get; set; }
    public DbSet<MessageDataBaseEntity> MessageDataBase { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-582CB1R;Database=MessagerDataBase;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserDataBaseEntity>().HasKey(u => u.UserId);
        modelBuilder.Entity<UserFriendsDataBaseEntity>().HasKey(x => x.FriendID);
        modelBuilder.Entity<MessageDataBaseEntity>().HasKey(u => u.MessegeID);
    }
}
