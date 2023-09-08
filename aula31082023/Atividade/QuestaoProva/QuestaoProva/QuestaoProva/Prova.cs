public class Prova
{
    Gabarito gabarito;
    int acertos = 0;
    public int notaAluno = 0;
    public string nomeAluno;
    public List<char> alternativasAluno = new List<char>();
    public Prova maior;

    public Prova(string nome)
    {
        gabarito = new Gabarito();
        this.nomeAluno = nome;
    }
    public void RespostaAluno(char resposta)
    {
        alternativasAluno.Add(resposta);
    }
    public int Acertos()
    {
        for (int i = 0; i < 5; i++)
        {
            if (gabarito.RespostaQuestao(i) == alternativasAluno[i])
            {
                acertos++;
            }
        }

        return acertos;
    }
    public int Nota()
    {
        notaAluno = acertos * 2;

        return notaAluno;
    }
    public void NovoAluno(string nome)
    {
        acertos = 0;
        notaAluno = 0;
        alternativasAluno.Clear();
        nomeAluno = nome;
    }

}
