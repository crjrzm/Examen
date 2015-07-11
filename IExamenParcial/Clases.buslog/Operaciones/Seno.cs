
using System;
namespace Clases.buslog.Operaciones
{
    public class Seno : Integral
    {
        public double CalcularIntegral(double a, double b, double k, double x, double potencia)
        {
            double resultado = 0;
            if (new Validador().MenorAqueB(a, b))
                resultado = (Math.Pow(-1 * Math.Cos(x), b) - Math.Pow(-1 * Math.Cos(x), a));
            else
                throw new Exception(@"La variable a es mayor que b");
            return resultado;
        }

    }
}
