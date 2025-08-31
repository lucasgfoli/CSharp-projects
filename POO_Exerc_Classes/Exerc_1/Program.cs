/// <summary>
///  Classe Conta Bancária - É identificada pelo seu número de 5 dígitos e pelo CPF de seu proprietário. Permite realizar operações de Saque e Depósito.
///  É possível realizar um saque do saldo ou com valor mais alto que o saldo utilizando limite, será cobrado 3% de taxa nesse caso.
/// </summary>
class Conta
{
    private string _codigo;
    private string _CPF;
    private double _limite;
    private double _saldo;
    private double _taxa = 0.03;

    #region Construtor
    /// <summary>
    /// Construtor da Classe conta com valores válidos. Caso o Código ou CPF seja inválido o valor das variáveis será completo por 0.
    /// </summary>
    /// <param name="codigo">String de 5 dígitos.</param>
    /// <param name="CPF">String de 11 dígitos.</param>
    /// <param name="limite">Valor do limite, será usado caso o valor de saque seja maior que o saldo.</param>
    /// <param name="saldo">Valor do saldo da conta, será usado para realizar saques</param>
    public Conta(string codigo, string CPF, double limite, double saldo)
    {
        if (ValidarCodigo(codigo))
        {
            _codigo = codigo;
        }
        else
        {
            _codigo = "00000";
        }

        if (ValidarCPF(CPF))
        {
            _CPF = CPF;
        }
        else
        {
            _CPF = "00000000000";
        }

        _limite = limite;
        _saldo = saldo;
    }
    #endregion

    #region Saque
    /// <summary>
    /// Realiza o saque e atualiza o saldo da conta. Será utilizado o saldo ou saldo + limite caso o valor seja maior que o saldo disponível.
    /// Caso não seja possível, retorna false e o valor do saldo não é alterado.
    /// </summary>
    /// <param name="valor">Double com o valor que será sacado da conta.</param>
    /// <returns></returns>
    public bool Sacar(double valor)
    {
        if (valor <= (_saldo + _limite))
        {
            _saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine($"Não é possível sacar esse valor");
            return false;
        }
    }
    #endregion

    #region Deposito
    /// <summary>
    /// Realiza o depósito da conta e atualiza o saldo com o valor fornecido.
    /// Caso o saldo esteja negativo, será cobrada uma taxa de 3% sobre esse valor, descontada do depósito.
    /// </summary>
    /// <param name="valor">Double com o valor que será depositado na conta.</param>
    /// <returns></returns>
    public double Depositar(double valor)
    {
        if (_saldo < 0)
        {
            double taxa = _saldo * (-_taxa);
            valor -= taxa;
        }

        return _saldo += valor;
    }
    #endregion

    #region Consultas
    /// <summary>
    /// Retorna o saldo da conta.
    /// </summary>
    /// <returns></returns>
    public double ConsultarSaldo()
    {
        return _saldo;
    }

    /// <summary>
    /// Retorna o limite da conta.
    /// </summary>
    /// <returns></returns>
    public double ConsultarLimite()
    {
        return _limite;
    }
    #endregion

    #region Validações
    /// <summary>
    /// Valida se o código é válido: Deve conter 5 dígitos.
    /// </summary>
    /// <param name="codigo">String com o valor do código da conta.</param>
    /// <returns></returns>
    private bool ValidarCodigo(string codigo)
    {
        if (codigo.Length == 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Valida se o CPF é válido: Deve conter 11 dígitos.
    /// </summary>
    /// <param name="CPF">String com o valor do CPF do proprietário da conta</param>
    /// <returns></returns>
    private bool ValidarCPF(string CPF)
    {
        if (CPF.Length == 11)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion
}

/// <summary>
/// Classe com o Main para realizar testes.
/// </summary>
class Program
{

    /// <summary>
    /// Programa de teste para as operações principais
    /// </summary>
    static void Main()
    {
        Conta conta = new Conta("12345", "12345678900", 100, 200);

        Console.WriteLine($"Saldo inicial: {conta.ConsultarSaldo()} \n Limite atual: {conta.ConsultarLimite()}");

        if (conta.Sacar(250))
        {
            Console.WriteLine($"Saque no valor de 250 realizado! Saldo atual: {conta.ConsultarSaldo()}");
        }
        else
        {
            Console.WriteLine("Saque não realizado! Valor maior que saldo + limite.");
        }

        conta.Depositar(200);
        Console.WriteLine($"Depósito de {200} realizado!. Saldo Atual: {conta.ConsultarSaldo()}");
    }
}
