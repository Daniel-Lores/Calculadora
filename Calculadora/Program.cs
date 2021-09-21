using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ListaNum = new double[2];
            Console.WriteLine(@"Introduce el tipo de operacion a realizar
1 -----> Suma
2 -----> Resta
3 -----> Multiplicación
4 -----> División");
            int OperationType = int.Parse(Console.ReadLine());
            var operation = (Operations) OperationType;
            switch (operation)
            {
                case Operations.Add:
                    Console.WriteLine("Introduce dos números a sumar");
                    for (int i = 0; i < ListaNum.Length; i++)
                    {
                        ListaNum[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($@"El resultado de la suma es {Suma.Sum(ListaNum)}");
                    break;
                case Operations.Subtraction:
                    Console.WriteLine("Introduce dos números a restar");
                    for (int i = 0; i < ListaNum.Length; i++)
                    {
                        ListaNum[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($@"El resultado de la resta es {Resta.Rest(ListaNum)}");
                    break;
                case Operations.Multiplication:
                    Console.WriteLine("Introduce dos números a multiplicar");
                    for (int i = 0; i < ListaNum.Length; i++)
                    {
                        ListaNum[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($@"El resultado de la multiplicación es {Multiplicar.Mult(ListaNum)}");
                    break;
                case Operations.Division:
                    Console.WriteLine("Introduce dos números a dividir");
                    for (int i = 0; i < ListaNum.Length; i++)
                    {
                        ListaNum[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($@"El resultado de la división es {Division.Div(ListaNum)}");
                    break;
                default:
                    Console.WriteLine("No has elegido una operación valida");
                    break;
            }
        }
    }
}
