using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Models
{
    public class PSDbContext : DbContext
    {
        public PSDbContext(DbContextOptions<PSDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; }

    }
}
