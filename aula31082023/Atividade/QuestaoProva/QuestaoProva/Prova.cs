public class Prova
{
    Gabarito gabarito;
    int acertos = 0;
    int notaAluno = 0;
    public string nomeAluno;
    List<char> alternativasAluno = new List<char>();
    public Prova maior;

    public Prova(string nome, int quantQuestoes)
    {
        gabarito = new Gabarito(quantQuestoes);
        this.nomeAluno = nome;
    }
    public Prova(string nome, Prova provaMaior)
    {
        gabarito = new Gabarito(provaMaior.gabarito.getGabarito());
        this.nomeAluno = nome;
        this.maior = provaMaior;
    }
    public void RespostaAluno(char resposta)
    {
        alternativasAluno.Add(resposta);
    }
    public int Acertos()
    {
        for (int i = 0; i < this.gabarito.getGabarito().Count; i++)
        {
            if (gabarito.RespostaQuestao(i) == alternativasAluno[i])
            {
                acertos++;
            }
        }
        return acertos;
    }
    public int Nota(int nota)
    {
        notaAluno = acertos * (nota/this.gabarito.getGabarito().Count);

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