using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /* ---------------------------------------------------------------
       For the integers 1 through 100 inclusive program should:
       return Fizz for any multiple of 3
       return Buzz for any multiple of 5
       return FizzBuzz for any multiple of 3 & 5
       return the integer that was input if none of the above are true
       1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz
       ---------------------------------------------------------------*/
    public class FizzBuzzGame
    {
        public List<string> GetFizzBuzzResult(List<int> input)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= 0)
                {
                    results.Add("Invalid");
                }
                else if (input[i] % 3 == 0 && input[i] % 5 == 0)
                {
                    results.Add("FizzBuzz");
                }
                else if (input[i] % 3 == 0)
                {
                    results.Add("Fizz");
                }
                else if (input[i] % 5 == 0)
                {
                    results.Add("Buzz");
                }
                else
                {
                    results.Add(input[i].ToString());
                }
            }
            return results;
        }
    }
}
