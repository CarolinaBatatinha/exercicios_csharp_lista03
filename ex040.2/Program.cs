// Usando o "for"

using System;

class Program
{
    static void Main(string[] args)
    {
        int totalBois = 500;
        int boiMaisGordo = 0;
        int boiMaisMagro = 0;
        double pesoMaisGordo = 0;
        double pesoMaisMagro = 0;
        double somaPesos = 0;

        Console.WriteLine("Informe o peso de cada boi:");

        for (int cont = 1; cont <= totalBois; cont++)
        {
            Console.Write($"Peso do boi {cont}: ");
            double peso = double.Parse(Console.ReadLine());

            somaPesos += peso;

            if (peso > pesoMaisGordo)
            {
                boiMaisGordo = cont;
                pesoMaisGordo = peso;
            }

            if (cont == 1 || peso < pesoMaisMagro)
            {
                boiMaisMagro = cont;
                pesoMaisMagro = peso;
            }
        }

        double mediaPesos = somaPesos / totalBois;

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Boi mais gordo: {boiMaisGordo} (Peso: {pesoMaisGordo}kg)");
        Console.WriteLine($"Boi mais magro: {boiMaisMagro} (Peso: {pesoMaisMagro}kg)");
        Console.WriteLine($"Média de pesos dos bois: {mediaPesos}kg");
    }
}
