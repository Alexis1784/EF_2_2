using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EF_2_2
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("UserDB")
        { }

        public DbSet<User> Users { get; set; }
    }
}
