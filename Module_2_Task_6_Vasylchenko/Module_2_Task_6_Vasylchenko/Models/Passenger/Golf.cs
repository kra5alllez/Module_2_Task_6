using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.Passenger
{
    public class Golf : CarPackageType
    {
        public Golf(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
    : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public override SuspensionType SuspensionType => SuspensionType.DoubleWishbone;

        public override CarBodyType CarBodyType => CarBodyType.Hatchback;

        public override CarType CarType => CarType.Passenger;

        public override string Name => "Golf";

        public override FuelType FuelType => FuelType.Hybrid;

        public override double Price => 35000;

        public override double FuelConsumption => 3;

        public override PackegeType PackegeType => PackegeType.Lux;
    }
}
