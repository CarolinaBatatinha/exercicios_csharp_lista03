// 15.	Faça um algoritmo para imprimir a quantidade de números ímpares entre um intervalo especificado pelo usuário.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número do intervalo: ");
        int numInicial = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o último número do intervalo: ");
        int numFinal = Convert.ToInt32(Console.ReadLine());
        int contImpares = 0;

        for (int i = numInicial; i <= numFinal; i++)
        {
            if (i % 2 != 0)
            {
                contImpares++;
            }
        }

        Console.WriteLine(
            $"Dentro do intervalo entre {numInicial} e {numFinal} existem {contImpares} números ímpares."
        );
    }
}
