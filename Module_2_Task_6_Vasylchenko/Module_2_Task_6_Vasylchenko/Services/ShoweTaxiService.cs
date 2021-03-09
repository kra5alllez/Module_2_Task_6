using System;
using Module_2_Task_6_Vasylchenko.Models;
using Module_2_Task_6_Vasylchenko.Models.Passenger;
using Module_2_Task_6_Vasylchenko.Models.SportCars;
using Module_2_Task_6_Vasylchenko.Services.Abstractions;

namespace Module_2_Task_6_Vasylchenko.Services
{
    public class ShoweTaxiService : IShoweTaxiService
    {
        public void ShoweCar(AbstractCar[] abstractCars)
        {
            foreach (AbstractCar item in abstractCars)
            {
                var car1 = item as CarPackageType;
                if (car1 != null)
                {
                    Console.WriteLine($"Name: {car1.Name}, Price: {car1.Price}, FuelConsumption: {car1.FuelConsumption}, Packege: {car1.PackegeType} ");
                    continue;
                }

                var car2 = item as CarSpeed;
                if (car2 != null)
                {
                    Console.WriteLine($"Name: {car2.Name}, Price: {car2.Price}, FuelConsumption: {car2.FuelConsumption}, Acceleration: {car2.AccelerationToAHundred} ");
                }
            }
        }
    }
}
