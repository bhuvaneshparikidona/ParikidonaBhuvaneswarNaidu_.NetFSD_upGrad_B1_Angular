using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class MultiplicationTable
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(n * i);
            }
        }
    }
}
