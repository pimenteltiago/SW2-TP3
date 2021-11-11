using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SWII_TP03.DAO {
    public class Context : DbContext {
        public DbSet<Models.BL> BL { get; set; }
        public DbSet<Models.Container> Container { get; set; }
    }
}