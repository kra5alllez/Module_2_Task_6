using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.SportCars
{
    public class Taycan : CarSpeed
    {
        public Taycan(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public override int MaxCarSpeed => 310;

        public override double AccelerationToAHundred => 3.1;

        public override TypeSportCar TypeSportCar => TypeSportCar.SportsSedan;

        public override CarType CarType => CarType.Sport;

        public override string Name => "Taycan";

        public override FuelType FuelType => FuelType.Hybrid;

        public override double Price => 120000;

        public override double FuelConsumption => 12;
    }
}
