using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticos
{
    public static class Validacao
    {
        public static string Cpf { get; set; }

        public static bool ValidarCpg(string cpf)
        {
            bool resultado = false;
            cpf = cpf.Replace(".","");
            cpf = cpf.Replace("-","");
            cpf = cpf.Replace(" ", "");
            cpf = cpf.Trim();
            string numerosCpf = cpf;
            int multi1 = 10, soma1 = 0, resultado1 = 0;
            int multi2 = 11, soma2 = 0, resultado2 = 0;

            if (numerosCpf.Length == 11) 
            {
                for (int i = 0; i < 9; i++)
                {
                    soma1 += multi1 * int.Parse(cpf[i].ToString());
                    multi1--;
                }
                for (int i = 0; i < 10; i++)
                {
                    soma2 += multi2 * int.Parse(numerosCpf.ToCharArray(i, 1));
                    multi2--;
                }
                resultado1 = soma1 % 11;
                resultado2 = soma2 % 11;

                if (resultado1 < 2)
                {
                    if (int.Parse(numerosCpf.ToCharArray(9, 1)) == 0)
                    {
                        if (resultado2 < 2)
                        {
                            if (int.Parse(numerosCpf.ToCharArray(10, 1)) == 0)
                            {
                                resultado = true;
                            }
                        }
                        else
                        {
                            resultado2 = 11 - resultado2;

                            if (resultado2 == int.Parse(numerosCpf.ToCharArray(10, 1)))
                            {
                                resultado = true;
                            }
                        }
                    }
                }
                else
                {
                    resultado1 = 11 - resultado1;

                    if (resultado1 == int.Parse(numerosCpf.ToCharArray(9, 1)))
                    {
                        if (resultado2 < 2)
                        {
                            if (int.Parse(numerosCpf.ToCharArray(10, 1)) == 0)
                            {
                                resultado = true;
                            }
                        }
                        else
                        {
                            resultado2 = 11 - resultado2;

                            if (resultado2 == int.Parse(numerosCpf.ToCharArray(10, 1)))
                            {
                                resultado = true;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("CPF possui numeros a mais!");
            }
            return resultado;
        }

    }
}
