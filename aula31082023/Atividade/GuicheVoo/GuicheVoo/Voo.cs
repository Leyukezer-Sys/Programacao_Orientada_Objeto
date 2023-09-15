public class Voo
{
    private int numPassagens = 0, numeroVoo = 0;
    private DateTime dataVoo = new DateTime();
    private bool[] acentos = { };
    public Voo(int diaDoVoo, int mesDoVoo, int anoDoVoo, int horaDoVoo, int quantPassagensVoo)
    {
        setNumeroVoo();
        setDataVoo(diaDoVoo, mesDoVoo, anoDoVoo, horaDoVoo);
        setNumPassagens(quantPassagensVoo);
    }
    public void setNumeroVoo()
    {
        Random random = new Random();
        string numero = "";
        for (int i = 0; i < 4; i++)
        {
            numero += Convert.ToString(random.Next(1, 9));
        }
        this.numeroVoo = Convert.ToInt32(numero);
    }
    public int getNumeroVoo()
    {
        return this.numeroVoo;
    }
    public void setDataVoo(int dia, int mes, int ano, int hora)
    {
        this.dataVoo = new DateTime(ano, mes, dia, hora, DateTime.Now.Minute, DateTime.Now.Second);
    }
    public string getDataVoo()
    {
        string dataDoVoo = "";
        dataDoVoo = $"{this.dataVoo.Day}/{this.dataVoo.Month}/{this.dataVoo.Year}";
        return dataDoVoo;
    }
    public string getHoraVoo()
    {
        string horaDoVoo = "";
        horaDoVoo = $"{this.dataVoo.Hour}:{this.dataVoo.Minute}:{this.dataVoo.Second}";
        return horaDoVoo;
    }
    public void setNumPassagens(int quantidade)
    {
        this.numPassagens = quantidade;
        this.acentos = new bool[numPassagens];
        for (int i = 0; i < acentos.Length; i++)
        {
            acentos[i] = false;
        }
    }
    public int ProximoLivre(int acentoAtual)
    {
        for (int i = acentoAtual; i < acentos.Length; i++)
        {
            if (acentos[i] == false)
            {
                return i;
            }
            else if (i == (acentos.Length - 1))
            {
                i = 0;
            }
        }

        return 0;
    }
    public bool Verifica(int numCadeira)
    {
        if (acentos[numCadeira] == true)
        {
            return true;
        }
        return false;
    }
    public void Ocupa(int numCadeira)
    {
        acentos[numCadeira] = true;
    }
    public int Vagas()
    {
        int contVagas = 0;
        for (int i = 0; i < acentos.Length; i++)
        {
            if (acentos[i] == false)
            {
                contVagas++;
            }
        }

        return contVagas;
    }
    public string AcentosVoo()
    {
        string aviao = $"+========================+\n| ";
        int contColu = 0;
        for (int i = 0; i < acentos.Length; i++)
        {
            if (i < 9)
            {
                if (contColu < 9)
                {
                    if (contColu == 3 || contColu == 7)
                    {
                        aviao += $" ";
                    }
                    if (acentos[i] == false)
                    {
                        aviao += $"[\u001b[32m00{i + 1}\u001b[0m]";
                    }
                    else
                    {
                        aviao += $"[\u001b[31m00{i + 1}\u001b[0m]";
                    }
                    contColu++;
                }
                else
                {
                    contColu = 0;
                    if (acentos[i] == false)
                    {
                        aviao += $"[\u001b[32m00{i + 1}\u001b[0m]";
                    }
                    else
                    {
                        aviao += $"[\u001b[31m00{i + 1}\u001b[0m]";
                    }
                    aviao += $" |\n| ";
                }
            }
            else if (i >= 9 && i < 99)
            {
                if (contColu < 9)
                {
                    if (contColu == 3 || contColu == 7)
                    {
                        aviao += $" ";
                    }
                    if (acentos[i] == false)
                    {
                        aviao += $"[\u001b[32m0{i + 1}\u001b[0m]";
                    }
                    else
                    {
                        aviao += $"[\u001b[31m0{i + 1}\u001b[0m]";
                    }
                    contColu++;
                }
                else
                {
                    contColu = 0;
                    if (acentos[i] == false)
                    {
                        aviao += $"[\u001b[32m0{i + 1}\u001b[0m]";
                    }
                    else
                    {
                        aviao += $"[\u001b[31m0{i + 1}\u001b[0m]";
                    }
                    aviao += $" |\n| ";
                }
            }
            else
            {
                if (contColu < 9)
                {
                    if (contColu == 3 || contColu == 7)
                    {
                        aviao += $" ";
                    }
                    if (acentos[i] == false)
                    {
                        aviao += $"[\u001b[32m{i + 1}\u001b[0m]";
                    }
                    else
                    {
                        aviao += $"[\u001b[31m{i + 1}\u001b[0m]";
                    }
                    contColu++;
                }
                else
                {
                    contColu = 0;
                    if (acentos[i] == false)
                    {
                        aviao += $"[\u001b[32m{i + 1}\u001b[0m]";
                    }
                    else
                    {
                        aviao += $"[\u001b[31m{i + 1}\u001b[0m]";
                    }
                    aviao += $" |\n| ";
                }
            }
        }

        return aviao;
    }
}