﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.buslog.Operaciones
{
    public class Simple : Integral
    {

        public double CalcularIntegral(double a, double b, double k, double n)
        {
            double retorno = 0.0;
            retorno = b - a;
            return retorno;
        }
    }
}
