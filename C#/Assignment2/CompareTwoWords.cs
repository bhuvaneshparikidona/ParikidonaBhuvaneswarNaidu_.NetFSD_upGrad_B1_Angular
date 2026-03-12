using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class CompareTwoWords
    {
        public void Run()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (a == b)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not Same");
        }
    }
}
