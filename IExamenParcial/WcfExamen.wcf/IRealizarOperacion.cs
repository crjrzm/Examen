using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfExamen.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRealizarOperacion" in both code and config file together.
    [ServiceContract]
    public interface IRealizarOperacion
    {
        [OperationContract]
        public void RealizarOperacion(double a, double b, double constante, double potencia)
        {
            string res = string.Empty;
            try
            {

                /////
            }
            catch (Exception ex)
            {
                res = ex.Message;
                res += " | " + ex.InnerException.Message;
                
            }
        }
    }
}
