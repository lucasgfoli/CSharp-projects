using System;
class projetoNivelamento
{
    static void Main()
    {

        while (true)
        {
            Console.WriteLine("Digite uma opção: 'calcular' para iniciar uma sequencia e 'Parar' para sair.");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "calcular":
                    var resultados = NivelamentoHelper.Executar();
                    NivelamentoHelper.ExibirResultados(resultados.count, resultados.soma, resultados.media, resultados.menor, resultados.maior);
                    break;
                case "parar":
                    return;
                default:
                    Console.WriteLine("Digite uma opção válida!");
                    break;
            }

        }

    }
}

public static class NivelamentoHelper
{
    public static (int count, int soma, double media, int menor, int maior) Executar()
    {
        int valor;
        int count = 0;
        int soma = 0;
        int menor = int.MaxValue;
        int maior = int.MinValue;

        Console.WriteLine("Digite um número inteiro, digite um número negativo para parar.");
        valor = Numero();

        while (valor >= 0)
        {
            AtualizarValores(valor, ref count, ref soma, ref menor, ref maior);
            valor = Numero();
        }

        if (count > 0)
        {
            double media = CalcularMedia(soma, count);
            return (count, soma, media, menor, maior);
        }
        else
            return (0, 0, 0, 0, 0);

    }
    public static int Numero()
    {
        Console.WriteLine("Digite um número inteiro, digite um número negativo para parar.");
        return int.Parse(Console.ReadLine());
    }
    public static void AtualizarValores(int valor, ref int count, ref int soma, ref int menor, ref int maior)
    {
        count++;
        soma += valor;
        if (valor < menor)
            menor = valor;
        if (valor > maior)
            maior = valor;
    }

    public static double CalcularMedia(int soma, int count)
    {
        return (double)soma / count;
    }

    public static void ExibirResultados(int count, int soma, double media, int menor, int maior)
    {
        Console.WriteLine($"O contador de números válidos é: {count}.");
        Console.WriteLine($"A soma dos valores válidos é: {soma}.");
        Console.WriteLine($"A média dos valores válidos é: {media}.");
        Console.WriteLine($"O menor valor é {menor} e o maior é {maior}.");
    }



}
