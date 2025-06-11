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
using Assignment_10._3._2.Data;
using Assignment_10._3._2.Models;
using Assignment_10._3._2.Services;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3._2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private CRUD crudService;
    public MainWindow()
    {
        InitializeComponent();
        Records.dealershipContext = new DealershipContext();
        Records.dealershipContext.Database.EnsureCreated();
        Records.dealershipContext.CarsSet.Load();

        crudService = new CRUD();
        LoadData();
    }

    private void LoadData()
    {
        CarsDataGrid.ItemsSource = Records.dealershipContext.CarsSet.Local.ToBindingList();
    }
    private void AddCarBtn_OnClick(object sender, RoutedEventArgs e)
    {
        var vehicleAddForm = new AddCarDialog();
        if (vehicleAddForm.ShowDialog() == true)
        {
            try
            {
                var newCar = new Cars
                {
                    VIN = vehicleAddForm.VehicleVIN,
                    Make = vehicleAddForm.VehicleMake,
                    Model = vehicleAddForm.VehicleModel,
                    Year = vehicleAddForm.VehicleYear,
                    Price = vehicleAddForm.VehiclePrice
                };
                crudService.AddCar(newCar);
                MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding vehicle: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    private void UpdateCarBtn_OnClick(object sender, RoutedEventArgs e)
    {
        if (CarsDataGrid.SelectedItem is Cars selectedCar)
        {
            var vehicleAddForm = new AddCarDialog();
            if (vehicleAddForm.ShowDialog() == true)
            {
                try
                {
                    var updatedCar = new Cars
                    {
                        VIN = vehicleAddForm.VehicleVIN,
                        Make = vehicleAddForm.VehicleMake,
                        Model = vehicleAddForm.VehicleModel,
                        Year = vehicleAddForm.VehicleYear,
                        Price = vehicleAddForm.VehiclePrice
                    };
                    crudService.UpdateCar(selectedCar.VIN, updatedCar);
                    MessageBox.Show("Vehicle updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding vehicle: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a vehicle to update.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }

    private void DeleteCarBtn_OnClick(object sender, RoutedEventArgs e)
    {
        if (CarsDataGrid.SelectedItem is Cars selectedCar)
        {
            var userResponse = MessageBox.Show($"Are you sure you want to delete this vehicle '{selectedCar.VIN}'?",
                "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (userResponse == MessageBoxResult.Yes)
            {
                try
                {
                    crudService.DeleteCar(selectedCar.VIN);
                    MessageBox.Show("Vehicle deleted successfully!", "Success", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting vehicle: {ex.Message}", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select an employee to delete.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }

    private void ReloadCarsBtn_OnClick(object sender, RoutedEventArgs e) => LoadData();

}