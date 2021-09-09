using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Fibonacci
    {
        public static int Fibo(int iteracionDeseada)
        {
            if (iteracionDeseada == 0)
            {
                return 0;
            }
            else if (iteracionDeseada == 1)
            {
                return 1;
            }
            else
            {
                return Fibo(iteracionDeseada - 1) + Fibo(iteracionDeseada - 2);
            }
        }
    }
}
