using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models
{
    public abstract class AbstractCar
    {
        protected AbstractCar(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
        {
            Weight = weight;
            CountryOfOrigin = countryOfOrigin;
            EuroNcap = euroNcap;
            PassengerCapacity = passengerCapacity;
        }

        public abstract string Name { get; }

        public abstract FuelType FuelType { get; }

        public abstract double Price { get; }

        public abstract double FuelConsumption { get; }

        public double Weight { get; }

        public Country CountryOfOrigin { get; }

        public EuroNcap EuroNcap { get; }

        public int PassengerCapacity { get; }
    }
}
