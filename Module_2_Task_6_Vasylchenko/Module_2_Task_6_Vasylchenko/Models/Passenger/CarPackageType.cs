using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.Passenger
{
    public abstract class CarPackageType : CarSuspension
    {
        protected CarPackageType(double weight, Country countryOfOrigin, EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public abstract PackegeType PackegeType { get; }
    }
}
