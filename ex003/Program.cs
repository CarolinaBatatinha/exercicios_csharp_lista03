// 3.	Faça um algoritmo para imprimir a soma dos números entre um intervalo determinado pelo usuário, incluindo os limites inferiores e superiores.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o limite inferior do intervalo:");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o limite superior do intervalo:");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        int soma = 0;

        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            soma += i;
        }

        Console.WriteLine(
            $"A soma de todos os números entre {limiteInferior} e {limiteSuperior} é igual a {soma}."
        );
    }
}
