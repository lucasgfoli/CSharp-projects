using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a descricao do produto: ");
        string descricaoUser = Console.ReadLine();

        Console.WriteLine("Digite o preço de custo");
        double precoCustoUser = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número inteiro para a margem de lucro, de 10 à 50");
        int margemLucroUser = int.Parse(Console.ReadLine());

        Produto produto = new Produto(descricaoUser, precoCustoUser);
        string relatorio = produto.Relatorio(margemLucroUser);

        Console.WriteLine();
        Console.WriteLine(relatorio);
    }
}

class Produto
{
    string _descricao; //atributo
    double _precoCusto; //atributo

    public Produto(string descricao, double precoCusto) // Construtor da classe
    {
        _descricao = descricao;
        _precoCusto = precoCusto;
    }

    public double CalcularPrecoVenda(int margemLucro)
    {
        return _precoCusto + (_precoCusto * margemLucro / 100);
    }

    public string Relatorio(int margemLucro)
    {
        double precoVenda = CalcularPrecoVenda(margemLucro);
        return $"Relatório do produto: \n - Preço de custo: {_precoCusto}\n - Preço de venda: {precoVenda}\n - Descrição: {_descricao}";
    }
}

// O modificador static faz com que o método pertença à classe, e não a uma instância (objeto) da classe.
// Isso significa que você pode chamar o método diretamente pela classe, sem precisar criar um objeto.