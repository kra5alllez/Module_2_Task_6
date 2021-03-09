using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.SportCars
{
    public class Huracan : CarSpeed
    {
        public Huracan(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public override int MaxCarSpeed => 330;

        public override double AccelerationToAHundred => 2.8;

        public override TypeSportCar TypeSportCar => TypeSportCar.SportsSedan;

        public override CarType CarType => CarType.Sport;

        public override string Name => "Huracan";

        public override FuelType FuelType => FuelType.Gasoline;

        public override double Price => 140000;

        public override double FuelConsumption => 25;
    }
}
