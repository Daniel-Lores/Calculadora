using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Division
    {
        public static double[] DivWithRest(double[] listaNum)
        {
            double result = listaNum[0] / listaNum[1];
            double resto = listaNum[0] % listaNum[1];
            double[] listaDivision = new double[2];
            listaDivision[0] = Math.Truncate(result);
            listaDivision[1] = resto;
            return listaDivision;
        }

        public static double Div(double[] ListaNum)
        {
            return ListaNum[0] / ListaNum[1];
        }
    }
}
