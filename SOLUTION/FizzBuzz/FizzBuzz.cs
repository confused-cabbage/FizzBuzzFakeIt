
namespace FizzBuzz
{
    public class FizzBuzzPlayer
    {
        private ILogger logger;

        public FizzBuzzPlayer(ILogger logger)
        {
            this.logger = logger;
        }

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
            logger.Log($"FizzBuzz played {input}, got '{FizzBuzzHolder}' as a result.");
            return FizzBuzzHolder;
        }
    }
}
