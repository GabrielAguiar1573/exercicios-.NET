using System;

class Desafio5 {
  public static void Main (string[] args) {
    Console.WriteLine ("Média de 3 notas");
    Console.WriteLine ("Digite a primeira nota");
    double nota1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Digite a segunda nota");
    double nota2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Digite a terceira nota");
    double nota3 = Convert.ToDouble(Console.ReadLine());
    double media = (nota1 + nota2 + nota3) / 3;
    
    if(media >= 7){
      Console.WriteLine("Aprovado");
    }else{
      if(media < 5){
        Console.WriteLine("Reprovado");
      }else{
        Console.WriteLine("Recuperação");
      }
    }
    media = double.Round(media, 2);
    Console.WriteLine($"Sua média foi: {media}");
  }
}