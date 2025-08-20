using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite qual");
    }
}

class Cardapio
{
    int _numeroPrato;
    int _nota;

    static string ApresentarPratos()
    {
        int prato1 = 0, prato2 = 0, prato3 = 0, prato4 = 4;
        int notaPrato1 = 0, notaPrato2 = 0, notaPrato3 = 0, notaPrato4 = 0, nota5 = 0;

        Console.WriteLine("Segue as opções de pratos: /n 1. Moqueca de Palmito. /n 2. Falafel Assado. /n 3. Salada Primavera com Macarrão Konjac. /n 4. Escondidinho de Inhame e Strogonoff de Cogumelos.");
        Console.WriteLine("Escolha uma das opções acima: ");
        int opcao = Console.ReadLine();

        if (opcao < 1 && opcao > 4)
            return Console.WriteLine("Digite uma opção de 1 a 4.");

        switch (opcao)
        {
            case 1:
                {
                    prato1++;
                    Console.WriteLine("Qual sua avaliação para o prato? de 0 a 5");
                    notaPrato1 += int.Parse(Console.ReadLine());
                    if (notaPrato1 = 5) nota5++;
                    break;
                }
            case 2:
                {
                    prato2++;
                    Console.WriteLine("Qual sua avaliação para o prato? de 0 a 5");
                    notaPrato2 += int.Parse(Console.ReadLine());
                    if (notaPrato2 = 5) nota5++;
                    break;
                }
            case 3:
                {
                    prato3++;
                    Console.WriteLine("Qual sua avaliação para o prato? de 0 a 5");
                    notaPrato3 += int.Parse(Console.ReadLine());
                    if (notaPrato3 = 5) nota5++;
                    break;
                }
            case 4:
                {
                    prato4++;
                    Console.WriteLine("Qual sua avaliação para o prato? de 0 a 5");
                    notaPrato4 += int.Parse(Console.ReadLine());
                    if (notaPrato4 = 5) nota5++;
                }

            case default:
                Console.WriteLine("Digite uma opção de 1 a 4");
                break;
        }


    }

    static


}
// Implemente um programa Java que permita a cada cliente indicar qual prato consumiu e atribuir uma 
// nota a este prato. Um número indeterminado de clientes irá fazer as avaliações, até que se indique que o 
// programa finalize a leitura de avaliações. Então, o programa deve responder qual foi o prato mais consumido, o 
// prato com a maior nota média, a nota média de cada prato, o prato com a maior quantidade de notas 5 e a nota 
// média de todos os pratos consumidos no restaurante 