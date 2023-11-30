public abstract class Funcionario
{
    private string _nome { get; set; };
    private int _idade;
    private double _salario;

    public void setNome(string nomeFuncionario)
    {
        this._nome = nomeFuncionario;
    }
    public string getNome()
    {
        return this._nome;
    }
    public void setIdade(int idadeFuncionario)
    {
        this._idade = idadeFuncionario;
    }
    public int getIdade()
    {
        return this._idade;
    }public void setSalario(double salarioFuncionario)
    {
        this._salario = salarioFuncionario;
    }
    public double getSalario()
    {
        return this._salario;
    }
    public abstract void CalcularSalario();
}