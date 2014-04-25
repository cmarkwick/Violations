using System;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{


    public class ViolationsContext : DbContext
    {
        public DbSet<Violation> Violations {get; set;}
        public DbSet<Driver> Drivers { get; set; }

    }
}

