//40.	Um Frigorífico possui 500 bois, e deseja saber o número de boi que possui o peso mais gordo e do boi que possui o peso mais magro e média de pesos dos bois. Cada boi possui um número de identificação. Faça o mesmo programa utilizando while, for e do...while. Observação: se houver dois bois ou mais bois com o peso maior ou menor peso, o programa deverá informar o usuário no final da execução.

//Usando "while"

using System;

class Program
{
    static void Main(string[] args)
    {
        int totalBois = 500;
        int cont = 1;
        int boiMaisGordo = 0;
        int boiMaisMagro = 0;
        double pesoMaisGordo = 0;
        double pesoMaisMagro = 0;
        double somaPesos = 0;

        Console.WriteLine("Informe o peso de cada boi:");

        while (cont <= totalBois)
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

            cont++;
        }

        double mediaPesos = somaPesos / totalBois;

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Boi mais gordo: {boiMaisGordo} (Peso: {pesoMaisGordo}kg)");
        Console.WriteLine($"Boi mais magro: {boiMaisMagro}/ (Peso: {pesoMaisMagro}kg)");
        Console.WriteLine($"Média de pesos dos bois: {mediaPesos}kg");
    }
}
