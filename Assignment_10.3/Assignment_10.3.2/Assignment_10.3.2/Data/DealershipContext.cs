using Assignment_10._3._2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3._2.Data;

public class DealershipContext : DbContext
{
    public DbSet<Cars> CarsSet { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "data source=DGDesktop2024\\MSSQLSERVER04;initial catalog=PCAD17Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cars>().HasData(
            new Cars
            {
                Make = Cars.Manufacturer.Toyota,
                Model = "Tacoma",
                Price = 40000,
                Year = 2025,
                VIN = "8J6E7N5N3Y0U9"
            },
            new Cars
            {
                Make = Cars.Manufacturer.Chevy,
                Model = "Silverado",
                Price = 55000,
                Year = 2024,
                VIN = "M6I9K4E2J0O9N7E0S"
            },
            new Cars
            {
                Make = Cars.Manufacturer.Honda,
                Model = "Civic",
                Price = 25000,
                Year = 2023,
                VIN = "H1I0D0D0E1N1M1E0S1S0A1GE"
            },
            new Cars
            {
                Make = Cars.Manufacturer.Ford,
                Model = "Pinto",
                Price = 15000,
                Year = 1980,
                VIN = "1900MIXALOTL1O2L3"
            }
        );
    }
}