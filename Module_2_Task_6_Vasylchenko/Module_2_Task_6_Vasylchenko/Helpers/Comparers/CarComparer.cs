using System.Collections;
using Module_2_Task_6_Vasylchenko.Models;

namespace Module_2_Task_6_Vasylchenko.Helpers.Comparers
{
    public class CarComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as AbstractCar;
            var y = second as AbstractCar;

            if (x.FuelConsumption > y.FuelConsumption)
            {
                return 1;
            }
            else if (x.FuelConsumption < y.FuelConsumption)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
