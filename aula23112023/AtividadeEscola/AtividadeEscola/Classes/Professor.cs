public class Professor : Funcionario
    {
    private List<string> disciplinasLecionadas = new List<string>();
    public Professor(string nomeProfessor, int idadeProfessor, double salarioProfessor, string disciplinaProfesor)
    {
        base.setNome(nomeProfessor);
        base.setIdade(idadeProfessor);
        base.setSalario(salarioProfessor);
        this.setDisciplina(disciplinaProfesor);
    }
    public void setDisciplina(string disciplinaProfessor)
    {
        this.disciplinasLecionadas.Add(disciplinaProfessor);
    }
    public void getDisciplina()
    {
        foreach (string disciplinas in disciplinasLecionadas)
        {
            Console.WriteLine(disciplinas);
        }
    }
    public override void CalcularSalario()
    {
        double salarioAtual = base.getSalario();

        salarioAtual *= 1.1;

        base.setSalario(salarioAtual);
    }
}