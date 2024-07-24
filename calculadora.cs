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

        double resultado = 0;

        if (op == "+")
        {
            resultado = num1 + num2;
        }
        else if (op == "-")
        {
            resultado = num1 - num2;
        }
        else if (op == "*")
        {
            resultado = num1 * num2;
        }
        else if (op == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Erro, não pode ser dividido por 0.");
            }
            else
            {
                resultado = num1 / num2;
            }
        }
        else
        {
            Console.WriteLine("Operação invalida.");
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}
