using FizzBuzzSimple.Utilities;

namespace FizzBuzzSimple.Factories;
public class FizzBuzzRuleFactory : IFizzBuzzRuleFactory
{
    public string? GetResult(int number)
    {
        return FizzBuzzUtility.GetFizzBuzzResult(number);
    }
}
