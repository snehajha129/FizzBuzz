# FizzBuzz API- Assignment- 

## Overview

Project implements the FizzBuzz exercise as an ASP.NET Core Web API.

The API accepts an array of values and returns:

* Fizz when divisible by 3
* Buzz when divisible by 5
* FizzBuzz when divisible by both 3 and 5
* Invalid Item for invalid inputs
* Division messages for non-divisible numbers

## Technologies

* ASP.NET Core Web API (.NET 8)
* Swagger/OpenAPI
* Dependency Injection
* Factory Pattern
* xUnit
* FluentAssertions

## Design Principles

* Single Responsibility Principle (SRP)
* SOLID Principles
* Dependency Injection
* Separation of Concerns

## Running the Application

1. Open the solution in Visual Studio.
2. Build the solution.
3. Run the API.
4. Open Swagger.

Example:

[https://localhost:{port}/swagger](https://localhost:{port}/swagger)

## Sample Request

{
"values": [
"1",
"3",
"5",
"",
"15",
"A",
"23"
]
}

## Sample Response

{
"results": [
"Divided 1 by 3",
"Divided 1 by 5",
"Fizz",
"Buzz",
"Invalid Item",
"FizzBuzz",
"Invalid Item",
"Divided 23 by 3",
"Divided 23 by 5"
]
}

## Unit Tests

The solution includes xUnit test cases covering:

* Fizz
* Buzz
* FizzBuzz
* Invalid input
* Empty input
* Null input
* Non-divisible numbers
* Multiple input scenarios
