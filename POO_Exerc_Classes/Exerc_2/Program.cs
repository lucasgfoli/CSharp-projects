using System;
class Calculadora
{
    int _numero1;
    int _numero2;

    public Calculadora(int numero1, int numero2)
    {
        _numero1 = numero1;
        _numero2 = numero2;
    }

    public int Somar()
    {
        return _numero1 + _numero2;
    }

    public int Subtrair()
    {
        return _numero1 - _numero2;
    }

    public int Multiplicar()
    {
        return _numero1 * _numero2;
    }

    public double Dividir()
    {
        if (_numero2 == 0)
        {
            Console.WriteLine("Não é possível dividir por 0");
            return double.NaN; // Not a number
        }

        return (double)_numero1 / _numero2;

    }

}