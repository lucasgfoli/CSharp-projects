using System;

class Lista1
{
    static void Main(string[] args)
    {
        // Chamando as atividades para testar:
        Lista1_Atividade1();
        Lista1_Atividade2();
        Lista1_Atividade3();
        Lista1_Atividade4();
        Lista1_Atividade5();
        Lista1_Atividade6();
        Lista1_Atividade7();
        Lista1_Atividade8();
        Lista1_Atividade9();
        Lista1_Atividade10();
    }

    static void Lista1_Atividade1()
    {
        double nota1, nota2, media;
        int peso1 = 2, peso2 = 3;

        Console.WriteLine("Digite a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());

        media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

        Console.WriteLine("A média ponderada das notas é: {0:F2}", media);
    }

    static void Lista1_Atividade2()
    {
        double precoProduto, precoComDesconto;

        Console.WriteLine("Digite o preço do produto: ");
        precoProduto = double.Parse(Console.ReadLine());

        precoComDesconto = precoProduto * 0.90;

        Console.WriteLine("O novo preço do produto com 10% de desconto é: {0:C2}", precoComDesconto);
    }

    static void Lista1_Atividade3()
    {
        double baseMaior, baseMenor, altura, area;

        Console.WriteLine("Digite o valor da base maior do trapézio: ");
        baseMaior = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da base menor do trapézio: ");
        baseMenor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do trapézio: ");
        altura = double.Parse(Console.ReadLine());

        area = ((baseMaior + baseMenor) * altura) / 2;

        Console.WriteLine("A área do trapézio é: {0:F2}", area);
    }

    static void Lista1_Atividade4()
    {
        double salarioMin, salarioFun, salario;

        Console.WriteLine("Digite o valor do salário mínimo atual: ");
        salarioMin = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do salário do funcionário: ");
        salarioFun = double.Parse(Console.ReadLine());

        salario = salarioFun / salarioMin;

        Console.WriteLine("O funcionário recebe {0:F2} salários mínimos.", salario);
    }

    static void Lista1_Atividade5()
    {
        double raio, comprimento, area, volume;

        Console.WriteLine("Digite o raio");
        raio = double.Parse(Console.ReadLine());

        comprimento = 2 * Math.PI * raio;
        area = Math.PI * Math.Pow(raio, 2);
        volume = (4.0 / 3) * Math.PI * Math.Pow(raio, 3);

        Console.WriteLine("O valor do comprimento da esfera é: {0:F2} \nO valor da área da esfera é de: {1:F2} \nO valor do volume da esfera é de: {2:F2}", comprimento, area, volume);
    }

    static void Lista1_Atividade6()
    {
        double angulo1, angulo2, angulo3;

        Console.WriteLine("Digite a medida de dois ângulos do triângulo: ");
        angulo1 = double.Parse(Console.ReadLine());
        angulo2 = double.Parse(Console.ReadLine());

        angulo3 = 180 - (angulo1 + angulo2);

        Console.WriteLine("O valor do terceiro ângulo é: {0:F2}", angulo3);
    }

    static void Lista1_Atividade7()
    {
        double a, b, c, delta, raizX1, raizX2;

        Console.WriteLine("Digite os coeficientes a, b e c, respectivamente: ");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        delta = Math.Pow(b, 2) - 4 * a * c;

        if(delta < 0)
        {
            Console.WriteLine("A equação não possui raízes reais.");
            return;
        }

        raizX1 = (-b + Math.Sqrt(delta)) / (2 * a);
        raizX2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("As raízes da equação são: X1 = {0:F2} e X2 = {1:F2}", raizX1, raizX2);
    }

    static void Lista1_Atividade8()
    {
        int salario, nota200, nota100, nota50, nota20, nota10, nota5, nota2, nota1;

        Console.WriteLine("Digite o valor do salário a ser pago: ");
        salario = int.Parse(Console.ReadLine());

        nota200 = salario / 200; salario %= 200;
        nota100 = salario / 100; salario %= 100;
        nota50 = salario / 50; salario %= 50;
        nota20 = salario / 20; salario %= 20;
        nota10 = salario / 10; salario %= 10;
        nota5 = salario / 5; salario %= 5;
        nota2 = salario / 2; salario %= 2;
        nota1 = salario / 1; salario %= 1;

        Console.WriteLine("Quantidade mínima de notas para pagar o salário:");
        Console.WriteLine("{0} nota(s) de R$ 200", nota200);
        Console.WriteLine("{0} nota(s) de R$ 100", nota100);
        Console.WriteLine("{0} nota(s) de R$ 50", nota50);
        Console.WriteLine("{0} nota(s) de R$ 20", nota20);
        Console.WriteLine("{0} nota(s) de R$ 10", nota10);
        Console.WriteLine("{0} nota(s) de R$ 5", nota5);
        Console.WriteLine("{0} nota(s) de R$ 2", nota2);
        Console.WriteLine("{0} nota(s) de R$ 1", nota1);
    }

    static void Lista1_Atividade9()
    {
        int hora, minuto, segundo, resultado;

        Console.WriteLine("Digite as horas, minutos e segundos atuais: ");
        hora = int.Parse(Console.ReadLine());
        minuto = int.Parse(Console.ReadLine());
        segundo = int.Parse(Console.ReadLine());

        resultado = (hora * 3600) + (minuto * 60) + segundo;

        Console.WriteLine("Decorreram {0} segundos durante o dia de hoje", resultado);
    }

    static void Lista1_Atividade10()
    {
        int hora, minuto, segundo;

        Console.WriteLine("Digite os segundos decorridos: ");
        segundo = int.Parse(Console.ReadLine());

        hora = segundo / 3600;
        minuto = (segundo % 3600) / 60;
        segundo = segundo % 60;

        Console.WriteLine("São {0} horas {1} minutos e {2} segundos", hora, minuto, segundo);
    }
}
