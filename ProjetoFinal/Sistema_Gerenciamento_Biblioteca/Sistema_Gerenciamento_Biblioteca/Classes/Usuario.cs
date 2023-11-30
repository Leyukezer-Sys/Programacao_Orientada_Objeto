public class Usuario
{
    private string _nome;
    private int _idade, _idu;

    public Usuario(int idUsuario, string nomeUsuario, int anoNascimentoUsuario)
    {
        this.setIdUsuario(idUsuario);
        this.setNomeUsuario(nomeUsuario);
        this.setIdadeUsuario(anoNascimentoUsuario);

    }
    public void setIdUsuario(int numeroUnico) { this._idu = numeroUnico; }
    public int getIdUsuario() { return this._idu; }
    public void setNomeUsuario(string nickUsuario) { this._nome = nickUsuario; }
    public string getNomeUsuario() { return this._nome; }
    public void setIdadeUsuario(int anoNascimento)
    {
        int idade = DateTime.Now.Year - anoNascimento;
        this._idade = idade;
    }
    public int getIdadeUsuario() { return this._idade; }
}