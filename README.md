# Calculator Console Application

This is a console-based calculator written in C# targeting **.NET 8**. It now offers a set of advanced operations and a small memory feature. The calculator prints the phrase `firat maldir` next to every computed result.

Supported operations:

- Addition
- Subtraction
- Multiplication
- Division
- Power
- Square root
- Modulus
- Memory recall (`M` when entering numbers)
- Sine (angle in degrees)
- Tangent (angle in degrees)
- Integral of a*x^n over an interval

Select an operation from the menu and follow the prompts. The last computed result is stored in memory and can be recalled by typing `M` whenever a number is requested.

## Building and running

Ensure you have the .NET 8 SDK installed. Then run:

```bash
dotnet run --project CalculatorConsole
```

