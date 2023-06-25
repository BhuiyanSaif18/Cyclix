using Cyclix.Entities;
using Cyclix.Models;
using Microsoft.EntityFrameworkCore;

namespace Cyclix.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ): base(options){
            
        }
        public DbSet<CycleType> CycleTypes { get; set; }
        public DbSet<CycleBrand> CycleBrands { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CycleType>().HasData(
                new CycleType { Id = 1, name = "Rennvelo", lang = "de" },
                new CycleType { Id = 2, name = "Reisevelo", lang = "de" },
                new CycleType { Id = 3, name = "Elektro Velo", lang = "de" },
                new CycleType { Id = 4, name = "Road bike", lang = "en" },
                new CycleType { Id = 5, name = "Trekking bike", lang = "en" },
                new CycleType { Id = 6, name = "Electric bike", lang = "en" }
                    );

            modelBuilder.Entity<CycleBrand>().HasData(
                new CycleType { Id = 1, name = "Trek" },
                new CycleType { Id = 2, name = "BMC" },
                new CycleType { Id = 3, name = "Scott" }
            );
        }
    }
}
