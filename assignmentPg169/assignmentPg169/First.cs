using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg169
{
    class First
    {
        public void divide(int x)
        {
            int sum = x / 2;
            
            Console.WriteLine(" {0} / 2 = {1}", x, sum);

            Console.ReadLine();


        }
        public void Para(int x, out int y)
        {
            y = x + 2;
        }
        public void Para(int x)
        {
            int total = x * 10;
            Console.WriteLine(total);
            Console.ReadLine();
        }
        
    }

}
