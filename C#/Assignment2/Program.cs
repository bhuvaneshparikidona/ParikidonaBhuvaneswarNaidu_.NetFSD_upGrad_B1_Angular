using System;
using System.Linq;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage welcomeMessage = new WelcomeMessage();
            welcomeMessage.Run();

            OddEvenCheck oddEvenCheck = new OddEvenCheck();
            oddEvenCheck.Run();

            CountOddEvenNumbers countOddEvenNumbers = new CountOddEvenNumbers();
            countOddEvenNumbers.Run();

            FahrenheitToCelsius fahrenheitToCelsius = new FahrenheitToCelsius();
            fahrenheitToCelsius.Run();

            ShopkeeperSalesCalculator shopkeeperSalesCalculator = new ShopkeeperSalesCalculator();
            shopkeeperSalesCalculator.Run();

            SquareSeries squareSeries = new SquareSeries();
            squareSeries.Run();

            FactorialCalculator factorialCalculator = new FactorialCalculator();
            factorialCalculator.Run();

            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.Run();

            MultiplicationTable multiplicationTable = new MultiplicationTable();
            multiplicationTable.Run();

            NumbersDivisibleBySeven numbersDivisibleBySeven = new NumbersDivisibleBySeven();
            numbersDivisibleBySeven.Run();

            LargestOfThreeNumbers largestOfThreeNumbers = new LargestOfThreeNumbers();
            largestOfThreeNumbers.Run();

            SmallestOfFiveNumbers smallestOfFiveNumbers = new SmallestOfFiveNumbers();
            smallestOfFiveNumbers.Run();

            WordLength wordLength = new WordLength();
            wordLength.Run();

            ReverseWord reverseWord = new ReverseWord();
            reverseWord.Run();

            CompareTwoWords compareTwoWords = new CompareTwoWords();
            compareTwoWords.Run();

            PalindromeCheck palindromeCheck = new PalindromeCheck();
            palindromeCheck.Run();
        }
    }
}