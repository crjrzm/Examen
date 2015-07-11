
using System;
namespace Clases.buslog.Operaciones
{
    public class Seno : Integral
    {
        public double CalcularIntegral(double a, double b, double k, double x, double potencia)
        {
            return (Math.Pow(-1 * Math.Cos(x), b) - Math.Pow(-1 * Math.Cos(x), a));
        }
        
    }
}
