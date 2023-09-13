public class Prova
{
    Gabarito gabarito;
    int acertos = 0;
    int notaAluno = 0;
    public string nomeAluno;
    List<char> alternativasAluno = new List<char>();
    public Prova maior;

    public Prova(string nome)
    {
        gabarito = new Gabarito();
        this.nomeAluno = nome;
    }
    public Prova(string nome, Prova provaMaior)
    {
        gabarito = new Gabarito();
        this.nomeAluno = nome;
        this.maior = provaMaior;
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
    public void Maior()
    {
        if (notaAluno > maior.notaAluno)
        {
            maior.nomeAluno = nomeAluno;
            maior.notaAluno = notaAluno;
            maior.acertos = acertos;
            maior.alternativasAluno = alternativasAluno;
        }
    }

}
