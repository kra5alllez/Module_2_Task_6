using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_6_Vasylchenko.Models;

namespace Module_2_Task_6_Vasylchenko.Helpers.Comparers
{
    public class CarComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as AbstractCar;
            var y = second as AbstractCar;

            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
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
