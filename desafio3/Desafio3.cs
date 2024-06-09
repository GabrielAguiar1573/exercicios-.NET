using System;

class Desafio3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Maior valor");
        Console.WriteLine("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());
        if (valor1 == valor2)
        {
            Console.WriteLine("Os valores são iguais");
        }
        else
        {
            if (valor1 > valor2)
            {
                Console.WriteLine($"{valor1} é maior");
            }
            else
            {
                Console.WriteLine($"{valor2} é maior");
            }
        }
    }
}