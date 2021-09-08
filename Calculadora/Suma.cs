using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Suma
    {

        public static double Sum(double n1, double n2)
        {
            if( n1 < 0 || n2 < 0)
            {
                return -1;
            }
            return n1 + n2;
        }
    }
}
