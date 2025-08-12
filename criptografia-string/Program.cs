using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string para ser criptografada:");
        string input = Console.ReadLine();

        Criptografar(input);

        Console.WriteLine("Deseja descriptografar uma frase? Digite 1 para sim ou 0 para não: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                {
                    Console.WriteLine("Digite a string criptografada: ");
                    string cripto = Console.ReadLine();
                    Descriptografar(cripto);
                    break;
                }
            case 0: break;

            default: Console.WriteLine("Digite uma opção válida!"); break;
        }
    }

    static string Criptografar(string frase)
    {
        int linhas = (int)Math.Ceiling(frase.Length / 5.0); //
        char[,] matriz = new char[linhas, 5];
        int index = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (index < frase.Length)
                    matriz[i, j] = frase[index];
                else
                    matriz[i, j] = ' ';

                index++;
            }
        }

        string resultado = "";

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < linhas; j++)
            {
                resultado += matriz[j, i];
            }

            resultado += "*";
        }

        Console.WriteLine(resultado);
        return resultado;
    }

    static void Descriptografar(string cripto)
    {
        string colunasFrase = cripto.Split("*", StringSplitOptions.RemoveEmptyEntries); // 
        string resultado = "";
        int colunas = colunasFrase.Length;
        int linhas = colunasFrase[0].Length; // 
        char[,] matriz = new char[linhas, colunas];

        for (int i = 0; i < colunas; i++)
            for (int j = 0; j < linhas; j++)
                matriz[j, i] = colunasFrase[i][j]; // Jagged Array (Array irregular): É um array de arrays. As linhas e colunas podem ter tamanhos variáveis.   

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado += matriz[i, j];
            }
        }

        Console.WriteLine(resultado);
    }
}