using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class NumbersDivisibleBySeven
    {
        public void Run()
        {
            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
