using FizzBuzzSimple.Factories;
using FizzBuzzSimple.Models;
using FizzBuzzSimple.Services;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzServiceTests
{
    private readonly FizzBuzzService _service;

    public FizzBuzzServiceTests()
    {
        var factory = new FizzBuzzRuleFactory();
        _service = new FizzBuzzService(factory);
    }

    [Fact]
    public void ReturnFizzWhenNumber_Divisible_By_3()
    {
        var request = new FizzBuzzRequest
        {
            Values = new() { "3" }
        };

        var result = _service.Process(request);

        result.Results.Should().ContainSingle();
        result.Results.Should().Contain("Fizz");
    }

    [Fact]
    public void ReturnBuzzWhenNumber_Divisible_By_5()
    {
        var request = new FizzBuzzRequest
        {
            Values = new() { "5" }
        };

        var result = _service.Process(request);

        result.Results.Should().ContainSingle();
        result.Results.Should().Contain("Buzz");
    }

    [Fact]
    public void ReturnFizzBuzzWhenNumber_Divisible_By_15()
    {
        var request = new FizzBuzzRequest
        {
            Values = new() { "15" }
        };

        var result = _service.Process(request);

        result.Results.Should().ContainSingle();
        result.Results.Should().Contain("FizzBuzz");
    }

    [Fact]
    public void ReturnInvalidItemFor_String()
    {
        var request = new FizzBuzzRequest
        {
            Values = new() { "ABC" }
        };

        var result = _service.Process(request);

        result.Results.Should().ContainSingle();
        result.Results.Should().Contain("Invalid Item");
    }

    [Fact]
    public void ReturnInvalidItemForEmpty_String()
    {
        var request = new FizzBuzzRequest
        {
            Values = new() { "" }
        };

        var result = _service.Process(request);

        result.Results.Should().ContainSingle();
        result.Results.Should().Contain("Invalid Item");
    }

    [Fact]
    public void ReturnInvalidItem_For_Null()
    {
        var request = new FizzBuzzRequest
        {
            Values = new() { null! }
        };

        var result = _service.Process(request);

        result.Results.Should().ContainSingle();
        result.Results.Should().Contain("Invalid Item");
    }

    [Fact]
    public void ReturnDividedMessagesForNonFizzBuzzNumber()
    {
        var request = new FizzBuzzRequest
        {
            Values = new() { "23" }
        };

        var result = _service.Process(request);

        result.Results.Should().HaveCount(2);

        result.Results.Should().Contain(
            "Divided 23 by 3");

        result.Results.Should().Contain(
            "Divided 23 by 5");
    }

    [Fact]
    public void ProcessMultipleItemsCorrectly()
    {
        var request = new FizzBuzzRequest
        {
            Values = new()
            {
                "3",
                "5",
                "15",
                "ABC",
                "23"
            }
        };

        var result = _service.Process(request);

        result.Results.Should().Contain("Fizz");
        result.Results.Should().Contain("Buzz");
        result.Results.Should().Contain("FizzBuzz");
        result.Results.Should().Contain("Invalid Item");
        result.Results.Should().Contain("Divided 23 by 3");
        result.Results.Should().Contain("Divided 23 by 5");
    }
}