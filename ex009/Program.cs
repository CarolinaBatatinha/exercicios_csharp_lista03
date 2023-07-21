//  9.	Faça um algoritmo para calcular o cubo e o quadrado de todos os números pertencentes a um intervalo, incluindo o limite superior e inferior.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o limite inferior do intervalo:");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o limite superior do intervalo:");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            "=== Cálculo do cubo e do quadrado no intervalo entre {limiteInferior} e {limiteSuperior} ==="
        );

        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            int quadrado = i * i;
            int cubo = i * i * i;

            Console.WriteLine($"Número: {i}");
            Console.WriteLine($"Quadrado: {quadrado}");
            Console.WriteLine($"Cubo: {cubo}");
            Console.WriteLine("================================");
        }
    }
}
