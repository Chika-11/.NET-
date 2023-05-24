using System;

namespace ConsoleApp1
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("Division by zero is not allowed");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator:");
            string op = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            try
            {
                switch (op)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        Console.WriteLine("The result is: " + result);
                        break;

                    case "-":
                        result = calculator.Subtract(num1, num2);
                        Console.WriteLine("The result is: " + result);
                        break;

                    case "*":
                        result = calculator.Multiply(num1, num2);
                        Console.WriteLine("The result is: " + result);
                        break;

                    case "/":
                        result = calculator.Divide(num1, num2);
                        Console.WriteLine("The result is: " + result);
                        break;

                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
