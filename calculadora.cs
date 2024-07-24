using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a operação (+, -, *, /):");
        string op = Console.ReadLine();

        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (op == "+")
        {
            result = num1 + num2;
        }
        else if (op == "-")
        {
            result = num1 - num2;
        }
        else if (op == "*")
        {
            result = num1 * num2;
        }
        else if (op == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            else
            {
                result = num1 / num2;
            }
        }
        else
        {
            Console.WriteLine("Invalid operator.");
        }

        Console.WriteLine("Result: " + result);
    }
}