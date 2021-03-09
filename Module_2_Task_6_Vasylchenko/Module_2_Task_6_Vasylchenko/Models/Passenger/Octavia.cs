using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.Passenger
{
    public class Octavia : CarPackageType
    {
        public Octavia(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public override SuspensionType SuspensionType => SuspensionType.MultiLinkSuspension;

        public override CarBodyType CarBodyType => CarBodyType.Sedan;

        public override CarType CarType => CarType.Passenger;

        public override string Name => "Octavia";

        public override FuelType FuelType => FuelType.Gasoline;

        public override double Price => 25000;

        public override double FuelConsumption => 6.5;

        public override PackegeType PackegeType => PackegeType.Lux;
    }
}
