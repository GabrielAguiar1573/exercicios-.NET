using System;

class Desafio7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Classificar idade entre criança, adolescente, adulto ou idoso");
        Console.WriteLine("Insira sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade <= 0)
        {
            Console.WriteLine("Idade inválida");
        }
        else if (idade > 0 && idade <= 12)
        {
            Console.WriteLine("Você é uma criança");
        }
        else if (idade >= 7 && idade <= 17)
        {
            Console.WriteLine("Você é um adolescente");
        }
        else if (idade >= 18 && idade <= 59)
        {
            Console.WriteLine("Você é um adulto");
        }
        else
        {
            Console.WriteLine("Você é um idoso");
        }
    }
}