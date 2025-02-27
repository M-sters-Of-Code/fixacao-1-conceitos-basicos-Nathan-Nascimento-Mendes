using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class MetrosMilimetros
    {
        public static double Converter(double metro)
        {
            double milimetros = metro * 1000;
            return milimetros;
        }
    }
}
