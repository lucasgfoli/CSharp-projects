using System;

class Lista5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Lista 5 de C#:\n");

        Atividade1();
        Atividade2();
        Atividade3();
        Atividade4();
        Atividade5();
        Atividade6();
        Atividade7();
        Atividade8();
        Atividade9();
        Atividade10();
    }

    // ---------------------- Atividade 1 ----------------------
    static void Atividade1()
    {
        int[] numeros = new int[5];
        int soma = 0;

        Console.WriteLine("Atividade 1:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        Console.WriteLine("\nNúmeros digitados:");
        foreach (int numero in numeros)
            Console.Write(numero + " ");

        Console.WriteLine($"\nSoma dos números: {soma}\n");
    }

    // ---------------------- Atividade 2 ----------------------
    static void Atividade2()
    {
        double[] numeros = new double[10];
        double soma = 0;

        Console.WriteLine("Atividade 2:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        double media = soma / 10;
        int acimaDaMedia = 0;

        foreach (double num in numeros)
        {
            if (num > media)
                acimaDaMedia++;
        }

        Console.WriteLine($"\nMédia: {media}");
        Console.WriteLine($"Quantidade acima da média: {acimaDaMedia}\n");
    }

    // ---------------------- Atividade 3 ----------------------
    static void Atividade3()
    {
        string[] nomes = new string[8];

        Console.WriteLine("Atividade 3:");

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Digite o {i + 1}º nome: ");
            nomes[i] = Console.ReadLine();
        }

        Console.Write("\nDigite um nome para buscar: ");
        string busca = Console.ReadLine();

        bool encontrado = false;
        foreach (string nome in nomes)
        {
            if (nome.Equals(busca, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;
                break;
            }
        }

        Console.WriteLine(encontrado ? "Nome encontrado.\n" : "Nome não encontrado.\n");
    }

    // ---------------------- Atividade 4 ----------------------
    static void Atividade4()
    {
        int[,] matriz = new int[4, 4];
        int somaDiagonal = 0;

        Console.WriteLine("Atividade 4:");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Digite o valor da posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());

                if (i == j)
                    somaDiagonal += matriz[i, j];
            }
        }

        Console.WriteLine("\nMatriz informada:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write(matriz[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }

        Console.WriteLine($"\nSoma da diagonal principal: {somaDiagonal}\n");
    }

    // ---------------------- Atividade 5 ----------------------
    static void Atividade5()
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorSoma = new int[5];

        Console.WriteLine("Atividade 5:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º valor do vetor A: ");
            vetorA[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º valor do vetor B: ");
            vetorB[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
            vetorSoma[i] = vetorA[i] + vetorB[i];

        Console.WriteLine("\nVetor Soma:");
        foreach (int valor in vetorSoma)
            Console.Write(valor + " ");
        Console.WriteLine("\n");
    }

    // ---------------------- Atividade 6 ----------------------
    static void Atividade6()
    {
        int[,] matriz = new int[3, 3];
        int somaPares = 0;

        Console.WriteLine("Atividade 6:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor da posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());

                if (matriz[i, j] % 2 == 0)
                    somaPares += matriz[i, j];
            }
        }

        Console.WriteLine("\nMatriz digitada:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(matriz[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }

        Console.WriteLine($"\nSoma dos elementos pares: {somaPares}\n");
    }

    // ---------------------- Atividade 7 ----------------------
    static void Atividade7()
    {
        int[] numeros = new int[10];
        Console.WriteLine("Atividade 7:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int maior = numeros[0], menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
                maior = numeros[i];
            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine($"\nMaior número: {maior}");
        Console.WriteLine($"Menor número: {menor}\n");
    }

    // ---------------------- Atividade 8 ----------------------
    static void Atividade8()
    {
        int[,] matriz = new int[3, 2];
        int soma = 0;
        Console.WriteLine("Atividade 8:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Digite o valor da posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
                soma += matriz[i, j];
            }
        }

        double media = (double)soma / (3 * 2);
        Console.WriteLine($"\nMédia dos elementos da matriz: {media:F2}\n");
    }

    // ---------------------- Atividade 9 ----------------------
    static void Atividade9()
    {
        Console.WriteLine("Atividade 9:");
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        int contador = 0;
        string vogais = "aeiouAEIOU";

        foreach (char c in frase)
        {
            if (vogais.Contains(c))
                contador++;
        }

        Console.WriteLine($"\nQuantidade de vogais: {contador}\n");
    }

    // ---------------------- Atividade 10 ----------------------
    static void Atividade10()
    {
        int[] numeros = new int[6];
        Console.WriteLine("Atividade 10:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("\nValores em ordem crescente:");
        foreach (int num in numeros)
            Console.Write(num + " ");
        Console.WriteLine("\n");
    }
}
