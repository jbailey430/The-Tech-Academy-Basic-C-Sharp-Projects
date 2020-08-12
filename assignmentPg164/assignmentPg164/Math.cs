using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg164
{
    class Math
    {
        public int plus(int x)
        {
            int result = x + 5;
            return result;
        }
        public int multiply(decimal x)
        {
            int convertX = Convert.ToInt32(x);
            int times = convertX * 4;
            return times;
        }
        public int divide(int x)
        {
            int total = x / 2;
            return total;
        }
    }
}
