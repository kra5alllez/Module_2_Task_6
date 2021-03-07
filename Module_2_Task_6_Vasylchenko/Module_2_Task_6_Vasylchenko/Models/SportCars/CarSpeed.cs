using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.SportCars
{
    public abstract class CarSpeed : Acceleration
    {
        protected CarSpeed(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public abstract int MaxCarSpeed { get; }
    }
}
