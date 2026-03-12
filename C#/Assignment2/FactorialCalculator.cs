using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class FactorialCalculator
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
