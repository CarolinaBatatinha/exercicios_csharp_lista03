//  11.	Faça um algoritmo para ler 100 números, calcular a soma dos números, a média e o maior e menor número encontrados.

using System;

class Program
{
    static void Main(string[] args)
    {
        double soma = 0;
        double maior = double.MinValue; // inicializa com o menor valor possível
        double menor = double.MaxValue; // inicializa com o maior valor possível

        for (int i = 0; i < 100; i++)
        {
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            soma += numero;

            if (numero > maior)
                maior = numero;

            if (numero < menor)
                menor = numero;
        }

        double media = soma / 100;

        Console.WriteLine($"A soma dos números é igual a {soma}. ");
        Console.WriteLine($"A média dos números é {media}.");
        Console.WriteLine($"O menor número digitado é {menor}.");
        Console.WriteLine($"O maior número digitado é {maior}.");
    }
}
