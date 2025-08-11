using System;

class Program
{
    static void Main(string[] args)
    {
        Atividade1();
        Atividade2();
    }

    static void Atividade1()
    {
        int soma = 0;
        int[] vet = new int[10];

        Console.WriteLine("Digite um número inteiro");
        vet[0] = int.Parse(Console.ReadLine());
        int menor = vet[0];
        int maior = vet[0];
        soma += vet[0];

        for (int i = 1; i < vet.Length; i++)
        {
            Console.WriteLine("Digite um número inteiro");
            vet[i] = int.Parse(Console.ReadLine());

            if (vet[i] < menor)
                menor = vet[i];
            else if (vet[i] > maior)
                maior = vet[i];

            soma += vet[i];
        }

        double media = (double)soma / 10;
        Console.WriteLine($"Maior valor: {maior}, menor: {menor}, média: {media}");
    }

    static void Atividade2()
    {
        int[,] matriz = new int[3, 3];
        int soma = 0;
        int somaPrincipal = 0;
        int somaSecundaria = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite o valor que estará na posição: [{i}, {j}]");
                matriz[i, j] = int.Parse(Console.ReadLine());
                soma += matriz[i, j];

                if (i == j)
                    somaPrincipal += matriz[i, j];
                if (i + j == 2) //
                    somaSecundaria += matriz[i, j];
            }
        }

        double media = (double)soma / matriz.Length;
        Console.WriteLine($"A soma dos valores da matriz é {soma}");
        Console.WriteLine($"A soma da diagonal primária da matriz é {somaPrincipal}");
        Console.WriteLine($"A soma da diagonal secundária da matriz é {somaSecundaria}");
        Console.WriteLine("A média dos valores da matriz é {0:F2}", media);
    }

       }