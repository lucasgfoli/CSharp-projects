using System;

class Program1
{

    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        int opcao = -1; // Inicializa a variável opcao com um valor inválido para garantir que o loop comece.
        double[] numerosArmazenados = new double[0]; // Inicializa o vetor vazio para armazenar os números.

        do 
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

            if (!entrada)
            {
                Console.WriteLine("Digite uma das opções!");
                Console.ReadKey(); // Pausa para o usuário ler a mensagem.
                continue; // É utilizado 'continue' para reiniciar o loop sem executar o restante do código.
            }
            else
            {
                switch (opcao)
                {
                    case 1: Dividir(); break;
                    case 2: DefinirMaior(); break;
                    case 3: numerosArmazenados = Armazenar(); break;
                    case 4: SomaValores(numerosArmazenados); break;
                    case 5: ImparOuPar(numerosArmazenados); break;
                    case 0: break;
                }
            }
        } while (opcao != 0); // Garante que o loop continue até o usuário escolher a opção 0.
    }

    static void Dividir()
    {
        double resultado;
        Console.WriteLine("Digite o numerador da divisão:");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o denominador da divisão:");
        double n2 = double.Parse(Console.ReadLine());

        if (n2 == 0)
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

        double maior = Math.Max(n1, Math.Max(n2, n3)); // Compara primeiro n2 e n3 para definir o maior entre eles, depois compara o resultado com n1.

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

        Console.WriteLine("A soma dos valores armazenados é: {0}", soma);
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