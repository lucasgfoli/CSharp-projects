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

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Digite uma opção:");
        Console.WriteLine("1 - Dividir dois números.");
        Console.WriteLine("2 – Ler 3 números e mostrar qual é o maior deles.");
        Console.WriteLine("3 – Ler e armazenar N números.");
        Console.WriteLine("4 – Mostrar a soma dos números armazenados.");
        Console.WriteLine("5 - Contar quantos dos números armazenados são pares e quantos são ímpares.");
        Console.WriteLine("0 - Sair \n Opção:");

        bool entrada = int.TryParse(Console.ReadLine(), out opcao);

        if (!entrada) return Console.WriteLine("Digite uma das opções!");
        else
        {
            switch (opcao)
            {
                case 1: Dividir(); break;
                case 2: DefinirMaior(); break;
                case 3: Armazenar(); break;
                case 4: SomaValores(Armazenar());
                case 5: ImparOuPar(Armazenar());
                case 0: break;
            }
        }
    }

    static void Dividir()
    {
        Console.WriteLine("Digite o numerador da divisão:");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o denominador da divisão:");
        double n2 = double.Parse(Console.ReadLine());

        if (n1 == 0)
            return Console.WriteLine("Não é possível dividir 0");
        else
            resultado = n1 / n2;
        Console.WriteLine("O resultado da divisão é: {0:F2}", resultado);
    }

    static void DefinirMaior()
    {
        Console.WriteLine("Digite o primeiro número:");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número:");
        double n3 = double.Parse(Console.ReadLine());

        double maior = n1;

        if (n1 < n2 && n2 > n3)
            maior = n2;
        else if (n3 > n1)
            maior = n3;

        Console.WriteLine("O maior número digitado é: {0:F2}", maior);
    }

    static double[] Armazenar()
    {
        Console.WriteLine("Digite quantos números quer armazenar: ");

        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro maior que 0.");
            return new double[0];
        }
        else
        {
            double[] vetor = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um número inteiro: ");
                string input = Console.ReadLine();

                bool numeroValido = double.TryParse(input, out double valor);

                if (numeroValido && valor >= 0)
                    vetor[i] = valor;
                else
                {
                    Console.WriteLine("Valor inválido! Digite apenas números positivos.");
                    i--;
                }
            }

            return vetor;
        }

    }

    static double SomaValores(double[] vetor)
    {
        if (vetor.Length == 0)
        {
            Console.WriteLine("O vetor está vazio.");
            return 0;
        }

        double soma = 0;

        foreach (double valor in vetor)
            soma += valor;

        return soma;
    }

    static void ImparOuPar(double[] vetor)
    {
        int par = 0;
        int impar = 0;

        if (vetor.Length == 0)
        {
            Console.WriteLine("O vetor está vazio.");
            return;
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            int numero = (int)vetor[i];

            if (numero % 2 == 0)
                par++;
            else
                impar++;
        }

        Console.WriteLine("A quantidade de números pares é: {0} e de números ímpares: {1}", par, impar);
    }
}

class Atividade3
{
    static void Main()
    {
        TotalExercicios();
    }

    static double TotalExercicios()
    {
        double[] notas = new double[4];
        double soma = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Digite a nota {i + 1} de 0 a 10");
            notas[i] = double.Parse(Console.ReadLine());

            if (notas[i] > 10 || notas[i] < 0)
            {
                Console.WriteLine("Digite uma nota de 0 a 10!");
                i--;
            }
        }

        for (int i = 0; i < 4; i++)
            soma += notas[i];

        double media = soma / 4;
        double peso = media * 0.2;

        return peso;
    }

    static double TotalProvas()
    {
        double prova1 = LerNota("Digite a primeira nota (de 0 a 100)");
        double prova2 = LerNota("Digite a segunda nota (de 0 a 100)");

        double media = (prova1 + prova2) / 2;

        double peso = media * 0.6;

        return peso;
    }

    static double LerNota(string mensagem)
{
    double nota;

    do
    {
        Console.WriteLine(mensagem);
        nota = double.Parse(Console.ReadLine());

        if (nota < 0 || nota > 100)
            Console.WriteLine("Nota inválida! Digite um valor entre 0 e 100.");
        
    } while (nota < 0 || nota > 100);

    return nota;
}

}