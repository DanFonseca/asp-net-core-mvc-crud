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
        public asp_net_core_crudContext (DbContextOptions<asp_net_core_crudContext> options)
            : base(options)
        {
        }

        public DbSet<asp_net_core_crud.Models.Department> Department { get; set; }
    }
}
