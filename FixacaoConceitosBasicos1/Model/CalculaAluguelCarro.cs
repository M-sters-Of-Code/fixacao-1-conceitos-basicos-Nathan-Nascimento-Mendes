using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int kmInicial, int kmFinal)
        {
            int km = kmFinal - kmInicial;
            double valorKm = km * 0.35;

            double valorDias = dias * 95;

            double total = valorDias + valorKm;

            return total;

        }
    }
}
