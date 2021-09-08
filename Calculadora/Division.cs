using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Division
    {
        public static double[] Div(double n1, double n2)
        {
            double result = n1 / n2;
            double resto = n1 % n2;
            double[] listaDivision = new double[2];
            listaDivision[0] = Math.Truncate(result);
            listaDivision[1] = resto;
            return listaDivision;
        }
    }
}
