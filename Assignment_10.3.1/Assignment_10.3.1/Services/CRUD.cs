using Assignment_10._3._1.Data;
using Assignment_10._3._1.Models;

namespace Assignment_10._3._1.Services;

public class CRUD
{
    public void AddEmployee(Employee employee)
    {
        Records.employeeContext.EmployeeSet.Add(employee);
        Records.employeeContext.SaveChanges();
    }

    public Employee FindEmployee(int id)
    {
        return Records.employeeContext.EmployeeSet.Find(id);
    }

    public void DeleteEmployee(int id)
    {
        var emp = Records.employeeContext.EmployeeSet.Find(id);
        if (emp != null)
        {
            Records.employeeContext.EmployeeSet.Remove(emp);
        }
        Records.employeeContext.SaveChanges();
    }
    public void UpdateEmployee(int id, Employee updateEmployee)
    {
        var emp = Records.employeeContext.EmployeeSet.Find(id);
        if (emp != null)
        {
            emp.Name = updateEmployee.Name;
            emp.Salary = updateEmployee.Salary;
            emp.DepartmentId = updateEmployee.DepartmentId;
            Records.employeeContext.SaveChanges();
        }
    }
    public List<Employee> GetAllEmployees()// currently not being called in the main form
    {
        return Records.employeeContext.EmployeeSet.ToList();
    }
    public List<Department> GetAllDepartments()
    {
        return Records.employeeContext.DepartmentSet.ToList();
    }

    public int GetMaxId()
    {
        return Records.employeeContext.EmployeeSet.Max(e => e.EmployeeId);
    }
}