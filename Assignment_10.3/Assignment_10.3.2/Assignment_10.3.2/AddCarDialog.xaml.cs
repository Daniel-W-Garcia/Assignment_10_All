using System.Windows;
using Assignment_10._3._2.Models;

namespace Assignment_10._3._2;

public partial class AddCarDialog : Window
{
    public string VehicleVIN { get; private set; }
    public int VehiclePrice { get; private set; }
    public Cars.Manufacturer VehicleMake { get; private set; }
    public string VehicleModel { get; private set; }
    public int VehicleYear { get; private set; }

    public AddCarDialog()
    {
        InitializeComponent();
        LoadComboBoxData();
    }
    private void LoadComboBoxData()
    {
        MakeComboBox.ItemsSource = Enum.GetValues(typeof(Cars.Manufacturer));
    }

    private void OkButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (ValidateInput())
        {
            VehicleModel = ModelTextBox.Text;
            VehicleYear = int.Parse(YearTextBox.Text);
            VehiclePrice = int.Parse(PriceTextBox.Text);
            VehicleVIN = VinTextBox.Text;
            DialogResult = true;
        }
    }
    private bool ValidateInput()
    {
        if (MakeComboBox.SelectedItem is Cars.Manufacturer selectedMake)
        {
            VehicleMake = selectedMake;
        }
        else
        {
            MessageBox.Show("Please select a make.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(VinTextBox.Text))
        {
            MessageBox.Show("VIN is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            return false;
        }

        if (!double.TryParse(PriceTextBox.Text, out _))// this is just a discard out variable. only validating if we CAN parse it.
        {
            MessageBox.Show("Please enter a valid salary.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            return false;
        }
        return true;
    }
}