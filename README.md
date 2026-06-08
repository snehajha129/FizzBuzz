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

Option 1: Run Using Visual Studio
Prerequisites
Visual Studio 2022 or later
.NET 8 SDK

Steps

Open FizzBuzzSample.sln
Restore NuGet packages if prompted.
Set FizzBuzzSimple as the Startup Project.
Build the solution.
Press F5 or click Run.
Swagger UI will open automatically.
Option 2: Run Using Command Prompt
Prerequisites

Install .NET 8 SDK.

Verify installation:

dotnet --version

Navigate to the API project folder:

cd FizzBuzzSimple

Restore packages:

dotnet restore

Build the application:

dotnet build

Run the application:

dotnet run

The application will start and display the URL in the console.

Example:

https://localhost:5001

Open:

https://localhost:5001/swagger

to access Swagger UI.

Option 3: Run Using Visual Studio Code
Prerequisites
Visual Studio Code
.NET 8 SDK
C# Extension
Steps

Open the solution folder in VS Code.

Open Terminal and execute:

cd FizzBuzzSimple

dotnet restore

dotnet build

dotnet run

Open the Swagger URL displayed in the terminal.

Running Unit Tests

Navigate to the solution folder:

cd FizzBuzzSample

Run:

dotnet test

Expected Result:

Passed: 8
Failed: 0
Skipped: 0

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
