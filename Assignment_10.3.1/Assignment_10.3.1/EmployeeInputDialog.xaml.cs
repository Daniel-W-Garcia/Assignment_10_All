using System.Windows;
using Assignment_10._3._1.Models;

namespace Assignment_10._3._1;

public partial class EmployeeInputDialog : Window
{
    public string EmployeeName { get; private set; }
    public double EmployeeSalary { get; private set; }
    public int DepartmentId { get; private set; }

    public EmployeeInputDialog()
    {
        InitializeComponent();
    }
    public EmployeeInputDialog(Employee employee) : this()
    {
        NameTextBox.Text = employee.Name;
        SalaryTextBox.Text = employee.Salary.ToString();
        DepartmentIdTextBox.Text = employee.DepartmentId.ToString();
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        if (ValidateInput())
        {
            EmployeeName = NameTextBox.Text;
            EmployeeSalary = double.Parse(SalaryTextBox.Text);
            DepartmentId = int.Parse(DepartmentIdTextBox.Text);
            DialogResult = true;
        }
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(NameTextBox.Text))
        {
            MessageBox.Show("Name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            return false;
        }

        if (!double.TryParse(SalaryTextBox.Text, out _))// this is just a discard out variable. only validating if we CAN parse it.
        {
            MessageBox.Show("Please enter a valid salary.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            return false;
        }

        if (!int.TryParse(DepartmentIdTextBox.Text, out _))// same as above explanation. we can rename '_' to anything like 'disposedvar'
        {
            MessageBox.Show("Please enter a valid department ID.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            return false;
        }

        return true;
    }

}