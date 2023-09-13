public class Gabarito
{
    List<char> alternativa = new List<char>();

    public Gabarito()
    {
        //Console.WriteLine("======== GABARITO ========");
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"Digite qual alternativa correta para a {i + 1}ª Questão (A, B, C, D, E): ");
        //    char resp = Convert.ToChar(Console.ReadLine().ToUpper());
        //    alternativa.Add(resp);
        //}
        //Console.WriteLine("==========================\n");
        alternativa.Add('A');
        alternativa.Add('B');
        alternativa.Add('C');
        alternativa.Add('D');
        alternativa.Add('E');
    }
    public char RespostaQuestao(int numeroQuestao)
    {
        return alternativa[numeroQuestao];
    }
}