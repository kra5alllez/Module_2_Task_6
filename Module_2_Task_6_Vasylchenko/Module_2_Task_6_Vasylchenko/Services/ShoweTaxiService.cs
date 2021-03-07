using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_6_Vasylchenko.Models;
using Module_2_Task_6_Vasylchenko.Models.Passenger;
using Module_2_Task_6_Vasylchenko.Models.SportCars;

namespace Module_2_Task_6_Vasylchenko.Services
{
    public class ShoweTaxiService
    {
        public void Showe(AbstractCar[] abstractCars)
        {
            foreach (AbstractCar cars in abstractCars)
            {
                var car1 = cars as CarPackageType;
                if (car1 != null)
                {
                    Console.WriteLine($"Name: {car1.Name}, Price: {car1.Price}, FuelConsumption: {car1.FuelConsumption}, Packege: {car1.PackegeType} ");
                    continue;
                }

                var car2 = cars as CarSpeed;
                if (car2 != null)
                {
                    Console.WriteLine($"Name: {car1.Name}, Price: {car1.Price}, FuelConsumption: {car1.FuelConsumption}, Mas Speed: {car1.PackegeType} ");
                }
            }
        }
    }
}
