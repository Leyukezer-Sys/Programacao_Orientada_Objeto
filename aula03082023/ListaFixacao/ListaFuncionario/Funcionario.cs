using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncionario
{
    public class Funcionario
    {
        public int matricula;
        public string nome, cpf;
        public double salario;
        public DateOnly dataNasc;

        public Funcionario(int matricula, string nome, string cpf, double salario, DateOnly dataNasc)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
            this.dataNasc = dataNasc;
        }
    }
}
