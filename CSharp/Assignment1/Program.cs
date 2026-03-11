using System;

namespace Assignment1
{
    internal class Exercise1
    {
        public static void DisplayQuotient()
        {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int quotient = num1 / num2;

            Console.WriteLine("Quotient is: " + quotient);
        }
    }

    internal class Exercise2 { 
        public static void KmToMeters()
        {
            Console.WriteLine("Enter KM");
            int kms = Convert.ToInt32(Console.ReadLine());
            int meters = kms * 1000;
            Console.WriteLine("Distance in meters");
            Console.WriteLine(meters);
        }
    }

    internal class Exercise3
    {
        public static void DisplaySumAndAverage()
        {
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num4");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num5");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5;

            Console.WriteLine("Sum is:" + sum);
            Console.WriteLine("Average is: "+ sum/5);
        }
    }


    internal class Excercise4
    {
        public static void evenOrOdd()
        {
            Console.Write("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }


    internal class Exercise5
    {
        public static void HighestNumber()
        {
            Console.Write("Enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is highest");
            }
            else
            {
                Console.WriteLine(num2 + " is highest");
            }
        }
    }

    internal class Exercise6
    {
        public static void AreaofRectangleAndSquare()
        {
            Console.Write("Enter length of rectangle ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth of rectangle ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            double rectangleArea = length * breadth;

            Console.WriteLine("Area of Rectangle " + rectangleArea);

            Console.Write("Enter side of square ");
            double side = Convert.ToDouble(Console.ReadLine());

            double squareArea = side * side;

            Console.WriteLine("Area of Square " + squareArea);
        }
    }


    internal class Exercise7
    {
        public static void TimeTakenForJourney()
        {
            Console.Write("Enter distance ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter speed ");
            double speed = Convert.ToDouble(Console.ReadLine());

            double time = distance / speed;

            Console.WriteLine("Time taken " + time);
        }
    }

    internal class Exercise8
    {
        public static void VowelOrConstant()
        {
            Console.Write("Enter a string ");
            string str = Console.ReadLine();

            char ch = str[2];

            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("Third character is Vowel");
            }
            else
            {
                Console.WriteLine("Third character is Consonant");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise1.DisplayQuotient();
            Exercise2.KmToMeters();
            Exercise3.DisplaySumAndAverage();
            Excercise4.evenOrOdd();
            Exercise5.HighestNumber();
            Exercise6.AreaofRectangleAndSquare();
            Exercise7.TimeTakenForJourney();
            Exercise8.VowelOrConstant();

        }
    }
}