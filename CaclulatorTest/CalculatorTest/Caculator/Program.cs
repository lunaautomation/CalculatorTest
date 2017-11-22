using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    public class Calculator
    {
        public int Calc(string inward)
        {
            int returned = 0;
            if (inward == null)
            {
                return returned;
            }
            var array = inward.Split(',');
            foreach (var number in array)
            {
                returned = returned + int.Parse(number);
            }
            if (returned == 0)
            {
                return returned;
            }
            return returned;
        }
    }
}
