using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.Passenger
{
    public class Prado : CarPackageType
    {
        public Prado(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
    : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public override SuspensionType SuspensionType => SuspensionType.MultiLinkSuspension;

        public override CarBodyType CarBodyType => CarBodyType.SUV;

        public override CarType CarType => CarType.Passenger;

        public override string Name => "Prado";

        public override FuelType FuelType => FuelType.Diesel;

        public override double Price => 60000;

        public override double FuelConsumption => 11;

        public override PackegeType PackegeType => PackegeType.Style;
    }
}
