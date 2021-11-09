using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using Xunit;
namespace FizzBuzzTest
{   
    public class FizzBuzzGameTest
    {
        public FizzBuzzGame fizzBuzzGame;
        [Fact]
        public void GivenMemberOfListDivisibleBy3Fizz()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 1, 2, 3, 4, 6, 7,  9 });
            var expectedResult = new List<string> { "1", "2", "Fizz", "4", "Fizz", "7","Fizz"};
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GivenMemberOfListDivisibleBy5Buzz()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 1, 2, 4, 5, 7,8, 10 });
            var expectedResult = new List<string> { "1", "2", "4", "Buzz", "7", "8", "Buzz" };
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GivenMemberOfListDivisibleBy3FizzBy5BuzzByBothThenFizzBuzz()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            var expectedResult = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16" };
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GivenMemberOfListDivisibleOnlyBy3Fizz()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> {  3, 6, 9 });
            var expectedResult = new List<string> { "Fizz",  "Fizz",  "Fizz" };
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GivenMemberOfListDivisibleOnlyBy5Buzz()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> {  5,  10 });
            var expectedResult = new List<string> {  "Buzz", "Buzz" };
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GivenMemberOfListDivisibleByBothof3and5FizzBuzz()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 15, 30 });
            var expectedResult = new List<string> { "FizzBuzz", "FizzBuzz" };
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GivenMemberOfListDivisibleByNotBothof3and5ShouldbeNumber()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 1, 2, 4, 7, 8 });
            var expectedResult = new List<string> { "1", "2", "4", "7", "8" };
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void GivenMemberOfListDivisibleByNotBothof3and5ShouldbeSameCount()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 1, 2, 4, 7, 8 });
            var expectedResult = new List<string> { "1", "2", "4", "7", "8" };
            Assert.Equal(expectedResult.Count, result.Count);
        }
        [Fact]
        public void GivenMemberOfListDivisibleBy3FizzBy5BuzzByBothThenFizzBuzzShouldbeSameCount()
        {
            fizzBuzzGame = new FizzBuzzGame();
            List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            var expectedResult = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16" };
            Assert.Equal(expectedResult.Count, result.Count);
        }

    }
}
