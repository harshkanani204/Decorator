# Decorator Pattern Example: Coffee Customization

This is a simple C# project that demonstrates the Decorator design pattern using a coffee customization system. In this project, we have created a basic coffee and decorators to add various customizations like milk and sugar to the coffee.

## Project Structure

The project is structured as follows:

- `BlackCoffee.cs`: Represents the basic black coffee class that implements the `ICoffee` interface.
- `CoffeeDecorator.cs`: Defines the abstract `CoffeeDecorator` class that implements the `ICoffee` interface and serves as the base for concrete decorators.
- `ICoffee.cs`: Contains the `ICoffee` interface, which defines the `MakeCoffee` method.
- `MilkDecorator.cs`: Represents the concrete decorator for adding milk to the coffee.
- `SugarDecorator.cs`: Represents the concrete decorator for adding sugar to the coffee.

## Running the Unit Tests

We have included unit tests using Microsoft's MSTest framework to ensure the correct behavior of the coffee customization system. To run the unit tests, follow these steps:

1. Open the solution in Visual Studio.
2. Build the solution to ensure all dependencies are resolved.
3. Open the Test Explorer.
4. Run the unit tests by clicking the "Run All" button in the Test Explorer.

## Usage

You can use this project as a starting point to understand and implement the Decorator design pattern in your own C# applications. To customize coffee with different decorators, follow the example provided in the unit tests.

