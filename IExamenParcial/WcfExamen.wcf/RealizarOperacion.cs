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
        public double RealizarOperacion(double a, double b, double k, double x,double potencia, int tipoOperacion)
        {
            string res = string.Empty;
            try
            {
                Integral resultado = null;
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

            }
            catch (Exception ex)
            {
                res = ex.Message;
                res += " | " + ex.InnerException.Message;
            }
        }
    }
}
