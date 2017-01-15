using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class POSContext:DbContext
    {
        public POSContext(DbContextOptions options) : base(options) { }

        public DbSet<User> user { set; get; }
        public DbSet<CataLog> catalog { set; get; }
        public DbSet<Inventory> inve { set; get; }
    }
}
