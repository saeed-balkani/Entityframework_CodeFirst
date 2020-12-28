using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Entityframework_CodeFirst.Models;

namespace Entityframework_CodeFirst.Models
{

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<Role> AllRoles { get; set; }
        public virtual DbSet<User> AllUsers { get; set; }
    }
}
