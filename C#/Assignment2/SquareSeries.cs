using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class SquareSeries
    {
        public void Run()
        {
            for (int i = 0; i * i <= 625; i++)
            {
                Console.Write((i * i) + " ");
            }
        }
    }
}
