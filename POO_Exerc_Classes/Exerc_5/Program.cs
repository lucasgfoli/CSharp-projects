using System;
using System.Collections.Generic;

class Livro
{
    private string _titulo;
    private string _autor;
    private int _numeroPaginas;
    private List<double> _avaliacoes = new List<double>();

    /// <summary>
    /// Construtor padrão. Inicializa os atributos com os valores informados.
    /// </summary>
    /// <param name="titulo">Campo string para titulo.</param>
    /// <param name="autor">Campo string para autor.</param>
    /// <param name="numeroPaginas">Campo inteiro para número de páginas.</param>
    public Livro(string titulo, string autor, int numeroPaginas)
    {
        _titulo = titulo;
        _autor = autor;
        _numeroPaginas = numeroPaginas;
    }

    /// <summary>
    /// Recebe avaliações válidas, desde que esteja no intervalo de 0 a 5
    /// </summary>
    /// <param name="avaliacao">Double com valor da avaliação (0 a 5).</param>
    /// <returns>Double com a avaliação atual.</returns>
    public double ReceberAvaliacao(double avaliacao)
    {
        if (avaliacao >= 0 && avaliacao <= 5)
            _avaliacoes.Add(avaliacao);

        return avaliacao;
    }

    /// <summary>
    /// Calcula a média das avaliações.
    /// </summary>
    /// <returns>Double com a média das avaliações.</returns>
    public double AvaliacaoMedia()
    {
        double soma = 0;

        if (_avaliacoes.Count == 0)
        {
            return 0.0;
        }

        foreach (double avaliacao in _avaliacoes)
        {
            soma += avaliacao;
        }

        return soma / _avaliacoes.Count;
    }

    /// <summary>
    /// Calcula o tempo necessário para ler um livro.
    /// </summary>
    /// <param name="minutosPorPagina">Inteiro com valor dos minutos para ler uma página.</param>
    /// <returns>String com tempo total de leitura formatado em horas e minutos.</returns>
    public string TempoParaLer(int minutosPorPagina)
    {
        if (minutosPorPagina <= 0)
            return "";

        int tempoTotal = minutosPorPagina * _numeroPaginas;

        int horas = tempoTotal / 60;
        int minutos = tempoTotal % 60;

        return $"Tempo total para ler livro: {horas} horas e {minutos} minutos.";
    }

    /// <summary>
    /// Imprime as informações do livro.
    /// </summary>
    public void InfoLivro()
    {
        Console.WriteLine($"Informações do Livro:");
        Console.WriteLine($"Titulo do livro: {_titulo}");
        Console.WriteLine($"Autor do livro: {_autor}");
        Console.WriteLine($"Número de páginas do livro: {_numeroPaginas}");
    }

    static void Main()
    {
        Livro livro = new Livro("Olhai os lírios do campo", "Érico Veríssimo", 288);

        livro.ReceberAvaliacao(5);
        livro.ReceberAvaliacao(4);
        livro.ReceberAvaliacao(4.5);
        livro.ReceberAvaliacao(5);

        Console.WriteLine("Avaliação média do livro: {0:F2}", livro.AvaliacaoMedia());

        Console.WriteLine(livro.TempoParaLer(5));

        livro.InfoLivro();
    }
}