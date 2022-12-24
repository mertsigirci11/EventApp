using Microsoft.EntityFrameworkCore;
using Models;
using Models.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ContentModels;

namespace DataAccess
{
    public class MyAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NFN73G1;Initial Catalog=MyAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //Base
        public DbSet<User> Users { get; set; }

        //Friend
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<FriendshipStatus> FriendshipStatuses { get; set; }

        //Content Models
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentNotification> ContentNotifications { get; set; }
        public DbSet<ContentStatistics> ContentStatistics { get; set; }

    }
}
