using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class CountOddEvenNumbers
    {
        public void Run()
        {
            int even = 0;
            int odd = 0;

            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
        }
    }
}
