using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaDesconto
    {
        public static double Calcular(double valorMercadoria, double percentualDesconto)
        {
            double desconto = (percentualDesconto / 100) * valorMercadoria;
            double valorFinalMercadoria = valorMercadoria - desconto;

            return valorFinalMercadoria;
        }
    }
}
