using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            while (true)
            {
                Console.Write("Enter first number (or 'q' to quit): ");
                var firstInput = Console.ReadLine();
                if (firstInput == null || firstInput.Trim().ToLower() == "q")
                    break;
                if (!double.TryParse(firstInput, out double first))
                {
                    Console.WriteLine("Invalid number");
                    continue;
                }

                Console.Write("Enter operator (+, -, *, /): ");
                var op = Console.ReadLine();

                Console.Write("Enter second number: ");
                var secondInput = Console.ReadLine();
                if (!double.TryParse(secondInput, out double second))
                {
                    Console.WriteLine("Invalid number");
                    continue;
                }

                double result = 0;
                bool valid = true;

                switch (op)
                {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = first - second;
                        break;
                    case "*":
                        result = first * second;
                        break;
                    case "/":
                        if (second == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed");
                            valid = false;
                        }
                        else
                        {
                            result = first / second;
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown operator");
                        valid = false;
                        break;
                }

                if (valid)
                {
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
    }
}
