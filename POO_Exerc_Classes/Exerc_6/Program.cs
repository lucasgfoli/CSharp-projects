using System;

class Data
{
    int _dia;
    int _mes;
    int _ano;

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

    public int DiferencaEmDias(Data outraData)
    {
        int diasData1 = this.numeroDeDias();
        int diasData2 = outraData.numeroDeDias();

        return Math.Abs(diasData1 - diasData2);
    }

    private int DiasNoMes(int mes, int ano)
    {
        switch (mes)
        {
            case 2: return EhBissexto(ano) ? 29 : 28;
            case 4: case 6: case 9: case 11: return 30;
            default: return 31;
        }
    }

    private static bool EhBissexto(int ano) // static é usado quando não pertence à classe e não ao objeto, por não usar atributos do objeto.
    {
        return (ano % 400 == 0) || ano % 4 == 0 && ano % 100 != 0;
    }

    private int ConverterDataEmNumero()
    {
        return (_ano * 1000) + (_mes * 100) + _dia;
    }

    private int numeroDeDias()
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
