using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class RentACarDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Tobeto4A.Onion; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
