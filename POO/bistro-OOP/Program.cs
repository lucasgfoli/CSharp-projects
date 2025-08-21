using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<Prato> pratos = CriarPratos();
        ExibirPratos(pratos);
        LerAvaliacoes(pratos);
        Relatorio(pratos);
    }

    static void Relatorio(List<Prato> pratos)
    {
        double SomaNotas = pratos.Sum(p => p._somaNotas);
        int totalAvaliacoes = pratos.Sum(p => p._quantidadeConsumida);


        Prato pratoMaisConsumido = pratos.OrderByDescending(p => p._quantidadeConsumida).First(); // P é a variável da expressão lambda para representar cada prato.
        Prato pratoComMaiorMedia = pratos.OrderByDescending(p => p._notaMedia).First(); // OrderByDescending ordena um Collection da maior pra menor (descendente) com base numa propriedade.
        Prato pratoComMaisNota5 = pratos.OrderByDescending(p => p._quantidadeNota5).First(); // First() retorna o primeiro elemento da Collection que foi ordernada a partir do OrderByDescending.

        double mediaTodosOsPratos = totalAvaliacoes == 0 ? 0 : SomaNotas / totalAvaliacoes; // Verificação rápida para não dividir por 0.

        Console.WriteLine($"Prato mais consumido: {pratoMaisConsumido._nome}");
        Console.WriteLine(); // Quebra-Linha
        Console.WriteLine($"Prato com maior nota média: {pratoComMaiorMedia._nome:F2}");
        Console.WriteLine(); // Quebra-Linha
        Console.WriteLine("Nota média de cada prato:");
        Console.WriteLine(); // Quebra-Linha

        foreach (Prato prato in pratos)
        {
            Console.WriteLine($"{prato._nome}: {prato._notaMedia}");
        }
        Console.WriteLine(); // Quebra-Linha

        Console.WriteLine($"O prato com mais notas 5: {pratoComMaisNota5._nome}");
        Console.WriteLine(); // Quebra-Linha
        Console.WriteLine($"A média de todos os pratos: {mediaTodosOsPratos:F2}");
    }

    static void LerAvaliacoes(List<Prato> pratos)
    {
        while (true)
        {
            Console.WriteLine("Digite o número do prato que consumiu, digite 0 para sair: ");

            if (!int.TryParse(Console.ReadLine(), out int pratoEscolhido) || pratoEscolhido < 0 || pratoEscolhido > pratos.Count)
            {
                Console.WriteLine("Opção inválida. Digite uma opção válida: 0 para sair ou de 1 até 5 para escolher um prato.");
                continue; // Interrompe a iteração atual e pula pra próxima repetição.
            }

            if (pratoEscolhido == 0) break;

            Console.WriteLine("Digite a nota de 0 a 5 para o prato escolhido:");

            if (!double.TryParse(Console.ReadLine(), out double notaEscolhida) || notaEscolhida < 0 || notaEscolhida > 5)
            {
                Console.WriteLine("Nota inválida. Digite uma nota de 0 a 5.");
                continue;
            }

            pratos[pratoEscolhido - 1].Avaliar(notaEscolhida); // -1 pois a lista começa no valor 0.
        }
    }

    static void ExibirPratos(List<Prato> pratos)
    {
        Console.WriteLine("Pratos disponíveis:");

        for (int i = 0; i < pratos.Count; i++) // Usa-se .Count para caso mais pratos sejam adicionados.
        {
            Console.WriteLine($"{i + 1}. {pratos[i]._nome}");
        }
    }

    public static List<Prato> CriarPratos()
    {
        return new List<Prato>
        {
            new Prato("Moqueca de Palmito"),
            new Prato("Falafel Assado"),
            new Prato("Salada Primavera com Macarrão Konjac"),
            new Prato("Escondidinho de Inhame"),
            new Prato("Strogonoff de Cogumelos")
        };
    }
}

class Prato
{
    public string _nome { get; }
    public int _quantidadeConsumida { get; private set; }
    public double _somaNotas { get; private set; }
    public int _quantidadeNota5 { get; private set; }

    public Prato(string nome)
    {
        _nome = nome;
        _quantidadeConsumida = 0;
        _somaNotas = 0;
        _quantidadeNota5 = 0;
    }

    public void Avaliar(double nota)
    {
        _quantidadeConsumida++;
        _somaNotas += nota;

        if (nota == 5) _quantidadeNota5++;

    }
    public double _notaMedia => _quantidadeConsumida == 0 ? 0 : (double)_somaNotas / _quantidadeConsumida; // Caso a quantidade consumida seja maior que 0, realiza a média das notas.
}


// Implemente um programa Java que permita a cada cliente indicar qual prato consumiu e atribuir uma 
// nota a este prato. Um número indeterminado de clientes irá fazer as avaliações, até que se indique que o 
// programa finalize a leitura de avaliações. Então, o programa deve responder qual foi o prato mais consumido, o 
// prato com a maior nota média, a nota média de cada prato, o prato com a maior quantidade de notas 5 e a nota 
// média de todos os pratos consumidos no restaurante.

// Get faz parte das propriedades em C#.
// As propriedades são uma forma de acessar e se permitido, modificar um objeto.
