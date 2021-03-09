using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_6_Vasylchenko.Models;
using Module_2_Task_6_Vasylchenko.Models.Enums;
using Module_2_Task_6_Vasylchenko.Models.Passenger;

namespace Module_2_Task_6_Vasylchenko.Helpers.Extentions
{
    public static class CarExtentions
    {
        public static AbstractCar[] SearchCar(this AbstractCar[] abstractCars, double fuelConsumption, PackegeType packegeType)
        {
            var searchCar = new AbstractCar[abstractCars.Length];
            var counter = 0;
            foreach (AbstractCar cars in abstractCars)
            {
                var car = cars as CarPackageType;
                if (car != null)
                {
                    if (car.FuelConsumption < fuelConsumption && car.PackegeType == packegeType)
                    {
                        searchCar[counter] = car;
                        counter++;
                    }
                }
            }

            return searchCar;
        }
    }
}
