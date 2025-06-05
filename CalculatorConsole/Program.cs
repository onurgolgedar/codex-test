using System;

namespace CalculatorConsole
{
    class Program
    {
        static double memory = 0;

        static double GetNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                if (input != null && input.Trim().ToLower() == "m")
                    return memory;
                if (double.TryParse(input, out double value))
                    return value;
                Console.WriteLine("Invalid number");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Special Calculator");
            while (true)
            {
                Console.WriteLine("\nOperations:");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraction");
                Console.WriteLine("3) Multiplication");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Power");
                Console.WriteLine("6) Square Root");
                Console.WriteLine("7) Modulus");
                Console.WriteLine("8) Memory Recall (M)");
                Console.WriteLine("q) Quit");

                Console.Write("Select operation: ");
                var op = Console.ReadLine();
                if (op == null)
                    continue;
                op = op.Trim().ToLower();
                if (op == "q")
                    break;

                double result = 0;
                bool valid = true;

                switch (op)
                {
                    case "1":
                        var add1 = GetNumber("Enter first number: ");
                        var add2 = GetNumber("Enter second number: ");
                        result = add1 + add2;
                        break;
                    case "2":
                        var sub1 = GetNumber("Enter first number: ");
                        var sub2 = GetNumber("Enter second number: ");
                        result = sub1 - sub2;
                        break;
                    case "3":
                        var mul1 = GetNumber("Enter first number: ");
                        var mul2 = GetNumber("Enter second number: ");
                        result = mul1 * mul2;
                        break;
                    case "4":
                        var div1 = GetNumber("Enter first number: ");
                        var div2 = GetNumber("Enter second number: ");
                        if (div2 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed");
                            valid = false;
                        }
                        else
                        {
                            result = div1 / div2;
                        }
                        break;
                    case "5":
                        var powBase = GetNumber("Enter the base: ");
                        var powExp = GetNumber("Enter the exponent: ");
                        result = Math.Pow(powBase, powExp);
                        break;
                    case "6":
                        var sqrtVal = GetNumber("Enter number: ");
                        if (sqrtVal < 0)
                        {
                            Console.WriteLine("Square root of negative number is not allowed");
                            valid = false;
                        }
                        else
                        {
                            result = Math.Sqrt(sqrtVal);
                        }
                        break;
                    case "7":
                        var mod1 = GetNumber("Enter first number: ");
                        var mod2 = GetNumber("Enter second number: ");
                        result = mod1 % mod2;
                        break;
                    case "8":
                        Console.WriteLine($"Memory: {memory}");
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Unknown selection");
                        valid = false;
                        break;
                }

                if (valid)
                {
                    memory = result;
                    Console.WriteLine($"Result: {result} firat maldir");
                }
            }
        }
    }
}
