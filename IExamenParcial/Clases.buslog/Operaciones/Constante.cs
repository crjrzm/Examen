using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.buslog.Operaciones
{
    public class Constante : Integral
    {
        public double CalcularIntegral(double a, double b, double k, double n)
        {
            double retorno = 0.0;
            retorno=(Math.Pow(k,b)) - (Math.Pow(k,a));
            return retorno;

        }
    }
}
