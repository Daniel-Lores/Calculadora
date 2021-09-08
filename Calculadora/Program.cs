using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Array = new double[2];
            Array = Division.Div(5, 2);
            Console.WriteLine(Array[0]);
            Console.WriteLine(Array[1]);
        }
    }
}
