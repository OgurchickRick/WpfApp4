using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace ClassLibrary1
{
    public class DBContext : DbContext
    {
        public DBContext() 
            :base("DbConnection") 
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Special> Specials { get; set; }
    }
}
