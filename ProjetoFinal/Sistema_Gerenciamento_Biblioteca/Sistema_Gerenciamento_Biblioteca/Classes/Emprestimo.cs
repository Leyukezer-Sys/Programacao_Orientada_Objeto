// Definindo a classe 'Emprestimo'
public class Emprestimo
{
    // Campos privados para armazenar informações sobre o empréstimo
    private Usuario? usuario_emprestimo;
    private Livro? livro;
    private Revista? revista;
    private DateTime dia_emprestimo, dia_devolucao;

    // Método para configurar o usuário do empréstimo
    public void setUsuario_Emprestimo(Usuario? usuario) { this.usuario_emprestimo = usuario; }

    // Método para obter o usuário do empréstimo
    public Usuario? getUsuario_Emprestimo() { return this.usuario_emprestimo; }

    // Método para configurar o livro do empréstimo
    public void setLivro_Revista_Emprestimo(Livro? livro_emprestimo) { this.livro = livro_emprestimo; }

    // Método para configurar a revista do empréstimo
    public void setLivro_Revista_Emprestimo(Revista? revista_emprestimo) { this.revista = revista_emprestimo; }

    // Método para obter o livro do empréstimo
    public Livro? getLivro_Emprestimo() { return this.livro; }

    // Método para obter a revista do empréstimo
    public Revista? getRevista_Emprestimo() { return this.revista; }

    // Método para configurar a data de empréstimo com base no dia fornecido
    public void setData_Emprestimo(int dia) { this.dia_emprestimo = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia); }

    // Método para obter a data de empréstimo
    public DateTime getData_Emprestimo() { return this.dia_emprestimo; }

    // Método para configurar a data de devolução com base no dia fornecido
    public void setData_Devolucao(int dia) { this.dia_devolucao = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia); }

    // Método para obter a data de devolução
    public DateTime getData_Devolucao() { return this.dia_devolucao; }

    // Método para registrar a devolução e verificar se houve atraso
    public void Registrar_Devolucao(int dia)
    {
        // Criando um objeto DateTime representando o dia atual
        DateTime dia_presente = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia);

        // Verificando se a devolução está atrasada
        if (dia_presente > dia_devolucao)
        {
            // Calculando a diferença de tempo entre a devolução e o dia atual
            TimeSpan diferenca = dia_presente - dia_devolucao;

            // Calculando a multa com base no atraso (Convertendo os dias em horas de atraso, com base no funcionamento de uma biblioteca(4 horas de manha, 4 horas de tarde, 4 horas de noite))
            int atraso = (diferenca.Days * 12) + diferenca.Hours;

            // Exibindo mensagem sobre a multa por atraso
            Console.WriteLine($"Você está sujeito a multa por atraso de {atraso} horas.");
        }

        // Atualizando a data de devolução
        this.setData_Devolucao(dia);
    }
}
