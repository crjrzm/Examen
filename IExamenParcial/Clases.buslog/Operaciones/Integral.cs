using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases.buslog.Operaciones
{
    public interface Integral
    {
        public Integral CalcularIntegral(double a, double b, double k, int tipoOperacion, double potencia)
        {
            Integral resultado = new Seno();
            if (tipoOperacion == (int)TiposOperaciones.Seno)
                resultado = new Seno();
            else if (tipoOperacion == (int)TiposOperaciones.Constante)
                resultado = new Constante();
            else if (tipoOperacion == (int)TiposOperaciones.Potencia)
                resultado = new Potencia();
            else if (tipoOperacion == (int)TiposOperaciones.Logaritmo)
                resultado = new Logaritmo();
            else if (tipoOperacion == (int)TiposOperaciones.Exponencial)
                resultado = new Exponencial();
            else if (tipoOperacion == (int)TiposOperaciones.Seno)
                resultado = new Seno();
            else if (tipoOperacion == (int)TiposOperaciones.Coseno)
                resultado = new Coseno();
            return resultado;
            
        }
    }
}
