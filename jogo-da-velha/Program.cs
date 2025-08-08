//Jogo da velha:

class Program
{
    static void Main(string[] args)
    {
        char[,] matriz = new char[3, 3];
        Matriz(matriz);

        int posicaoLinha, posicaoColuna;
        char jogador = 'X';

        while (true)
        {
            ImprimirMatriz(matriz);

            Console.WriteLine("Digite a linha (0, 1 ou 2)");
            posicaoLinha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coluna (0, 1 ou 2)");
            posicaoColuna = int.Parse(Console.ReadLine());

            if (posicaoLinha >= 0 && posicaoLinha <= 2 && posicaoColuna >= 0 && posicaoColuna <= 2 && matriz[posicaoLinha, posicaoColuna] == ' ')
            {
                matriz[posicaoLinha, posicaoColuna] = jogador;

                if (VerificarVitoria(matriz, jogador))
                {
                    ImprimirMatriz(matriz);
                    Console.WriteLine($"O jogador {jogador} venceu!");
                    break;
                }
                else if (VerificarEmpate(matriz))
                {
                    ImprimirMatriz(matriz);
                    Console.WriteLine("Deu velha!");
                    break;
                }

                jogador = (jogador == 'X') ? 'O' : 'X';
            }
            else
                Console.WriteLine("Digite uma posição válida!");
        }
    }

    static void Matriz(char[,] matriz) // Método com matriz já é passada por referência, ou seja, não deve retornar um valor.
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = ' ';
            }
        }
    }

    static void ImprimirMatriz(char[,] matriz)
    {

        Console.WriteLine("   0   1   2   ");
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"  {matriz[i, j]}");

                if (j < 2)
                    Console.Write('|');
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  ---+---+---");
        }
        Console.WriteLine();

    }

    static bool VerificarVitoria(char[,] matriz, char jogador)
    {
        for (int i = 0; i < 3; i++)
            if (matriz[i, 0] == jogador && matriz[i, 1] == jogador && matriz[i, 2] == jogador) return true;

        for (int j = 0; j < 3; j++)
            if (matriz[0, j] == jogador && matriz[1, j] == jogador && matriz[2, j] == jogador) return true;

        if (matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador) return true;
        if (matriz[0, 2] == jogador && matriz[1, 1] == jogador && matriz[2, 0] == jogador) return true;

        return false;
    }

    static bool VerificarEmpate(char[,] matriz)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (matriz[i, j] == ' ') return false;

        return true;
        
    }
}