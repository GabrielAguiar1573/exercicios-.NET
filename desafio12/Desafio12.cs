using System;

class Desafio12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Verificar se o número é maior que 100, se não, retornar o dobro dele");
        Console.WriteLine("Digite um número");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 100 )
        {
            Console.WriteLine("O número " + numero + " é maior que 100");
        }
        else
        {
            Console.WriteLine("O dobro de " + numero + " é: " + (numero + numero));
        }
    }
}