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
            return (Math.Pow(Math.Sin(x), b) - Math.Pow(Math.Sin(x), a));
        }
    }
}
