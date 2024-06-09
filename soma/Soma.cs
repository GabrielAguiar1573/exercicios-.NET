using System;

class Soma
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite o primeiro valor");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        int soma = valor1 + valor2;
        Console.WriteLine("A soma dos dois valores é: " + soma);
    }
}