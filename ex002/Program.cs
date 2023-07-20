// 2.	Faça um algoritmo para imprimir o nome da disciplina e um “beep” um número de vezes determinado pelo usuário.

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Informe o nome da disciplina: ");
        string disciplina = Console.ReadLine();

        Console.Write("Informe o número de beeps: ");
        int numeroBeeps = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numeroBeeps; i++)
        {
            Console.WriteLine(disciplina);
            Console.Beep();
        }
    }
}
