using Module_2_Task_6_Vasylchenko.Models;
using Module_2_Task_6_Vasylchenko.Services.Abstractions;

namespace Module_2_Task_6_Vasylchenko.Services
{
    public class PriceTaxiStation : IPriceTaxiStation
    {
        public double Cost(AbstractCar[] abstractCars)
        {
            var cost = 0.0;
            foreach (AbstractCar car in abstractCars)
            {
                cost += car.Price;
            }

            return cost;
        }
    }
}
