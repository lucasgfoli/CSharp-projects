using System;
class Program
{

    static void Main()
    {
        Console.WriteLine("Digite um número inteiro para começar:");
        int numero = int.Parse(Console.ReadLine());
        ImprimirSomaEMedia(numero);

        Console.WriteLine("Digite um número inteiro para exibir o somatório:");
        int N = int.Parse(Console.ReadLine());
        Somatório(N);

        Console.WriteLine("Digite um número inteiro:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número inteiro:");
        int b = int.Parse(Console.ReadLine());

        ImprimirImparesDoIntervalo(a, b);
    }

    static void ImprimirSomaEMedia(int numero)
    {
        int count = 1;
        int soma = numero;
        int N = numero;

        while (N >= 0)
        {
            Console.WriteLine("Digite um número, digite um número negativo para parar");
            N = int.Parse(Console.ReadLine());

            if (N >= numero)
            {
                soma += N;
                count++;
            }
        }

        double media = (double)soma / count;
        Console.WriteLine($"A soma dos números digitados é: {soma}, a média dos números digitados é: {media}");
    }

    static void Somatório(int N)
    {
        double soma = 0;

        for (int i = 0; i <= N; i++)
        {
            for (int j = N; j >= 1; j++)
            {
                soma += (i + 1) / (j - (i + 1));
            }
        }

        Console.WriteLine("O somatório resulta em {0:F2}", soma);
    }

    static void ImprimirImparesDoIntervalo(int a, int b)
    {
        long produto = 1;
        bool temImpar = false;

        if (a > b)
            (b, a) = (a, b);

        for (int i = a; i <= b; i++)
        {
            if (i % 2 != 0)
            {
                produto *= i;
                temImpar = true;
            }
        }

        if (temImpar)
            Console.WriteLine($"O produto dos impares no intervalo entre {a} e {b} é {produto}");
        else
            Console.WriteLine("Não há ímpares");
    }
}
