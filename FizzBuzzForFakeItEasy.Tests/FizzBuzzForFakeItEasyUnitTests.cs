using Xunit;

namespace FizzBuzzForFakeItEasy.Tests
{
    public class FizzBuzzForFakeItEasyUnitTests
    {
        [Fact]
        public void GivenOne_ReturnsOne()
        {
            int input = 1;
            Assert.Equal("1", Run(input));
        }


        [Fact]
        public void GivenTwo_ReturnsOneandTwo()
        {
            int input = 2;
            Assert.Equal("1 2", Run(input));
        }

        [Fact]
        public void GivenThree_ReturnsNumbersAndFizz()
        {
            int input = 3;
            Assert.Equal("1 2 Fizz", Run(input));
        }

        [Fact]
        public void GivenFour_ReturnsNumbersAndFour()
        {
            int input = 4;
            Assert.Equal("1 2 Fizz 4", Run(input));
        }

        [Fact]
        public void GivenFive_ReturnsNumbersAndBuzz()
        {
            int input = 5;
            Assert.Equal("1 2 Fizz 4 Buzz", Run(input));
        }

        [Fact]
        public void GivenFifteen_ReturnsNumbersAndFizzBuzz()
        {
            int input = 15;
            Assert.Equal("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz", Run(input));
        }

        [Fact]
        public void GivenNegativeNumber_ReturnsError()
        {
            int input = -2;
            Assert.Equal("Error - Does not accept negative numbers.", Run(input));
        }

        [Fact]
        public void GivenZero_ReturnsError()
        {
            int input = 0;
            Assert.Equal("Error - Does not accept zero.", Run(input));
        }

        private string Run(int input)
        { 
            return new FizzBuzzPlayer().FizzBuzzRun(input);
        }
    }
}
