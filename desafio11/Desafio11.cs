using System;

class Desafio11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Verificar se um número está no intervalo de 10 e 20");
        Console.WriteLine("Digite um número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero >= 10 && numero <= 20) 
        { 
            Console.WriteLine($"{numero} está no intervalo de 10 a 20");
        }
        else
        {
            Console.WriteLine($"{numero} não está no intervalo de 10 a 20");
        }
    }
}