using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static List<Pessoa> pessoas = new List<Pessoa>();

    static void Main(string[] args)
    {
        while (true)
        {
            Menu();
        }
    }

    static void Menu()
    {

        Console.WriteLine("\n=== Menu ===");
        Console.WriteLine("1 - Cadastrar nova pessoa");
        Console.WriteLine("2 - Ver estatísticas atuais");
        Console.WriteLine("3 - Sair");
        Console.Write("Opção: ");

        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Pessoa p = CadastroPessoa.CadastrarPessoa();
            pessoas.Add(p);
        }
        else if (opcao == 2)
        {
            ExibirEstastisticas(pessoas);
        }
        else if (opcao == 3)
        {
            Console.WriteLine("Saindo...");
            Environment.Exit(0); // Enviroment.Exit(0) finaliza o programa
        }
        else
        {
            Console.WriteLine("Digite uma opção válida");
        }

    }

    static void ExibirEstastisticas(List<Pessoa> pessoas)
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            return;
        }

        double mediaIdade = pessoas.Average(p => p.Idade); // Average calcula a média
        double mediaPeso = pessoas.Average(p => p.Peso);
        double mediaAltura = pessoas.Average(p => p.Altura);

        int maioresDeIdade = pessoas.Count(p => p.Idade >= 18);
        int menoresDeIdade = pessoas.Count(P => P.Idade < 18);
        int menoresAcima80 = pessoas.Count(p => p.Idade < 18 && p.Peso > 80);

        Pessoa pessoaMaisAlta = pessoas.OrderByDescending(p => p.Altura).First();

        List<string> nomesAlturaAcimaMedia = pessoas //
        .Where(p => p.Altura > mediaAltura)
        .Select(p => p.Nome)
        .ToList();

        // Saída
        Console.WriteLine("\n=== Estatísticas ===");
        Console.WriteLine($"Média de idade: {mediaIdade:F2}");
        Console.WriteLine($"Média de peso: {mediaPeso:F2}");
        Console.WriteLine($"Média de altura: {mediaAltura:F2}");
        Console.WriteLine($"Quantidade de maiores de idade: {maioresDeIdade}");
        Console.WriteLine($"Quantidade de menores de idade: {menoresDeIdade}");
        Console.WriteLine($"Menores de idade acima de 80kg: {menoresAcima80}");
        Console.WriteLine($"Pessoa mais alta: {pessoaMaisAlta.Nome} ({pessoaMaisAlta.Altura}m)");

        Console.WriteLine("Pessoas com altura acima da média:");
        foreach (string nome in nomesAlturaAcimaMedia)
        {
            Console.WriteLine($"- {nome}");
        }

    }
}

class Pessoa
{
    // Propriedades públicas:
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }

    public Pessoa(string nome, int idade, double peso, double altura)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        Altura = altura;
    }
}

class CadastroPessoa
{
    public static Pessoa CadastrarPessoa()
    {
        Console.WriteLine("Digite o nome da pessoa:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a idade da pessoa:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso da pessoa:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura da pessoa:");
        double altura = double.Parse(Console.ReadLine());

        return new Pessoa(nome, idade, peso, altura);
    }
}