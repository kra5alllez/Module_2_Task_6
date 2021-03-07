using Module_2_Task_6_Vasylchenko.Models;
using Module_2_Task_6_Vasylchenko.Models.Enums;
using Module_2_Task_6_Vasylchenko.Models.Passenger;
using Module_2_Task_6_Vasylchenko.Models.SportCars;

namespace Module_2_Task_6_Vasylchenko.Services
{
    public class CarService
    {
        public CarService()
        {
        }

        public AbstractCar[] CreateTaxiStation()
        {
            var taxiStation = new AbstractCar[]
            {
                new Golf(2000, Country.Germany, EuroNcap.FiveStars, 5),
                new Octavia(2100, Country.CzechRepublic, EuroNcap.FourStars, 5),
                new Discovery(2500, Country.Britannia, EuroNcap.FiveStars, 7),
                new Prado(2300, Country.Japan, EuroNcap.FourStars, 5),
                new Huracan(1500, Country.Germany, EuroNcap.FiveStars, 2),
                new Taycan(1900, Country.Germany, EuroNcap.FiveStars, 4)
            };

            return taxiStation;
        }
    }
}
