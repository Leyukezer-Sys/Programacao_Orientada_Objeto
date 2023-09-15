public class Gabarito
{
    List<char> alternativa = new List<char>();

    public Gabarito(int quantQuestao)
    {
        Console.WriteLine("======== GABARITO ========");
        for (int i = 0; i < quantQuestao; i++)
        {
            Console.Write($"Digite qual alternativa correta para a {i + 1}ª Questão (A, B, C, D, E): ");
            char resp = Convert.ToChar(Console.ReadLine().ToUpper());
            alternativa.Add(resp);
        }
        Console.WriteLine("==========================\n");
    }
    public Gabarito(List<char> gabarito)
    {
        this.alternativa = gabarito;
    }
    public char RespostaQuestao(int numeroQuestao)
    {
        return alternativa[numeroQuestao];
    }
    public List<char> getGabarito()
    {
        return alternativa;
    }
}