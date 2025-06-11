using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Assignment_10._3._1.Data;
using Assignment_10._3._1.Models;
using Assignment_10._3._1.Services;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3._1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private CRUD crudService;

    public MainWindow()
    {
        InitializeComponent();
        Records.employeeContext = new EmployeeContext();
        Records.employeeContext.Database.EnsureCreated();
        Records.employeeContext.DepartmentSet.Load();
        Records.employeeContext.EmployeeSet.Load();
        
        crudService = new CRUD();
        LoadData();
    }
    private void LoadData()
    {
        EmployeeDataGrid.ItemsSource = Records.employeeContext.EmployeeSet.Local.ToBindingList();
        DepartmentDataGrid.ItemsSource = Records.employeeContext.DepartmentSet.Local.ToBindingList();
    }
    private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)//brings up add new employee form
    {
        var employeeAddForm = new EmployeeInputDialog();
        if (employeeAddForm.ShowDialog() == true)
        {
            try
            {
                var newEmployee = new Employee
                {
                    EmployeeId = crudService.GetMaxId() + 1, //add after last record in db
                    Name = employeeAddForm.EmployeeName, //assign user input into props for new emp
                    Salary = employeeAddForm.EmployeeSalary,
                    DepartmentId = employeeAddForm.DepartmentId
                };

                crudService.AddEmployee(newEmployee); //calls CRUD method to add new employee then save the db
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    private void UpdateEmployeeBtn_Click(object sender, RoutedEventArgs e)
    {
        if (EmployeeDataGrid.SelectedItem is Employee selectedEmployee)
        {
            var inputDialog = new EmployeeInputDialog(selectedEmployee);
            if (inputDialog.ShowDialog() == true)
            {
                try
                {
                    var updatedEmployee = new Employee
                    {
                        Name = inputDialog.EmployeeName,
                        Salary = inputDialog.EmployeeSalary,
                        DepartmentId = inputDialog.DepartmentId
                    };

                    crudService.UpdateEmployee(selectedEmployee.EmployeeId, updatedEmployee);// calls CRUD method to update employee then save the db
                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select an employee to update.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }

    private void DeleteEmployeeBtn_Click(object sender, RoutedEventArgs e)
    {
        if (EmployeeDataGrid.SelectedItem is Employee selectedEmployee)
        {
            var userResponse = MessageBox.Show($"Are you sure you want to delete employee '{selectedEmployee.Name}'?", 
                "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (userResponse == MessageBoxResult.Yes)
            {
                try
                {
                    crudService.DeleteEmployee(selectedEmployee.EmployeeId);// calls CRUD method to delete employee then save the db
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select an employee to delete.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }

    private void RefreshEmployeesBtn_Click(object sender, RoutedEventArgs e) => LoadData();
    private void RefreshDepartmentsBtn_Click(object sender, RoutedEventArgs e) => LoadData();
}