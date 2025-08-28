using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    int _matricula;
    string _nomeProprio;
    List<double> _notas = new List<double>();
    double _notaFinal;
    double _notaAnterior;

    public Aluno(int matricula, string nomeProprio)
    {
        _matricula = matricula;
        _nomeProprio = nomeProprio;
    }

    public void RegistrarNota(double nota)
    {
        if (nota <= 10 && nota >= 0)
            _notas.Add(nota);
        else
            Console.WriteLine("A nota deve estar entre 0 e 10");
    }

    public string CalcularSituacao()
    {
        if (_notas.Count > 0)
        {
            _notaFinal = _notas.Average();

            if (_notaFinal >= 6)
            {
                return $"Aluno aprovado: {_notaFinal:F2}";
            }
            else if (_notaFinal >= 4)
            {
                return $"Aluno em reavalição: {_notaFinal:F2}";
            }
            else
            {
                return $"Aluno reprovado: {_notaFinal:F2}";
            }
        }
        else
        {
            return "Sem notas para calcular a situação do aluno";
        }

    }

    public string Reavaliar(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            _notaAnterior = _notaFinal;
            _notaFinal = ((double)_notaAnterior + nota) / 2;

            return $"Situação do aluno após reavaliação: {_notaFinal:F2}";
        }
        else
        {
            return "A nota deve estar entre 0 e 10";
        }
    }

    public void ImprimirSituacao()
    {
        Console.WriteLine(CalcularSituacao());
    }
}