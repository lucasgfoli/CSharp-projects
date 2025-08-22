using System;
using System.Collections.Generic;
using System.Linq;
class Program
{

    static void Main()
    {
        // Console.WriteLine("Digite um número inteiro para começar:");
        // int numero = int.Parse(Console.ReadLine());
        // ImprimirSomaEMedia(numero);

        // Console.WriteLine("Digite um número inteiro para exibir o somatório:");
        // int N = int.Parse(Console.ReadLine());
        // Somatório(N);

        // Console.WriteLine("Digite um número inteiro:");
        // int a = int.Parse(Console.ReadLine());
        // Console.WriteLine("Digite outro número inteiro:");
        // int b = int.Parse(Console.ReadLine());

        // ImprimirImparesDoIntervalo(a, b);

        // Console.WriteLine("Digite um número inteiro para A:");
        // int A = int.Parse(Console.ReadLine());
        // Console.WriteLine("Digite outro número inteiro para B:");
        // int B = int.Parse(Console.ReadLine());
        // Console.WriteLine("Digite o número que você quer saber os divisores dele entre A e B");
        // int C = int.Parse(Console.ReadLine());

        // DivisorC(A, B, C);

        // Console.WriteLine("Digite uma palavra: ");
        // string palavraUser = Console.ReadLine();

        // EstilizarString(palavraUser);

        Votos();

    }

    // static void ImprimirSomaEMedia(int numero)
    // {
    //     int count = 1;
    //     int soma = numero;
    //     int N = numero;

    //     while (N >= 0)
    //     {
    //         Console.WriteLine("Digite um número, digite um número negativo para parar");
    //         N = int.Parse(Console.ReadLine());

    //         if (N >= numero)
    //         {
    //             soma += N;
    //             count++;
    //         }
    //     }

    //     double media = (double)soma / count;
    //     Console.WriteLine($"A soma dos números digitados é: {soma}, a média dos números digitados é: {media}");
    // }

    // static void Somatório(int N)
    // {
    //     double soma = 0;

    //     for (int i = 0; i <= N; i++)
    //     {
    //         for (int j = N; j >= 1; j++)
    //         {
    //             soma += (i + 1) / (j - (i + 1));
    //         }
    //     }

    //     Console.WriteLine("O somatório resulta em {0:F2}", soma);
    // }

    // static void ImprimirImparesDoIntervalo(int a, int b)
    // {
    //     long produto = 1;
    //     bool temImpar = false;

    //     if (a > b)
    //         (b, a) = (a, b);

    //     for (int i = a; i <= b; i++)
    //     {
    //         if (i % 2 != 0)
    //         {
    //             produto *= i;
    //             temImpar = true;
    //         }
    //     }

    //     if (temImpar)
    //         Console.WriteLine($"O produto dos impares no intervalo entre {a} e {b} é {produto}");
    //     else
    //         Console.WriteLine("Não há ímpares");
    // }

    // static void DivisorC(int a, int b, int c)
    // {
    //     List<int> lista = new List<int>(); // Cria uma nova lista de inteiros, poderia ser usado 'var', que permite que o compilador deduza qual o tipo da variável.
    //     if (a > b)
    //     {
    //         (b, a) = (a, b);
    //     }

    //     for (int i = a; i <= b; i++)
    //     {
    //         if (i % c == 0)
    //             lista.Add(i);
    //     }

    //     int[] divisores = lista.ToArray();

    //     if (divisores.Length == 0)
    //         Console.WriteLine($"Não há divisores por {c} no intervalo entre {a} e {b}");
    //     else
    //         Console.WriteLine($"Os números divisíveis por {c} são {ImprimirArray(divisores)}");
    // }

    // public static string ImprimirArray(int[] array)
    // {
    //     return string.Join(", ", array); // Cria uma string a partir de uma collection, colocando um separador entre os elementos string.Join(separador, collection).
    // }

    // static void EstilizarString(string palavra)
    // {
    //     // Laço para imprimir a palavra aumentando.
    //     for (int i = 0; i <= palavra.Length; i++)
    //     {
    //         Console.WriteLine(palavra.Substring(0, i)); // Essa substring começa na posição 0 e termina na posição de i.
    //     }

    //     //Laço para imprimir a palavra diminuindo.
    //     for (int j = palavra.Length - 1; j > 0; j--)
    //     {
    //         Console.WriteLine(palavra.Substring(0, j)); // Essa substring começa de trás pra frente e vai diminuindo a palavra até chegar em 0;
    //     }
    // }


    public static void Votos()
    {
        int Votosnulos = 0, votosBrancos = 0;
        List<string> votosValidos = new List<string>();

        while (true)
        {
            Console.WriteLine("Digite o seu voto, o primeiro dígito é o andar os dois últimos são o número do apartamento (Ex: 101)");
            int voto = int.Parse(Console.ReadLine());

            if (!verificarFim(voto)) break;

            if (voto == 0)
            {
                votosBrancos++;
                continue;
            }
            else
            {
                int andar = voto / 100;
                int apto = voto % 100;

                if (validarVoto(andar, apto))
                {
                    votosValidos.Add(voto);
                }
                else
                {
                    Console.WriteLine("Voto inválido! Foi considerado como voto nulo");
                    Votosnulos++;
                    continue;
                }
            }

            int totalVotos = votosValidos.Count + votosBrancos + Votosnulos;

            Console.WriteLine("Resultado da votação:");
            Console.WriteLine($"Total de votos: {totalVotos}");
            Console.WriteLine($"Votos válidos: {votosValidos.Count} ({(double)votosValidos.Count / totalVotos:P2})");
            Console.WriteLine($"Votos em branco: {votosBrancos} ({(double)votosBrancos / totalVotos:F2})");
            Console.WriteLine($"Votos nulos: {Votosnulos} ({(double)Votosnulos / totalVotos:P2})");

            if (votosValidos.Count > 0)
            {
                var candidatoMaisVotado = votosValidos.GroupBy(c => c).OrderByDescending(c => c.Count()).FirstOrDefault(); // GroupBy agrupa os valores iguais, OrderByDescending orderna do maior e FirstOrDefault(com mais incidência ou o padrão).
                int numero = int.Parse(candidatoMaisVotado.Key);
                int andarVotado = numero / 100;
                int aptoVotado = numero % 100;

                Console.WriteLine($"Apto mais votado: {andarVotado}{aptoVotado:D2}"); // Key retorna uma instãncia do GroupBy e exibe duas casas com o D.
                Console.WriteLine($"Quantidade: {candidatoMaisVotado.Count()}");
                Console.WriteLine($"Percentual: {(double)candidatoMaisVotado.Count() / votosValidos.Count:P2}"); // P Exibe o percentual com duas casas.

            }
        }
    }

    public static bool validarVoto(int andar, int apto)
    {
        if (andar > 0 && andar <= 13 && (apto == 01 || apto == 02)) return true;

        return false;
    }

    public static bool verificarFim(int voto)
    {
        return voto != 999;
    }
}
