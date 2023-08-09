using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RentalCarAPI.Data
{
    public class RentalCarAPIContext : DbContext
    {
        public RentalCarAPIContext (DbContextOptions<RentalCarAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Repositories.Entities.Car> Car { get; set; } = default!;

        public DbSet<Repositories.Entities.Customer>? Customer { get; set; }

        public DbSet<Repositories.Entities.Rental>? Rental { get; set; }        
    }
}
