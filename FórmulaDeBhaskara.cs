/*Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.*/

using System; 

class URI {

    static void Main(string[] args) { 

      string[] valores = Console.ReadLine().Split();
      double A = double.Parse(valores[0]);
      double B = double.Parse(valores[1]);
      double C = double.Parse(valores[2]);
      
      double delta = (B * B) - (4 * A * C);
      
      if(A == 0 || delta < 0)
      {
          Console.WriteLine("Impossivel calcular");
      }
      else
      {
          double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
          double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
          
            Console.WriteLine($"R1 = {x1:F5}");
            Console.WriteLine($"R2 = {x2:F5}");

      }

    }

}