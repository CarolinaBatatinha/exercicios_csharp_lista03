//  18.	Faça um algoritmo para calcular a tabuada de um número informado pelo usuário. O usuário, se a tabuada do 5 for selecionada, deverá visualizar o seguinte resultado: 5 x 1 = 5, ...., 5 x 10 = 50. Por fim, o algoritmo deverá calcular e imprimir a soma de todos os valores resultantes dos cálculos.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int soma = 0;
        Console.WriteLine($"===== TABUADA DE {numero} =====");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            soma += resultado;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        Console.WriteLine($"A soma de todos os valores é igual a {soma}.");
    }
}
