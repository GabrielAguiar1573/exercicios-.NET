using System;

class Desafio2
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Positivo ou negativo");
    Console.WriteLine("Digite um número");
    int valor = int.Parse(Console.ReadLine());
    if (valor == 0)
    {
      Console.WriteLine("O número é zero");
    }
    else
    {
      if (valor < 0)
      {
        Console.WriteLine("O número é negativo");
      }
      else
      {
        Console.WriteLine("O número é positivo");
      }
    }
  }
}