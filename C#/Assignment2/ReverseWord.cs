using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class ReverseWord
    {
        public void Run()
        {
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }
    }
}
