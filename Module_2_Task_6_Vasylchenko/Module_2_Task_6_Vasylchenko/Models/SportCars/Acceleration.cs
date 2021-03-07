using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_6_Vasylchenko.Models.SportCars
{
    public abstract class Acceleration : SportCarBodyType
    {
        protected Acceleration(double weight, Enums.Country countryOfOrigin, Enums.EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public abstract double AccelerationToAHundred { get; }
    }
}
