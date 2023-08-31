// 25.	Escrever um algoritmo que leia 10 valores, um de cada vez, e conte quantos deles estão no intervalo [10,20] e quantos deles estão fora do intervalo, escrevendo estas informações. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int dentroIntervalo = 0;
        int foraIntervalo = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Digite o {i}º valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor >= 10 && valor <= 20)
            {
                dentroIntervalo++;
            }
            else
            {
                foraIntervalo++;
            }
        }

        Console.WriteLine("Quantidade de valores dentro do intervalo [10, 20]: " + dentroIntervalo);
        Console.WriteLine("Quantidade de valores fora do intervalo: " + foraIntervalo);
    }
}
