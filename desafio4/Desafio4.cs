using System;

class Desafio4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Área do triângulo");
        Console.WriteLine("Digite o tamanho do primeiro lado do triângulo");
        int ladoA = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tamanho do segundo lado");
        int ladoB = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tamanho do terceiro lado");
        int ladoC = int.Parse(Console.ReadLine());
        if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))
        {
            Console.WriteLine("É um triângulo");
        }
        else
        {
            Console.WriteLine("Não é um triângulo");
        }
    }
}