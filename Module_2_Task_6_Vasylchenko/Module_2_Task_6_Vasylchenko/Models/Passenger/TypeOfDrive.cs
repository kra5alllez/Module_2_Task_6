namespace Module_2_Task_6_Vasylchenko.Models.Passenger
{
    public abstract class TypeOfDrive : BodyTypeCar
    {
        protected TypeOfDrive(double weight, Enums.Country countryOfOrigin, Enums.EuroNcap euroNcap, int passengerCapacity)
            : base(weight, countryOfOrigin, euroNcap, passengerCapacity)
        {
        }

        public TypeOfDrive TypeDrive { get; }
    }
}
