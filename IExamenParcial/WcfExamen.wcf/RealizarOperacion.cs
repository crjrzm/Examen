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
        public void RealizarOperacion(double a, double b, double k, double potencia, int tipoOperacion)
        {
            string res = string.Empty;
            try
            {
                //Integral integral = CalcularIntegral(a, b, k, tipoOperacion, potencia);

            }
            catch (Exception ex)
            {
                res = ex.Message;
                res += " | " + ex.InnerException.Message;

            }
        }
    }
}
