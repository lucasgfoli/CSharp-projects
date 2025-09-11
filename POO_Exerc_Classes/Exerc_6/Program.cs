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
        int novoMes = _mes = _mes;
        int novoAno = _mes = _mes;

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

    public string CompararDatas(Data outraData)
    {
        int result;

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
        if (CompararDatas(outraData) == 1)
        {
            
        }
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

    private bool EhBissexto(int ano)
    {
        if (ano % 4 == 0 || ano % 400 == 0)
            return true;
    }
}