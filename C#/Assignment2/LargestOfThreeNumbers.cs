using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class LargestOfThreeNumbers
    {
        public void Run()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            Console.WriteLine(max);
        }
    }
}
