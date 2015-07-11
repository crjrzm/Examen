using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.buslog.Operaciones
{
    public class Coseno : Integral
    {
        public double CalcularIntegral(double a, double b, double k, double x, double potencia)
        {
            double resultado = 0;
            if (new Validador().MenorAqueB(a, b))
                resultado = (Math.Pow(Math.Sin(x), b) - Math.Pow(Math.Sin(x), a));
            else
                throw new Exception(@"La variable a es mayor que b");
            return resultado;
        }
    }
}
