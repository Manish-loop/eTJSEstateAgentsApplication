using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eTJSEstateAgents.Models;

namespace eTJSEstateAgents.Data
{
    public class HomeeDbContext : DbContext
    {
        public HomeeDbContext (DbContextOptions<HomeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<eTJSEstateAgents.Models.House> House { get; set; } = default!;
    }
}
