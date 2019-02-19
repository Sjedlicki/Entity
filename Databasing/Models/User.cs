using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Databasing.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User() { }

    }

    public class UserDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
    }
}