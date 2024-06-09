using System;

class Multiplicacao
{
    public static void Main(string[]args){
        Console.WriteLine("Multiplicação");
        Console.WriteLine("Digite o primeiro valor");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        int valor2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A multiplicação dos dois valores é: " + (valor1 * valor2));
    }
}