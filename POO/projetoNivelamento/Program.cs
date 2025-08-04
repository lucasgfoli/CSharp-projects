using System;
class projetoNivelamento
{
    static void Main()
    {
        NivelamentoHelper.Executar();
    }
}

public static class NivelamentoHelper
{
    public static void Executar()
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
            ExibirResultados(count, soma, media, menor, maior);
        }

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
