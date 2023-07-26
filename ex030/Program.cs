// 30.	Crie uma algoritmo para imprimir todas as tabuadas do 1 até o 10.

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
            Console.WriteLine($"Tabuada de {multiplicador}: ");

            for (int multiplicando = 1; multiplicando <= 10; multiplicando++)
            {
                int resultado = multiplicador * multiplicando;
                Console.WriteLine($"{multiplicador} x {multiplicando} = {resultado}");
            }

            Console.WriteLine();
        }
    }
}
