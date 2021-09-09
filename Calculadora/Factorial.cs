using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Factorial
    {
        public static int Fact(int n1)
        {
            if (n1 > 1)
            {
                return n1 *= Fact(n1 - 1);
            }
            else
            {
                return 0;
            }
            
        }
    }
}
