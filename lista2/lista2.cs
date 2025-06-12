using System;

class Lista2
{
    static void Main(string[] args)
    {
        Lista2_Atividade1();
        Lista2_Atividade2();
        Lista2_Atividade3();
        Lista2_Atividade4();
        Lista2_Atividade5();
        Lista2_Atividade6();
        Lista2_Atividade7();
        Lista2_Atividade8();
        Lista2_Atividade9();
        Lista2_Atividade10();
    }

    static void Lista2_Atividade1()
    {
        // ---------------------- Atividade 1 ----------------------
        // Verifica se número é positivo, negativo ou zero
        int num;
        Console.WriteLine("Digite um número inteiro:");
        num = int.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("O número digitado é positivo");
        else if (num < 0)
            Console.WriteLine("O número digitado é negativo");
        else
            Console.WriteLine("O número digitado é zero");
    }

    static void Lista2_Atividade2()
    {
        // ---------------------- Atividade 2 ----------------------
        // Identifica maior e menor de três números
        int num1, num2, num3, maior, menor;

        Console.WriteLine("Digite três números inteiros:");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3)
            maior = num1;
        else if (num2 >= num1 && num2 >= num3)
            maior = num2;
        else
            maior = num3;

        if (num1 <= num2 && num1 <= num3)
            menor = num1;
        else if (num2 <= num1 && num2 <= num3)
            menor = num2;
        else
            menor = num3;

        Console.WriteLine("O maior número é: " + maior);
        Console.WriteLine("O menor número é: " + menor);
    }

    static void Lista2_Atividade3()
    {
        // ---------------------- Atividade 3 ----------------------
        // Verifica se o ano é bissexto
        int ano;
        Console.WriteLine("Digite um ano:");
        ano = int.Parse(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            Console.WriteLine("O ano é bissexto");
        else
            Console.WriteLine("O ano não é bissexto");
    }

    static void Lista2_Atividade4()
    {
        // ---------------------- Atividade 4 ----------------------
        // Classifica idade em categorias
        int idade;
        Console.WriteLine("Digite a idade:");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 0 && idade <= 12)
            Console.WriteLine("A categoria da idade é criança");
        else if (idade <= 17)
            Console.WriteLine("A categoria da idade é adolescente");
        else if (idade <= 64)
            Console.WriteLine("A categoria da idade é adulto");
        else if (idade > 64)
            Console.WriteLine("A categoria da idade é idoso");
        else
            Console.WriteLine("Não é possível calcular");
    }

    static void Lista2_Atividade5()
    {
        // ---------------------- Atividade 5 ----------------------
        // Calculadora simples com switch
        double num1, num2, resultado;
        Console.WriteLine("Digite dois números:");
        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("Soma: 1");
        Console.WriteLine("Subtração: 2");
        Console.WriteLine("Multiplicação: 3");
        Console.WriteLine("Divisão: 4");

        string operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1":
                resultado = num1 + num2;
                Console.WriteLine($"O resultado da soma de {num1} e {num2} é: {resultado}");
                break;
            case "2":
                resultado = num1 - num2;
                Console.WriteLine($"O resultado da subtração de {num1} e {num2} é: {resultado}");
                break;
            case "3":
                resultado = num1 * num2;
                Console.WriteLine($"O resultado da multiplicação de {num1} por {num2} é: {resultado}");
                break;
            case "4":
                if (num2 == 0)
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado da divisão de {num1} por {num2} é: {resultado}");
                }
                break;
            default:
                Console.WriteLine("Operação inválida! Por favor, escolha uma operação válida (1-4).");
                break;
        }
    }

    static void Lista2_Atividade6()
    {
        // ---------------------- Atividade 6 ----------------------
        // Calcula média e define aprovação do aluno
        double nota1, nota2, nota3, media;

        Console.WriteLine("Digite o nome do aluno:");
        string aluno = Console.ReadLine();

        Console.WriteLine("Digite a primeira nota do aluno:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota do aluno:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota do aluno:");
        nota3 = double.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
            Console.WriteLine($"Com média {media:F2}, o aluno {aluno} foi aprovado!");
        else if (media >= 5)
            Console.WriteLine($"Com média {media:F2}, o aluno {aluno} está de recuperação!");
        else
            Console.WriteLine($"Com média {media:F2}, o aluno {aluno} está reprovado!");
    }

    static void Lista2_Atividade7()
    {
        // ---------------------- Atividade 7 ----------------------
        // Classifica temperatura em graus Celsius
        double C, F;
        Console.WriteLine("Digite a temperatura em graus Celsius:");
        C = double.Parse(Console.ReadLine());

        F = C * 1.8 + 32;

        if (C < 0)
            Console.WriteLine("Muito frio");
        else if (C <= 30)
            Console.WriteLine("Clima agradável");
        else
            Console.WriteLine("Muito quente");
    }

    static void Lista2_Atividade8()
    {
        // ---------------------- Atividade 8 ----------------------
        // Calcula salário líquido baseado nas horas e salário por hora
        double horas, salarioPorHora, salarioBruto, salarioLiquido;

        Console.WriteLine("Digite a quantidade de horas trabalhadas:");
        horas = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do salário por hora trabalhada:");
        salarioPorHora = double.Parse(Console.ReadLine());

        salarioBruto = horas * salarioPorHora;

        if (salarioBruto <= 900.00)
            salarioLiquido = salarioBruto * (1 - 0.08);
        else if (salarioBruto <= 1500.00)
            salarioLiquido = salarioBruto * (1 - 0.09);
        else if (salarioBruto <= 2500.00)
            salarioLiquido = salarioBruto * (1 - 0.10);
        else
            salarioLiquido = salarioBruto * (1 - 0.11);

        Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
        Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");
    }

    static void Lista2_Atividade9()
    {
        // ---------------------- Atividade 9 ----------------------
        // Imprime o dia da semana de acordo com número
        int num;
        Console.WriteLine("Digite um número de 1 a 7:");
        num = int.Parse(Console.ReadLine());

        if (num == 1)
            Console.WriteLine("O dia correspondente é Domingo");
        else if (num == 2)
            Console.WriteLine("O dia correspondente é Segunda-Feira");
        else if (num == 3)
            Console.WriteLine("O dia correspondente é Terça-Feira");
        else if (num == 4)
            Console.WriteLine("O dia correspondente é Quarta-Feira");
        else if (num == 5)
            Console.WriteLine("O dia correspondente é Quinta-Feira");
        else if (num == 6)
            Console.WriteLine("O dia correspondente é Sexta-Feira");
        else if (num == 7)
            Console.WriteLine("O dia correspondente é Sábado");
        else
            Console.WriteLine("Número inválido!");
    }

    static void Lista2_Atividade10()
    {
        // ---------------------- Atividade 10 ----------------------
        // Calcula peso ideal baseado na altura e sexo
        double altura, pesoHomem, pesoMulher;

        Console.WriteLine("Digite a altura em metros:");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o sexo:");
        Console.WriteLine("Masculino 1");
        Console.WriteLine("Feminino 2");

        string escolha = Console.ReadLine();

        pesoMulher = (62.1 * altura) - 44.7;
        pesoHomem = (72.7 * altura) - 58;

        switch (escolha)
        {
            case "1":
                Console.WriteLine("O peso ideal para homem é: {0:F2}", pesoHomem);
                break;
            case "2":
                Console.WriteLine("O peso ideal para mulher é: {0:F2}", pesoMulher);
                break;
            default:
                Console.WriteLine("Escolha inválida!");
                break;
        }
    }
}
