using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaAumento
    {
        public static double Calcular(double salarioAtual, double percentualAumento)
        {
            double valorAumento = (percentualAumento / 100) * salarioAtual;
            double novoSalario = salarioAtual + valorAumento;
            return novoSalario;
        }

    }
}

