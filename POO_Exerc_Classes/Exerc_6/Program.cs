using System;

class Data
{
    int _dia;
    int _mes;
    int _ano;

    /// <summary>
    /// Construtor simples, cria datas válidas.
    /// </summary>
    /// <param name="dia">Inteiro com o número do dia</param>
    /// <param name="mes">Inteiro com o número do mês</param>
    /// <param name="ano">Inteiro com o número do ano</param>
    public Data(int dia, int mes, int ano)
    {
        if (dia <= 31 && dia >= 1 && mes <= 12 && mes >= 1 && ano > 0)
        {
            _dia = dia;
            _mes = mes;
            _ano = ano;
        }
        else
        {
            _dia = 1;
            _mes = 1;
            _ano = 1;
            Console.WriteLine("Valores inválidos! O dia deve estar entre 1 e 32, mês entre 1 e 12 e ano deve ser maior que 0");
        }
    }


    /// <summary>
    /// Somar dias à uma data.
    /// </summary>
    /// <param name="dias">Inteiro com o número de dias que serão adicionados à data.</param>
    /// <returns>Uma nova data com base nos dias somados.</returns>
    public Data SomarDias(int dias)
    {
        int novoDia = _dia + dias;
        int novoMes = _mes;
        int novoAno = _ano;

        while (novoDia > DiasNoMes(novoMes, novoAno))
        {
            novoDia -= DiasNoMes(novoMes, novoAno);
            novoMes++;

            if (novoMes > 12)
            {
                novoMes = 1;
                novoAno++;
            }
        }

        return new Data(novoDia, novoMes, novoAno);
    }


    /// <summary>
    /// Compara duas datas para verificar qual é maior.
    /// </summary>
    /// <param name="outraData">Data para comparação</param>
    /// <returns>Inteiro com valor 1 se a data atual for maior, -1 se a data passada for maior e 0 se as datas forem iguais.</returns>
    public int CompararDatas(Data outraData)
    {
        if (_ano > outraData._ano) return 1;
        if (_ano < outraData._ano) return -1;

        if (_mes > outraData._mes) return 1;
        if (_mes < outraData._mes) return -1;

        if (_dia > outraData._dia) return 1;
        if (_dia < outraData._dia) return -1;

        return 0;
    }


    /// <summary>
    /// Calcula a diferença em dias entre duas datas.
    /// </summary>
    /// <param name="outraData">Data para cálculo da diferença em dias.</param>
    /// <returns>Inteiro com o número de dias de diferença entre uma data e outra.</returns>
    public int DiferencaEmDias(Data outraData)
    {
        int diasData1 = NumeroDeDias();
        int diasData2 = outraData.NumeroDeDias();

        return Math.Abs(diasData1 - diasData2);
    }

    /// <summary>
    /// Calcula o número de dias no mês.
    /// </summary>
    /// <param name="mes">Inteiro com o número referente ao mês.</param>
    /// <param name="ano">Inteiro com número referente ao ano.</param>
    /// <returns>O número de dias do mês com base no ano.</returns>
    private static int DiasNoMes(int mes, int ano)
    {
        switch (mes)
        {
            case 2: return EhBissexto(ano) ? 29 : 28;
            case 4: case 6: case 9: case 11: return 30;
            default: return 31;
        }
    }


    /// <summary>
    /// Verifica se um ano é bissexto.
    /// </summary>
    /// <param name="ano">Inteiro com número referente ao ano.</param>
    /// <returns>True se for bissexto e false se não for.</returns>
    private static bool EhBissexto(int ano) // static é usado quando não pertence à classe e não ao objeto, por não usar atributos do objeto.
    {
        return (ano % 400 == 0) || ano % 4 == 0 && ano % 100 != 0;
    }


    /// <summary>
    /// Converte uma data em número.
    /// </summary>
    /// <returns>Um número, calculado a partir de uma data.</returns>
    private int ConverterDataEmNumero()
    {
        return (_ano * 1000) + (_mes * 100) + _dia;
    }


    /// <summary>
    /// Calcula o número de dias de uma data.
    /// </summary>
    /// <returns>Inteiro com o número de dias de uma data.</returns>
    private int NumeroDeDias()
    {
        int totalDias = 0;

        for (int i = 1; i < _ano; i++)
        {
            totalDias += EhBissexto(i) ? 366 : 365;
        }

        for (int i = 1; i < _mes; i++)
        {
            totalDias += DiasNoMes(i, _ano);
        }

        return totalDias += _dia;
    }


    /// <summary>
    /// Imprime a data formatada.
    /// </summary>
    /// <returns>String com a data formatada.</returns>
    public string ExibirData()
    {
        return $"{_dia:D2}/{_mes:D2}/{_ano:D4}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Data d1 = new Data(27, 2, 2024);
        Data d2 = d1.SomarDias(5);
        Console.WriteLine(d2.ExibirData());
    }
}
