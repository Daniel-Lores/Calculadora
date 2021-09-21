/*using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculadora.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var s = Suma.Sum(1, 2);
            Assert.AreEqual(3, s);
        }

        [TestMethod]
        public void TestSuma_Fail()
        {
            var s = Suma.Sum(9, 2);
            Assert.AreNotEqual(1, s);            
        }

        [TestMethod]
        public void TestResta()
        {
            var s = Resta.Rest(5, 3);
            Assert.AreEqual(2, s);
        }

        [TestMethod]
        public void TestResta_Fail()
        {
            var s = Resta.Rest(5, 3);
            Assert.AreNotEqual(9, s);
        }

        [TestMethod]
        public void TestMultiplicaccion()
        {
            var s = Multiplicar.Mult(2, 2);
            Assert.AreEqual(4, s);
        }

        [TestMethod]
        public void TestMultiplicaccion_Fail()
        {
            var s = Multiplicar.Mult(9, 2);
            Assert.AreNotEqual(7.8, s);
        }

        [TestMethod]
        public void TestDivision_Cociente()
        { 
            double[] Array = new double[2];
            Array = Division.Div(5, 2);
            Assert.AreEqual(2, Array[0]);
        }

        [TestMethod]
        public void TestDivision_Resto()
        {
            double[] Array = new double[2];
            Array = Division.Div(5, 2);
            Assert.AreEqual(1, Array[1]);
        }
        [TestMethod]
        public void TestDivision_Cociente_Fail()
        {
            double[] Array = new double[2];
            Array = Division.Div(5, 2);
            Assert.AreNotEqual(9, Array[0]);
        }

        [TestMethod]
        public void TestDivision_Resto_Fail()
        {
            double[] Array = new double[2];
            Array = Division.Div(5, 2);
            Assert.AreNotEqual(0, Array[1]);
        }

        [TestMethod]
        public void TestFactorial()
        {
            var s = Factorial.Fact(3);
            Assert.AreEqual(6, s);
        }

        [TestMethod]
        public void TestFactorial_Fail()
        {
            var s = Factorial.Fact(3);
            Assert.AreNotEqual(7, s);
        }

        [TestMethod]
        public void TestFibonacci()
        {
            var s = Fibonacci.Fibo(3);
            Assert.AreEqual(2, s);
        }

        [TestMethod]
        public void TestFibonacci_Fail()
        {
            var s = Factorial.Fact(3);
            Assert.AreNotEqual(7, s);
        }
    }
}
*/