using System;

class Subtracao
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        int valor2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A subtração dos dois valores é: " + (valor1 - valor2));
    }
}