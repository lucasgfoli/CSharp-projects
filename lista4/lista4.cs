
// ------------------------ Atividade1.cs ------------------------
public class Atividade1 {

    public static double CalcularPotencia(double baseNum, double expoente){

        double potencia = 1;

        //Cálculo da potência manualmente (sem Math.Pow)
        for(int i = 0; i < expoente; i++)
        {
            potencia *= baseNum;
        }

        //Saída
        return potencia;
    }
}

// ------------------------ Atividade2.cs ------------------------

public class Atividade2 {

    public static double MediaSalario (){

        //Declaração das variáveis
        int N = 0;
        double total = 0;
        double salario;
        int filhos;

        //Entrada de dados 
        Console.WriteLine("Digite o salário ou digite 0 para parar:");
        salario = double.Parse(Console.ReadLine());

        //Cálculo da média
        while(salario != 0){

            Console.WriteLine("Digite o número de filhos:");
            filhos = int.Parse(Console.ReadLine()); // Apenas leitura, sem uso

            total += salario;
            N++;

            //Entrada de dados 
            Console.WriteLine("Digite o salário ou digite 0 para parar:");
            salario = double.Parse(Console.ReadLine());
        }

        //Cálculo da média salarial
        if (N == 0) return 0;
        double media = total / N;

        //Saída
        return media;
    }
}

// ------------------------ Atividade3.cs ------------------------

public class Atividade3
{
    public static void VerificarTriangulo(double X, double Y, double Z)
    {
        //Entrada: Lados do triângulo (X, Y, Z)

        //Verifica se os valores fornecidos podem formar um triângulo
        if (X < (Y + Z) && Y < (X + Z) && Z < (X + Y))
        {
            //Cálculo e verificação do tipo de triângulo
            if (X == Y && Y == Z)
            {
                Console.WriteLine("O triângulo é equilátero");
            }
            else if (X == Y || X == Z || Y == Z)
            {
                Console.WriteLine("O triângulo é isósceles");
            }
            else
            {
                Console.WriteLine("O triângulo é qualquer (escaleno)");
            }
        }
        else
        {
            Console.WriteLine("Os valores fornecidos não formam um triângulo.");
        }
    }
}

// ------------------------ Atividade4.cs ------------------------
public class Atividade4
{
    public static int CalcularMDC(int a, int b)
    {
        //Cálculo do MDC usando algoritmo de Euclides
        while (b != 0)
        {
            int resto = a % b;
            a = b;
            b = resto;
        }

        //Saída
        return a;
    }
}

// ------------------------ Atividade5.cs ------------------------
public class Atividade5
{
    public static bool EhPositivo(int numero)
    {
        //Retorna true se o número for positivo, false caso contrário
        return numero >= 0;
    }
}

// ------------------------ Atividade6.cs ------------------------
public class Atividade6
{
    public static void ReajustarSalario(ref double salario, double indice)
    {
        //Cálculo do novo salário com base no índice de reajuste
        salario = salario + (salario * indice / 100);
    }
}

// ------------------------ Atividade7.cs ------------------------

public class Atividade7
{
    public static double MediaAprovados(int quantidade)
    {
        //Declaração de variáveis
        int contador = 0;
        double soma = 0;

        //Entrada de notas e cálculo da soma das notas dos aprovados
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite a nota do aluno {i + 1}:");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                soma += nota;
                contador++;
            }
        }

        //Cálculo e saída da média
        if (contador == 0)
            return 0;

        return soma / contador;
    }
}

// ------------------------ Atividade8.cs ------------------------

