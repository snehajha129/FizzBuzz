using FizzBuzzSimple.Models;
namespace FizzBuzzSimple.Services;
public interface IFizzBuzzService
{
    FizzBuzzResponse Process(FizzBuzzRequest request);
}
