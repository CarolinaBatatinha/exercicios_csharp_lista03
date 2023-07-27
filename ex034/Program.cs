//34.	Repita o exercício anterior para um total de 1000 pessoas do sexo masculino, ou seja, o algoritmo só irá fazer a computação dos valores se a pessoa for do sexo masculino. No final do exercício, imprima também quantas pessoas não são do sexo masculino.

using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int soma = 0;
        int contador = 0;
        int maior = int.MinValue;
        int menor = int.MaxValue;
        int naoMasculino = 0;

        do
        {
            Console.Write("Digite o sexo da pessoa (1 - Masculino, 2 - Feminino): ");
            int sexo = int.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                soma += numero;
                contador++;

                if (numero > maior)
                    maior = numero;

                if (numero < menor)
                    menor = numero;
            }
            else
            {
                naoMasculino++;
            }

            Console.Write("Deseja inserir os dados de outra pessoa? (s/n): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
                break;
        } while (true);

        if (contador > 0)
        {
            double media = (double)soma / contador;

            Console.WriteLine("Média dos números dos homens: " + media);
            Console.WriteLine("Maior número dos homens: " + maior);
            Console.WriteLine("Menor número dos homens: " + menor);
        }
        else
        {
            Console.WriteLine("Nenhum homem foi registrado.");
        }

        Console.WriteLine("Número de pessoas não do sexo masculino: " + naoMasculino);
    }
}
