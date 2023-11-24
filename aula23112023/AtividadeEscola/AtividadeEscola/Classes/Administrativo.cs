public class Administrativo : Funcionario
    {
    private List<string> setorAdministrativo = new List<string>();
    public Administrativo(string nomeAdministrativo, int idadeAdministrativo, double salarioAdministrativo, string setorAdministrativo)
    {
        base.setNome(nomeAdministrativo);
        base.setIdade(idadeAdministrativo);
        base.setSalario(salarioAdministrativo);
        this.setSetor(setorAdministrativo);
    }
    public void setSetor(string setorAdministrativo)
    {
        this.setorAdministrativo.Add(setorAdministrativo);
    }
    public void getSetor()
    {
        foreach (string setores in setorAdministrativo)
        {
            Console.WriteLine(setores);
        }
    }
    public override void CalcularSalario()
    {
        double salarioAtual = base.getSalario();

        salarioAtual *= 1.05;

        base.setSalario(salarioAtual);
    }
}