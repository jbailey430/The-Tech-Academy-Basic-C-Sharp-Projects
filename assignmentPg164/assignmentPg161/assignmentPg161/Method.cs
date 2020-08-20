using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg161
{
    class Method
    {
        public int Addition(int userInput, int Sum)
        {
            Sum = userInput + 12;
            return Sum;
        }
        public int Multiply(int userInput, int Total)
        {
            Total = userInput * 10;
            return Total;
        }
        public int Divide(int userInput, int sumTotal)
        {
            sumTotal = userInput / 2;
            return sumTotal;
        }

    }

}
