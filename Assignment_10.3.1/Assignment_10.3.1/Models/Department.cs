using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignment_10._3._1.Models;

public class Department
{
    [Key]
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentLocation { get; set; }
    
    public virtual ObservableCollectionListSource<Employee> Employees { get; set; }
}