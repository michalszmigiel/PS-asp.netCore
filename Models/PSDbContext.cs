using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Models
{
    public class PSDbContext : IdentityDbContext<IdentityUser>
    {
        public PSDbContext(DbContextOptions<PSDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
