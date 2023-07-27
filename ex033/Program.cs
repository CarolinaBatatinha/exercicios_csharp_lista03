// 33.	Faça um algoritmo para ler um número até que o usuário deseja terminar a entrada dos dados e, receber as seguintes informações: a média dos números, o maior e o menor número.

using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int soma = 0;
        int contador = 0;
        int maior = int.MinValue;
        int menor = int.MaxValue;

        do
        {
            Console.Write("Digite um número (ou digite 0 para encerrar o programa): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                soma += numero;
                contador++;

                if (numero > maior)
                    maior = numero;

                if (numero < menor)
                    menor = numero;
            }
        } while (numero != 0);

        if (contador > 0)
        {
            double media = (double)soma / contador;
            Console.WriteLine("===================================");
            Console.WriteLine("Média dos números: " + media);
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);
        }
        else
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }
}
