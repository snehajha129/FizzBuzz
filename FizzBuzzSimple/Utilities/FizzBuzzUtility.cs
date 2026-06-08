using FizzBuzzSimple.Constants;

namespace FizzBuzzSimple.Utilities
{
    public class FizzBuzzUtility
    {
        public static string? GetFizzBuzzResult(int number)
        {
            if (number % FizzBuzzConstants.FizzBuzzNumber == 0)
                return FizzBuzzConstants.FizzBuzz;

            if (number % FizzBuzzConstants.FizzNumber == 0)
                return FizzBuzzConstants.Fizz;

            if (number % FizzBuzzConstants.BuzzNumber == 0)
                return FizzBuzzConstants.Buzz;

            return null;
        }
    }
}
