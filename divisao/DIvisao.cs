using System;

class Divisao
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        double valor2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A divisão dos dois valores é: " + (valor1 / valor2));
    }
}