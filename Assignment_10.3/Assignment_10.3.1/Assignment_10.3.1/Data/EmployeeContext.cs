using Assignment_10._3._1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3._1.Data;

public class EmployeeContext : DbContext
{
    public DbSet<Department> DepartmentSet { get; set; }
    public DbSet<Employee> EmployeeSet { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "data source=DGDesktop2024\\MSSQLSERVER04;initial catalog=PCAD17Employees;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().HasData(
            new Department
            {
                DepartmentId = 1,
                DepartmentName = "HR",
                DepartmentLocation = "Seattle"

            },
            new Department
            {
                DepartmentId = 2,
                DepartmentName = "IT",
                DepartmentLocation = "New York"
            },
            new Department
            {
                DepartmentId = 3,
                DepartmentName = "Sales",
                DepartmentLocation = "Chicago"
            }
        );
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                EmployeeId = 101,
                Name = "Mike Jones",
                Salary = 50000,
                DepartmentId = 1
            },
            new Employee
            {
                EmployeeId = 102,
                Name = "Jerry Rice",
                Salary = 65000,
                DepartmentId = 2
            },
            new Employee
            {
                EmployeeId = 103,
                Name = "Rod Woodson",
                Salary = 75000,
                DepartmentId = 3
            }
        );
    }
}