//  12.	Faça um algoritmo para calcular a media de n números informados pelo usuário. Para sair do cálculo, o usuário deverá digitar um número negativo.

using System;

class Program
{
    static void Main(string[] args)
    {
        double soma = 0;
        int contador = 0;

        while (true)
        {
            Console.Write("Digite um número (ou um número negativo para sair): ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero < 0)
                break;

            soma += numero;
            contador++;
        }

        if (contador > 0)
        {
            double media = soma / contador;
            Console.WriteLine($"A média dos números é igual a {media}. ");
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }
}
