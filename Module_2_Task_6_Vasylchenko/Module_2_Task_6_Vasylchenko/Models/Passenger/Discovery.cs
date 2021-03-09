using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.Passenger
{
    public class Discovery : CarPackageType
    {
        public Discovery(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public override PackegeType PackegeType => PackegeType.Lux;

        public override SuspensionType SuspensionType => SuspensionType.AdaptiveSuspension;

        public override CarBodyType CarBodyType => CarBodyType.SUV;

        public override CarType CarType => CarType.Passenger;

        public override string Name => "Discovery";

        public override FuelType FuelType => FuelType.Diesel;

        public override double Price => 45000;

        public override double FuelConsumption => 8;
    }
}
