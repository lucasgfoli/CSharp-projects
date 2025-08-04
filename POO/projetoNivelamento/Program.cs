using System;
class projetoNivelamento
{

    static void Main()
    {
        EsquentaBraço();
    }

    static void EsquentaBraço()
    {


        int valor;
        int count = 0;
        int soma = 0;
        int menor = int.MaxValue;
        int maior = int.MinValue;

        Console.WriteLine("Digite um número inteiro, digite um número negativo para parar.");
        valor = int.Parse(Console.ReadLine());

        while (valor >= 0)
        {

            count++;
            soma += valor;
            if (valor < menor)
                menor = valor;
            if (valor > maior)
                maior = valor;

            Console.WriteLine("Digite um número inteiro, digite um número negativo para parar.");
            valor = int.Parse(Console.ReadLine());
        }
        if (count > 0)
        {
            double media = (double)soma / count;

            Console.WriteLine($"O contador de números válidos é: {count}.\n A soma dos valores válidos é: {soma}.\n A média dos valores válidos é: {media}.\n O menor valor é {menor} e o maior é {maior}");
        }
    }
}