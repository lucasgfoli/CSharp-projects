using System;

class Lista3
{
    static void Main()
    {
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
        int soma = 0;

        for (int i = 3; i <= 500; i++)
        {
            if (i % 2 != 0 && i % 3 == 0)
            {
                soma += i;
            }
        }

        Console.WriteLine("Atividade 1 - Soma dos ímpares múltiplos de 3 de 1 a 500: " + soma);
    }

    // ---------------------- Atividade 2 ----------------------
    static void Atividade2()
    {
        double alturaMax = 1, alturaMin = 100;
        double altura;

        Console.WriteLine("Atividade 2 - Digite 15 alturas (exemplo: 1.80):");

        for (int i = 1; i <= 15; i++)
        {
            altura = double.Parse(Console.ReadLine());

            if (altura <= 0)
            {
                Console.WriteLine("Altura inválida! Digite uma altura maior que 0.");
                i--;
            }
            else if (altura > alturaMax)
                alturaMax = altura;
            else if (altura < alturaMin)
                alturaMin = altura;
        }

        Console.WriteLine("Altura máxima: {0:F2} | Altura mínima: {1:F2}", alturaMax, alturaMin);
    }

    // ---------------------- Atividade 3 ----------------------
    static void Atividade3()
    {
        Console.WriteLine("Atividade 3 - Números que atendem à condição:");
        for (int i = 1000; i <= 9999; i++)
        {
            int parte1 = i / 100;
            int parte2 = i % 100;

            int soma = parte1 + parte2;

            if (soma * soma == i)
            {
                Console.WriteLine(i);
            }
        }
    }

    // ---------------------- Atividade 4 ----------------------
    static void Atividade4()
    {
        int n1 = 0, n2 = 1, n;

        Console.WriteLine("Atividade 4 - Primeiros 20 termos da sequência de Fibonacci:");
        Console.WriteLine(n1);
        Console.WriteLine(n2);

        for (int i = 3; i <= 20; i++)
        {
            n = n1 + n2;
            Console.WriteLine(n);

            n1 = n2;
            n2 = n;
        }
    }

    // ---------------------- Atividade 5 ----------------------
    static void Atividade5()
    {
        Console.WriteLine("Atividade 5 - Cálculo de PI por série de Leibniz");
        Console.Write("Digite o número de termos: ");
        int numTermos = int.Parse(Console.ReadLine());

        double PI = 0;

        for (int i = 0; i < numTermos; i++)
        {
            if (i % 2 == 0)
                PI += 1.0 / (2 * i + 1);
            else
                PI -= 1.0 / (2 * i + 1);
        }

        PI *= 4;

        Console.WriteLine("Valor aproximado de PI: {0}", PI);
    }

    // ---------------------- Atividade 6 ----------------------
    static void Atividade6()
    {
        Console.WriteLine("Atividade 6 - Soma de N números a partir de A");

        Console.Write("Digite um valor para A: ");
        int A = int.Parse(Console.ReadLine());

        int N;
        do
        {
            Console.Write("Digite um valor maior que 0 para N: ");
            N = int.Parse(Console.ReadLine());
        } while (N <= 0);

        int soma = 0;

        for (int i = 0; i < N; i++)
        {
            soma += A + i;
            Console.WriteLine("Soma parcial: " + soma);
        }

        Console.WriteLine("Soma final dos {0} números a partir de {1} é: {2}", N, A, soma);
    }

    // ---------------------- Atividade 7 ----------------------
    static void Atividade7()
    {
        Console.WriteLine("Atividade 7 - Contagem de números no intervalo [0,100]");

        int N, contador = 0;

        do
        {
            Console.Write("Digite um número (negativo para encerrar): ");
            N = int.Parse(Console.ReadLine());

            if (N >= 0 && N <= 100)
                contador++;

        } while (N >= 0);

        Console.WriteLine("Total de números no intervalo de 0 a 100: {0}", contador);
    }

    // ---------------------- Atividade 8 ----------------------
    static void Atividade8()
    {
        Console.WriteLine("Atividade 8 - Cálculo de MMC e MDC");

        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int a = num1, b = num2, aux;

        while (b != 0)
        {
            aux = a % b;
            a = b;
            b = aux;
        }

        int MDC = a;
        int MMC = (num1 * num2) / MDC;

        Console.WriteLine("MMC: {0} | MDC: {1}", MMC, MDC);
    }

    // ---------------------- Atividade 9 ----------------------
    static void Atividade9()
    {
        Console.WriteLine("Atividade 9 - Votação de candidatos");

        int voto;
        int candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0;
        int nulos = 0, brancos = 0;

        Console.WriteLine("Digite o código do voto (1 a 4 = candidatos, 5 = nulo, 6 = branco, 0 = encerrar):");

        do
        {
            voto = int.Parse(Console.ReadLine());

            switch (voto)
            {
                case 1: candidato1++; break;
                case 2: candidato2++; break;
                case 3: candidato3++; break;
                case 4: candidato4++; break;
                case 5: nulos++; break;
                case 6: brancos++; break;
                case 0: break;
                default:
                    Console.WriteLine("Código inválido! Digite entre 0 e 6.");
                    break;
            }

        } while (voto != 0);

        Console.WriteLine("Votos Candidato 1: {0}", candidato1);
        Console.WriteLine("Votos Candidato 2: {0}", candidato2);
        Console.WriteLine("Votos Candidato 3: {0}", candidato3);
        Console.WriteLine("Votos Candidato 4: {0}", candidato4);
        Console.WriteLine("Votos Nulos: {0}", nulos);
        Console.WriteLine("Votos em Branco: {0}", brancos);
    }

    // ---------------------- Atividade 10 ----------------------
    static void Atividade10()
    {
        Console.WriteLine("Atividade 10 - Estatísticas da população");

        int percentual = 0;
        double filhos = 0, populacao = 0, salario = 1, somaSalarios = 0;

        while (salario >= 0)
        {
            Console.Write("Digite o salário (valor negativo para encerrar): ");
            salario = double.Parse(Console.ReadLine());

            if (salario >= 0)
            {
                Console.Write("Digite o número de filhos: ");
                filhos += int.Parse(Console.ReadLine());

                populacao++;
                somaSalarios += salario;

                if (salario <= 1500)
                    percentual++;
            }
        }

        if (populacao > 0)
        {
            double mediaSalario = somaSalarios / populacao;
            double mediaFilhos = filhos / populacao;
            double percentual1500 = (percentual / populacao) * 100;

            Console.WriteLine("Média de filhos: {0:F2}", mediaFilhos);
            Console.WriteLine("Média salarial: R$ {0:F2}", mediaSalario);
            Console.WriteLine("Percentual com salário até R$1500: {0:F0}%", percentual1500);
        }
        else
        {
            Console.WriteLine("Nenhum dado válido inserido.");
        }
    }
}
