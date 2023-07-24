//16.	Elabore um algoritmo para ler os números N e P, e calcule a exponenciação de NP.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor de N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o valor de P: ");
        int P = Convert.ToInt32(Console.ReadLine());

        double resultado = Math.Pow(N, P);

        Console.WriteLine($"O resultado de {N} elevado a {P} é igual a {resultado}.");
    }
}
