public class Emprestimo
{
    private Usuario? usuario_emprestimo;
    private Livro? livro;
    private Revista? revista;
    private DateTime dia_emprestimo, dia_devolucao;

    public void setUsuario_Emprestimo(Usuario? usuario) { this.usuario_emprestimo = usuario; }
    public Usuario? getUsuario_Emprestimo() { return this.usuario_emprestimo; }
    public void setLivro_Revista_Emprestimo(Livro? livro_emprestimo) { this.livro = livro_emprestimo; }
    public void setLivro_Revista_Emprestimo(Revista? revista_emprestimo) { this.revista = revista_emprestimo; }
    public Livro? getLivro_Emprestimo() { return this.livro; }
    public Revista? getRevista_Emprestimo() { return this.revista; }
    public void setData_Emprestimo(int dia) { this.dia_emprestimo = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia); }
    public DateTime getData_Emprestimo() { return this.dia_emprestimo; }
    public void setData_Devolucao(int dia) 
    { 
        this.dia_devolucao = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia); 
    }
    public DateTime getData_Devolucao() { return this.dia_devolucao; }
    public void Registrar_Devolucao(int dia)
    {
        DateTime dia_presente = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dia);
        TimeSpan diferenca;
        int atraso;
        if (dia_presente>dia_devolucao)
        {
            diferenca = dia_presente - dia_devolucao;
            atraso = (diferenca.Days * 20) + diferenca.Hours;
            Console.WriteLine($"você está sucetivel a multa por atraso de {atraso} horas");
        }

        this.setData_Devolucao(dia);
    }


}