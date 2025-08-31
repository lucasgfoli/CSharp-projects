using System;

class Carro
{
    string _placa;
    int _velocidadeAtual = 0;
    int _velocidadeMaxima = 120;

    public Carro(string placa)
    {
        _placa = placa;
    }

    public void Acelerar(int velocidade)
    {
        if ((_velocidadeAtual + velocidade) <= _velocidadeMaxima)
            _velocidadeAtual += velocidade;
        else
        {
            Console.WriteLine("Velocidade máxima atingida.");
            _velocidadeAtual = _velocidadeMaxima;
        }
    }

    public void Frear(int velocidade)
    {
        if ((_velocidadeAtual - velocidade) >= 0)
            _velocidadeAtual -= velocidade;
        else
        {
            Console.WriteLine("O carro já está parado");
            _velocidadeAtual = 0;
        }

    }

    public void ExibirVelocidade()
    {
        Console.WriteLine("{0}: {1}", _placa, _velocidadeAtual);
    }
}