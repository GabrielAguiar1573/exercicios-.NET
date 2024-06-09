using System;

class Desafio9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Classificar a categoria de um produto");
        Console.WriteLine("Digite o código do produto");
        int codProduto = Convert.ToInt32(Console.ReadKey());
        if (codProduto >= 1 && codProduto <= 10) 
        {
            Console.WriteLine("Alimento não perecíve");
        }
        if (codProduto >= 11 && codProduto <= 20)
        {
            Console.WriteLine("Alimento perecível");
        }
        if (codProduto >= 21 && codProduto <= 30)
        {
            Console.WriteLine("Vestuário");
        }
        if (codProduto >= 31 && codProduto <= 40)
        {
            Console.WriteLine("Eletrônicos");
        }
        else
        {
            Console.WriteLine("Código inválido");
        }
    }
}