using FizzBuzzSimple.Factories;
using FizzBuzzSimple.Models;

namespace FizzBuzzSimple.Services;

public class FizzBuzzService : IFizzBuzzService
{
    private readonly IFizzBuzzRuleFactory _factory;
    public FizzBuzzService(IFizzBuzzRuleFactory factory) => _factory = factory;

    public FizzBuzzResponse Process(FizzBuzzRequest request)
    {
        var response = new FizzBuzzResponse();

        foreach (var item in request.Values)
        {
            if (string.IsNullOrWhiteSpace(item) || !int.TryParse(item, out int number))
            {
                response.Results.Add("Invalid Item");
                continue;
            }

            var result = _factory.GetResult(number);

            if (result != null)
                response.Results.Add(result);
            else
            {
                response.Results.Add($"Divided {number} by 3");
                response.Results.Add($"Divided {number} by 5");
            }
        }

        return response;
    }
}
