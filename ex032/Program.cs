// 32.	Uma empresa está fazendo análise de uma determinada população. Os seguintes dados são obtidos das pessoas:
// a.	Idade
// b.	Cor de Cabelos (Castanhos, Pretos, Loiros ou Outro)
// c.	Altura
// d.	Peso
// e.	Sexo (Masculino ou Feminino)

// Faça um algoritmo para mostrar, ao final do processamento os seguintes dados:
// a.	Quantas pessoas possuem idade superior a 18 anos
// b.	Qual é a média das idades, a idade da pessoa mais idosa e a idade da pessoa mais jovem?
// c.	Quantas pessoas em porcentagem possuem cabelos castanhos, pretos, loiros e outros?
// d.	Quantas pessoas possuem altura superior a 1,70 m
// e.	Quantas pessoas peso superior a 80 kg.
// f.	Quantas pessoas em porcentagem são do sexo masculino e quantas são do sexo feminino.
using System;

class Program
{
    static void Main(string[] args)
    {
        int idade;
        string corCabelos;
        float altura;
        float peso;
        string sexo;
        int totalPessoas = 0;
        int pessoasMaior18 = 0;
        int pessoasCastanhos = 0;
        int pessoasPretos = 0;
        int pessoasLoiros = 0;
        int pessoasOutros = 0;
        int pessoasAlturaMaior170 = 0;
        int pessoasPesoMaior80 = 0;
        int pessoasMasculino = 0;
        int pessoasFeminino = 0;
        int idadeMaisJovem = int.MaxValue;
        int idadeMaisIdosa = int.MinValue;
        int somaIdades = 0;

        Console.WriteLine("Análise da População");
        Console.WriteLine("--------------------");

        Console.Write("Informe a quantidade de pessoas na população: ");
        totalPessoas = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalPessoas; i++)
        {
            Console.WriteLine($"\nDados da pessoa {i + 1}:");

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade > 18)
                pessoasMaior18++;

            if (idade < idadeMaisJovem)
                idadeMaisJovem = idade;

            if (idade > idadeMaisIdosa)
                idadeMaisIdosa = idade;

            somaIdades += idade;

            Console.Write("Cor de Cabelos (Castanhos, Pretos, Loiros ou Outro): ");
            corCabelos = Console.ReadLine().ToLower();

            switch (corCabelos)
            {
                case "castanhos":
                    pessoasCastanhos++;
                    break;
                case "pretos":
                    pessoasPretos++;
                    break;
                case "loiros":
                    pessoasLoiros++;
                    break;
                case "outro":
                    pessoasOutros++;
                    break;
            }

            Console.Write("Altura (em metros): ");
            altura = float.Parse(Console.ReadLine());

            if (altura > 1.70)
                pessoasAlturaMaior170++;

            Console.Write("Peso (em kg): ");
            peso = float.Parse(Console.ReadLine());

            if (peso > 80)
                pessoasPesoMaior80++;

            Console.Write("Sexo (Masculino ou Feminino): ");
            sexo = Console.ReadLine().ToLower();

            switch (sexo)
            {
                case "masculino":
                    pessoasMasculino++;
                    break;
                case "feminino":
                    pessoasFeminino++;
                    break;
            }
        }

        float mediaIdades = (float)somaIdades / totalPessoas;
        float percentualCastanhos = (float)pessoasCastanhos / totalPessoas * 100;
        float percentualPretos = (float)pessoasPretos / totalPessoas * 100;
        float percentualLoiros = (float)pessoasLoiros / totalPessoas * 100;
        float percentualOutros = (float)pessoasOutros / totalPessoas * 100;
        float percentualMasculino = (float)pessoasMasculino / totalPessoas * 100;
        float percentualFeminino = (float)pessoasFeminino / totalPessoas * 100;

        Console.WriteLine("\nResultados");
        Console.WriteLine("----------");
        Console.WriteLine($"a) Pessoas com idade superior a 18 anos: {pessoasMaior18}");
        Console.WriteLine($"b) Média das idades: {mediaIdades:F2}");
        Console.WriteLine($"   Pessoa mais idosa: {idadeMaisIdosa}");
        Console.WriteLine($"   Pessoa mais jovem: {idadeMaisJovem}");
        Console.WriteLine($"c) Porcentagem de pessoas com cabelos castanhos: {percentualCastanhos:F2}%");
        Console.WriteLine($"   Porcentagem de pessoas com cabelos pretos: {percentualPretos:F2}%");
        Console.WriteLine($"   Porcentagem de pessoas com cabelos loiros: {percentualLoiros:F2}%");
        Console.WriteLine($"   Porcentagem de pessoas com cabelos outros: {percentualOutros:F2}%");
        Console.WriteLine($"d) Pessoas com altura superior a 1.70m: {pessoasAlturaMaior170}");
        Console.WriteLine($"e) Pessoas com peso superior a 80kg: {pessoasPesoMaior80}");
        Console.WriteLine($"f) Porcentagem de pessoas do sexo masculino: {percentualMasculino:F2}%");
        Console.WriteLine($"   Porcentagem de pessoas do sexo feminino: {percentualFeminino:F2}%");
    }
}
