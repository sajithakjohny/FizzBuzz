using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For the integers 1 through 100 inclusive program should:");
            Console.WriteLine("return Fizz for any multiple of 3");
            Console.WriteLine("return Buzz for any multiple of 5");
            Console.WriteLine("return FizzBuzz for any multiple of 3 & 5");
            Console.WriteLine("return the integer that was input if none of the above are true ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter Numbers (Example 1, 2,3)");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Console.WriteLine("You have entered" + "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 ");
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            List<string> result =  fizzBuzzGame.GetFizzBuzzResult(numbers);
            Console.WriteLine("Your Game Result is ");
        }
    }
}
