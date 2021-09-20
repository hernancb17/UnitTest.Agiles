using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest;

namespace CalculoTest
{
    [TestClass]
    public class CalculoTest
    {
        [TestMethod]
        public void TestSumar2Pasa()
        {
            Calculo calc = new Calculo();

            string numeros = "4,5";

            int resultado = calc.Sumar(numeros);

            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void TestSumarNPasa()
        {
            Calculo calc = new Calculo();

            string numeros = "4,5,6,7";

            int resultado = calc.Sumar(numeros);

            Assert.AreEqual(22, resultado);
        }

        [TestMethod]
        public void TestSumarErroneo()
        {
            Calculo calc = new Calculo();

            string numeros = "8";

            int resultado = calc.Sumar(numeros);

            Assert.AreNotEqual(5, resultado);
        }

        [TestMethod]
        public void TestSumarVacio()
        {
            Calculo calc = new Calculo();

            string numeros = "";

            int resultado = calc.Sumar(numeros);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void TestSumarDifSeparadoresPasa()
        {
            Calculo calc = new Calculo();

            string numeros = "1,2,4\n5,6";

            int resultado = calc.Sumar(numeros);

            Assert.AreEqual(18, resultado);
        }
        [TestMethod]
        public void TestSumarDifSeparadoresFalla()
        {
            Calculo calc = new Calculo();

            string numeros = "1,2,4\n5,6";

            int resultado = calc.Sumar(numeros);

            Assert.AreEqual(8, resultado);
        }
    }

}
//int Sumar(string numeros)
//———————————————

//El método puede tomar dos números enteros, separados por coma. 
//Un string vacio suma 0.

//Ejemplos: “1,2”= 3 “4,2”= 6 “”= 0

//3.También admite nuevas líneas identificadas con un: “\n”

//Ejemplo: “1,2,4\n5,6”= 18