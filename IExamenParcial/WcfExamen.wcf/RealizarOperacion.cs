using Clases.buslog;
using Clases.buslog.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfExamen.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RealizarOperacion" in both code and config file together.
    public class RealizarOperacion : IRealizarOperacion
    {
        [OperationContract]
        public double RealizarOperacion(double a, double b, double k, double n,int tipoOperacion)
        {
            string respuesta = string.Empty;
            double resultado = 0;
            try
            {
                Integral integral = null;
                if (tipoOperacion == (int)TiposOperaciones.Simple)
                    integral = new Simple();
                else if (tipoOperacion == (int)TiposOperaciones.Constante)
                    integral = new Constante();
                else if (tipoOperacion == (int)TiposOperaciones.Potencia)
                    integral = new Potencia();
                else if (tipoOperacion == (int)TiposOperaciones.Logaritmo)
                    integral = new Logaritmo();
                else if (tipoOperacion == (int)TiposOperaciones.Exponencial)
                    integral = new Exponencial();
                else if (tipoOperacion == (int)TiposOperaciones.Seno)
                    integral = new Seno();
                else if (tipoOperacion == (int)TiposOperaciones.Coseno)
                    integral = new Coseno();

                resultado =  integral.CalcularIntegral(a, b, k, n);

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
                respuesta += " | " + ex.InnerException.Message;
            }
            return resultado;
        }
    }
}
