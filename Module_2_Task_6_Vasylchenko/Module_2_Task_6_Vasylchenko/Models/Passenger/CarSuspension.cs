using Module_2_Task_6_Vasylchenko.Models.Enums;

namespace Module_2_Task_6_Vasylchenko.Models.Passenger
{
    public abstract class CarSuspension : TypeOfDrive
    {
        protected CarSuspension(double weight, Enums.Country countryOfOrigin, Enums.EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public abstract SuspensionType SuspensionType { get; }
    }
}
