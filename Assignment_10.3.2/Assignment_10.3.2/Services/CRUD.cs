using Assignment_10._3._2.Data;
using Assignment_10._3._2.Models;

namespace Assignment_10._3._2.Services;

public class CRUD
{
    public void AddCar(Cars car)
    {
        Records.dealershipContext.CarsSet.Add(car);
        Records.dealershipContext.SaveChanges();
    }
    
    public Cars FindCar(string vin)
    {
        return Records.dealershipContext.CarsSet.Find(vin);
    }

    public void UpdateCar(string vin, Cars updatedCar)
    {
        var car = Records.dealershipContext.CarsSet.Find(vin);
        if (car != null)
        {
            car.VIN = updatedCar.VIN;
            car.Make = updatedCar.Make;
            car.Model = updatedCar.Model;
            car.Year = updatedCar.Year;
            car.Price = updatedCar.Price;
            Records.dealershipContext.CarsSet.Update(updatedCar);
        }
    }
    public void DeleteCar(string vin)
    {
        var car = Records.dealershipContext.CarsSet.Find(vin);
        if (car != null)
        {
            Records.dealershipContext.CarsSet.Remove(car);
        }
        Records.dealershipContext.SaveChanges();
    }

    public List<Cars> GetAllCars()
    {
        return Records.dealershipContext.CarsSet.ToList();
    }
}