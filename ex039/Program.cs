// 39.	Para eleição de representantes de classe de uma universidade há três candidatos. Os votos são informados através de código: 1, 2 ou 3, voto para os respectivos candidatos, 5 voto nulo e 6 voto em branco. Faça um algoritmo que calcule e escreva:
// a.	A porcentagem e o total de votos para cada candidato
// b.	Total de votos nulos
// c.	Total de votos em branco
// d.	Percentual de votos em brancos e nulos
// e.	Classificação dos candidatos
// f.	Total de votos

using System;

class Program
{
    static void Main(string[] args)
    {
        int candidato1 = 0;
        int candidato2 = 0;
        int candidato3 = 0;
        int votosNulos = 0;
        int votosBrancos = 0;
        int totalVotos = 0;
        int voto;

        do
        {
            Console.WriteLine("Informe seu voto:\n1, 2 ou 3 para os candidatos \n5 para voto nulo \n6 para voto em branco\n0 para encerrar o programa");
            voto = Convert.ToInt32(Console.ReadLine());
            switch (voto)
            {
                case 1:
                    candidato1++;
                    totalVotos++;
                    break;
                case 2:
                    candidato2++;
                    totalVotos++;
                    break;
                case 3:
                    candidato3++;
                    totalVotos++;
                    break;
                case 5:
                    votosNulos++;
                    totalVotos++;
                    break;
                case 6:
                    votosBrancos++;
                    totalVotos++;
                    break;
                default:
                    Console.WriteLine("Voto inválido. Tente novamente.");
                    break;
            }
        } while (voto != 0);
        
        Console.WriteLine("");
        Console.WriteLine("RESULTADO DAS ELEIÇÕES");
        Console.WriteLine("");

        double percentualCandidato1 = (double)candidato1 / totalVotos * 100;
        double percentualCandidato2 = (double)candidato2 / totalVotos * 100;
        double percentualCandidato3 = (double)candidato3 / totalVotos * 100;

        Console.WriteLine("------------------------------------");
        Console.WriteLine("\nCandidato 1: {0} votos ({1}% do total)", candidato1, percentualCandidato1.ToString("F2"));
        Console.WriteLine("Candidato 2: {0} votos ({1}% do total)", candidato2, percentualCandidato2.ToString("F2"));
        Console.WriteLine("Candidato 3: {0} votos ({1}% do total)", candidato3, percentualCandidato3.ToString("F2"));
        Console.WriteLine("Votos Nulos: {0}", votosNulos);
        Console.WriteLine("Votos em Branco: {0}", votosBrancos);

        double percentualNulos = (double)votosNulos / totalVotos * 100;
        double percentualBrancos = (double)votosBrancos / totalVotos * 100;

        Console.WriteLine("Percentual de votos nulos: {0}%", percentualNulos.ToString("F1"));
        Console.WriteLine("Percentual de votos em branco: {0}%\n", percentualBrancos.ToString("F1"));

        Console.WriteLine("------------------------------------");

        if (candidato1 > candidato2 && candidato1 > candidato3)
        {
            Console.WriteLine("VENCEDOR: CANDIDATO 1");
        }
        else if (candidato2 > candidato1 && candidato2 > candidato3)
        {
            Console.WriteLine("VENCEDOR: CANDIDATO 1");
        }
        else if (candidato3 > candidato1 && candidato3 > candidato2)
        {
            Console.WriteLine("VENCEDOR: CANDIDATO 1");
        }
        else
        {
            Console.WriteLine("A eleição terminou em empate.");
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine("\nTotal de votos: {0}", totalVotos);
    }
}
