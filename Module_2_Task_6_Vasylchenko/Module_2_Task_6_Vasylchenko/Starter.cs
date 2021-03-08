using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_6_Vasylchenko.Helpers.Comparers;
using Module_2_Task_6_Vasylchenko.Helpers.Extentions;
using Module_2_Task_6_Vasylchenko.Models.Enums;
using Module_2_Task_6_Vasylchenko.Services;

namespace Module_2_Task_6_Vasylchenko
{
    public class Starter
    {
        private readonly CarService _carService;
        private readonly ShoweTaxiService _show;
        private readonly PriceTaxiStation _price;

        public Starter()
        {
            _carService = new CarService();
            _show = new ShoweTaxiService();
            _price = new PriceTaxiStation();
        }

        public void Run()
        {
            var taxiSation = _carService.CreateTaxiStation();
            Array.Sort(taxiSation, new CarComparer());
            _show.ShoweCar(taxiSation);
            Console.WriteLine("Taxi station cost: " + _price.Cost(taxiSation));
            _show.ShoweCar(taxiSation.SearchCar(10, PackegeType.Lux));
        }
    }
}
