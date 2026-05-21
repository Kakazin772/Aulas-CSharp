using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotacao_do_dolar
{
    class ConversorDeMoeda
    {
        public static double Conversao(double cot, double din)
        {
            return (cot * din) * 1.06;
        }
    }
}
