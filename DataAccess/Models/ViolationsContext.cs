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
       
        public ViolationsContext()
            : base("name=ViolationsContext")
        {
          
        }

        public System.Data.Entity.DbSet<DataAccess.Models.Driver> Drivers { get; set; }
        public System.Data.Entity.DbSet<DataAccess.Models.Violation> Violations { get; set; }

    }
}

