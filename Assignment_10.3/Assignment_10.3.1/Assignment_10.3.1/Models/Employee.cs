using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_10._3._1.Models;

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }
}