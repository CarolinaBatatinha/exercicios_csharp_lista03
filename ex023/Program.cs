//23.	Faça um programa que calcule a soma dos números pares e impares a partir de um valor inicial e final informados pelos usuários. Por exemplo, se usuário informou 120 e 130, o programa deverá calculara soma dos números pares : 120 + 122 + 124 + 126 +128 + 130, além dos números impares: 121 + 123 + 125 + 127 + 129.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor inicial: ");
        int valorInicial = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor final: ");
        int valorFinal = int.Parse(Console.ReadLine());

        int somaPares = 0;
        int somaImpares = 0;

        for (int numero = valorInicial; numero <= valorFinal; numero++)
        {
            if (numero % 2 == 0)
            {
                somaPares += numero;
            }
            else
            {
                somaImpares += numero;
            }
        }

        Console.WriteLine($"A soma dos números pares é igual a {somaPares}.");
        Console.WriteLine($"A soma dos números ímpares é igual a {somaImpares}.");
    }
}
