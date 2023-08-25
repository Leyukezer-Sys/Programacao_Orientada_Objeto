public class Titular
{
    private string nome, cpf, email;

    public Titular(string nomeCompleto, string cpfTitular, string emailContato)
    {
        setNome(nomeCompleto);
        setCpf(cpfTitular);
        setEmail(emailContato);
    }
    public void setNome(string nome)
    {
        this.nome = nome;
    }
    public void setCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public void setEmail(string email)
    {
        this.email = email;
    }
    public string getNome()
    {
        return this.nome;
    }
    public string getCpf()
    {
        return this.cpf;
    }
    public string getEmail()
    {
        return this.email;
    }
}