using System;

namespace FizzBuzzForFakeItEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class FizzBuzzPlayer
    {
        public string FizzBuzzRun(int input)
        {
            if (input < 0)
                return "Error - Does not accept negative numbers.";
            else if (input == 0)
                return "Error - Does not accept zero.";
            string FizzBuzzHolder = "";
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0)
                {
                    FizzBuzzHolder += "Fizz";
                }
                if (i % 5 == 0)
                {
                    FizzBuzzHolder += "Buzz";
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    FizzBuzzHolder += i.ToString();
                }
                if (i != input)
                {
                    FizzBuzzHolder += " ";
                }
            }

            return FizzBuzzHolder;
        }
    }
}
