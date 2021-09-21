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
            if (iteracionDeseada == 1)
            {
                return 1;
            }
            return Fibo(iteracionDeseada - 1) + Fibo(iteracionDeseada - 2);
        }
    }
}
