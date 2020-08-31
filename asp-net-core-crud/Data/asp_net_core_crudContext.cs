using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp_net_core_crud.Models;

namespace asp_net_core_crud.Data
{
    public class asp_net_core_crudContext : DbContext
    {

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }


        public asp_net_core_crudContext(DbContextOptions<asp_net_core_crudContext> options)
            : base(options)
        {
        }
        
    }
}
