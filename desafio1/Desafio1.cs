using System;

class Desafio1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Par ou ímpar");
        Console.WriteLine("Digite um valor");
        int valor = Convert.ToInt32(Console.ReadLine());
        if (valor == 0)
        {
            Console.WriteLine("O valor é zero");
        }
        else
        {
            //int resultado = valor % 2; 
            if (valor % 2 == 1)
            {
                Console.WriteLine("O número é ímpar");
            }
            else
            {
                Console.WriteLine("O número é par");
            }
        }
    }
}