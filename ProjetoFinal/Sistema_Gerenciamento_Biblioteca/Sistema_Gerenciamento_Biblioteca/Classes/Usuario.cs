public class Usuario
{
    // Definindo campos privados para armazenar informações do usuário
    private string _nome;
    private int _idade, _idu;

    // Construtor da classe Usuario que recebe informações iniciais do usuário
    public Usuario(int idUsuario, string nomeUsuario, int anoNascimentoUsuario)
    {
        // Chamando métodos para configurar as propriedades do usuário com os valores fornecidos
        this.setIdUsuario(idUsuario);
        this.setNomeUsuario(nomeUsuario);
        this.setIdadeUsuario(anoNascimentoUsuario);
    }

    // Método para configurar o ID do usuário
    public void setIdUsuario(int numeroUnico) { this._idu = numeroUnico; }

    // Método para obter o ID do usuário
    public int getIdUsuario() { return this._idu; }

    // Método para configurar o nome do usuário
    public void setNomeUsuario(string nickUsuario) { this._nome = nickUsuario; }

    // Método para obter o nome do usuário
    public string getNomeUsuario() { return this._nome; }

    // Método para configurar a idade do usuário com base no ano de nascimento
    public void setIdadeUsuario(int anoNascimento)
    {
        // Calculando a idade subtraindo o ano de nascimento do ano atual
        int idade = DateTime.Now.Year - anoNascimento;
        // Atribuindo a idade ao campo privado _idade
        this._idade = idade;
    }

    // Método para obter a idade do usuário
    public int getIdadeUsuario() { return this._idade; }
}
