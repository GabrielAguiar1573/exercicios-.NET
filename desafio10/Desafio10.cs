using System;

class Desafio10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Operação com dois números");
        Console.WriteLine("Digite o primeiro número");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escolha a operação: ( + , - , * , /)");
        string? operacao = (Console.ReadLine());

        if (operacao == "+")
        {
            double soma = numero1 + numero2;
            Console.WriteLine($"A soma dos dois números é {soma}");
        }
        else if (operacao == "-")
        {
            double subtracao = numero1 - numero2;
            Console.WriteLine($"A subtração dos dois números é {subtracao}");
        }
        else if (operacao == "*")
        {
            double multiplicacao = numero1 * numero2;
            Console.WriteLine($"A multiplicação dos dois números é {multiplicacao}");
        }
        else if (operacao == "/")
        {
            double divisao = numero1 / numero2;
            Console.WriteLine($"A divisão dos dois números é {divisao}");
        }
        else
        {
            Console.WriteLine("");
        }
    }
}