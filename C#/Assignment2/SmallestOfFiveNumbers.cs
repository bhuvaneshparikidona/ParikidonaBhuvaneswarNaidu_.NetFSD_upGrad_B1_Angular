using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class SmallestOfFiveNumbers
    {
        public void Run()
        {
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < min)
                    min = n;
            }

            Console.WriteLine(min);
        }
    }
}
