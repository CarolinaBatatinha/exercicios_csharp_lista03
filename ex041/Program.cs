//41.	Repita o exercício anterior para um número indefinido de bois.

using System;

class Program
{
    static void Main(string[] args)
    {
        int cont = 1;
        int boiMaisGordo = 0;
        int boiMaisMagro = 0;
        double pesoMaisGordo = 0;
        double pesoMaisMagro = 0;
        double somaPesos = 0;
        int quantidadeBois = 0;
        double peso = 0;
        Console.WriteLine("Informe o peso de cada boi (digite um valor negativo para encerrar):");

        while (true)
        {
            Console.Write("Peso do boi {0}: ", cont);
            peso = double.Parse(Console.ReadLine());

            if (peso < 0)
            {
                break;
            }

            quantidadeBois++;
            somaPesos += peso;

            if (quantidadeBois == 1 || peso > pesoMaisGordo)
            {
                boiMaisGordo = cont;
                pesoMaisGordo = peso;
            }

            if (quantidadeBois == 1 || peso < pesoMaisMagro)
            {
                boiMaisMagro = cont;
                pesoMaisMagro = peso;
            }

            cont++;
        }

        double mediaPesos = somaPesos / quantidadeBois;

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Boi mais gordo: {boiMaisGordo} (Peso: {pesoMaisGordo}kg)");
        Console.WriteLine($"Boi mais magro: {boiMaisMagro} (Peso: {pesoMaisMagro}kg)");
        Console.WriteLine($"Média de pesos dos bois: {mediaPesos:F1}kg");

        Console.WriteLine("---------------------------");
        if (pesoMaisGordo == pesoMaisMagro)
        {
            Console.WriteLine("Há dois ou mais bois com o mesmo peso mais gordo e mais magro.");
        }
    }
}
