using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.buslog.Operaciones
{
    public class Validador
    {
        public Boolean MenorAqueB(double a, double b) {
            bool retorno = false;
            if(a<b){
                retorno = true;
            }
            return retorno;
        }
    }

}
