using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class FahrenheitToCelsius
    {
        public void Run()
        {
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine(c);
        }
    }
}