public class Atividade8
{
    public static bool EhPrimo(int numero)
    {
        //Verifica se o número é primo
        if (numero <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        //Retorno
        return true;
    }
}

// ------------------------ Atividade9.cs ------------------------
public class Atividade9
{
    public static void CalcularDuracaoJogo(int horaInicio, int minutoInicio, int horaFim, int minutoFim, 
                                           ref int duracaoHoras, ref int duracaoMinutos)
    {
        //Conversão de hora e minuto para minutos totais
        int totalInicio = horaInicio * 60 + minutoInicio;
        int totalFim = horaFim * 60 + minutoFim;

        //Considera virada de dia
        if (totalFim < totalInicio)
        {
            totalFim += 24 * 60;
        }

        //Cálculo da duração total
        int duracaoTotal = totalFim - totalInicio;

        //Conversão de volta para horas e minutos
        duracaoHoras = duracaoTotal / 60;
        duracaoMinutos = duracaoTotal % 60;
    }
}

// ------------------------ Atividade10.cs ------------------------
public class Atividade10
{
    public static string ObterConceito(double media)
    {
        //Cálculo do conceito com base na média
        if (media < 0 || media > 10)
        {
            return "Nota inválida";
        }
        else if (media <= 4.9)
        {
            return "D";
        }
        else if (media <= 6.9)
        {
            return "C";
        }
        else if (media <= 8.9)
        {
            return "B";
        }
        else
        {
            return "A";
        }
    }
}

// Main
class Lista4
{
    static void Main(string[] args)
    {
        // Atividade 1
        Console.WriteLine("Potência: " + Atividade1.CalcularPotencia(2, 3));

        // Atividade 2
        Console.WriteLine("Média salarial: " + Atividade2.MediaSalario());

        // Atividade 3
        Console.WriteLine("Digite quantos triângulos deseja verificar:");
        int qtdTriangulos = int.Parse(Console.ReadLine());
        for (int i = 0; i < qtdTriangulos; i++)
        {
            Console.WriteLine($"Triângulo {i + 1}:");
            Console.WriteLine("Lado X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado Y:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Lado Z:");
            double z = double.Parse(Console.ReadLine());
            Atividade3.VerificarTriangulo(x, y, z);
        }

        // Atividade 4
        Console.WriteLine("MDC: " + Atividade4.CalcularMDC(48, 18));

        // Atividade 5
        Console.WriteLine("Quantos números deseja verificar se são positivos?");
        int qtdNumeros = int.Parse(Console.ReadLine());
        for (int i = 0; i < qtdNumeros; i++)
        {
            Console.WriteLine($"Digite o número {i + 1}:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(Atividade5.EhPositivo(numero) ? "Positivo" : "Negativo");
        }

        // Atividade 6
        Console.WriteLine("Digite o salário:");
        double salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o índice de reajuste (%):");
        double indice = double.Parse(Console.ReadLine());
        Atividade6.ReajustarSalario(ref salario, indice);
        Console.WriteLine("Novo salário: " + salario);

        // Atividade 7
        Console.WriteLine("Digite o número de alunos:");
        int qtdAlunos = int.Parse(Console.ReadLine());
        double media = Atividade7.MediaAprovados(qtdAlunos);
        Console.WriteLine("Média dos aprovados: " + media);

        // Atividade 8
        Console.WriteLine("Digite um número para verificar se é primo:");
        int numPrimo = int.Parse(Console.ReadLine());
        Console.WriteLine(Atividade8.EhPrimo(numPrimo) ? "É primo" : "Não é primo");

        // Atividade 9
        int durH = 0, durM = 0;
        Console.WriteLine("Digite a hora e minuto de início:");
        int hIni = int.Parse(Console.ReadLine());
        int mIni = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a hora e minuto de término:");
        int hFim = int.Parse(Console.ReadLine());
        int mFim = int.Parse(Console.ReadLine());
        Atividade9.CalcularDuracaoJogo(hIni, mIni, hFim, mFim, ref durH, ref durM);
        Console.WriteLine($"Duração do jogo: {durH}h {durM}min");

        // Atividade 10
        Console.WriteLine("Digite a média final do aluno:");
        double mediaFinal = double.Parse(Console.ReadLine());
        Console.WriteLine("Conceito: " + Atividade10.ObterConceito(mediaFinal));
    }
}
