using Module_2_Task_6_Vasylchenko.Models;

namespace Module_2_Task_6_Vasylchenko.Services.Abstractions
{
    public interface IPriceTaxiStation
    {
        double Cost(AbstractCar[] abstractCars);
    }
}
