using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void TestErraTodo()
        {
            int[] jugada = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            Bowling bowling = new Bowling();

            Assert.AreEqual(0, bowling.Tirar(jugada));
        }

        [TestMethod]
        public void TestTiraUno()
        {
            int[] jugada = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0};

            Bowling bowling = new Bowling();

            int score = bowling.Tirar(jugada);

            Assert.AreEqual(20, score);

            Console.WriteLine("Puntaje final: " + score);
        }

        [TestMethod]
        public void TestUnSpare()
        {
            int resultado = 0;

            int[] jugada = {1, 2, 4, 6, 7, 0, 2, 1, 6, 3, 4, 2, 1, 6, 3, 2, 7, 1, 4, 2 };
            
            for (int tiradaNro = 1; tiradaNro < 21; tiradaNro++)
            {
                resultado += Tirar(jugada[tiradaNro-1]);
                if (tiradaNro>2)
                {
                    int impar = tiradaNro % 2;

                    if (impar == 1)
                    {
                        if (isSpare(jugada[tiradaNro - 2], jugada[tiradaNro - 3]))
                            resultado += jugada[tiradaNro - 1];
                    }
                }
            }

            Assert.AreEqual(71,resultado);

            Console.WriteLine("Puntaje final: " + resultado);
        }

        [TestMethod]
        public void TestUnStrike()
        {
            int resultado = 0;

            int[] jugada = { 1, 2, 4, 3, 10, 0, 2, 1, 6, 3, 4, 2, 1, 6, 3, 2, 7, 1, 4, 2 };

            for (int tiradaNro = 1; tiradaNro < 21; tiradaNro++)
            {
                resultado += Tirar(jugada[tiradaNro - 1]);
                if (tiradaNro > 2)
                {
                    int impar = tiradaNro % 2;

                    if (impar == 1)
                    {
                        if (isStrike(jugada[tiradaNro - 3]))
                            resultado += jugada[tiradaNro - 1] + jugada[tiradaNro];
                    }
                }
            }

            Assert.AreEqual(67, resultado);

            Console.WriteLine("Puntaje final: " + resultado);
        }

        [TestMethod]
        public void TestUnStrikeUnSpare()
        {
            int resultado = 0;

            int[] jugada = { 1, 9, 10, 0, 5, 0, 2, 1, 6, 2, 4, 2, 1, 6, 3, 2, 7, 1, 4, 2 };

            for (int tiradaNro = 1; tiradaNro < 21; tiradaNro++)
            {
                resultado += Tirar(jugada[tiradaNro - 1]);
                if (tiradaNro > 2)
                {
                    int impar = tiradaNro % 2;

                    if (impar == 1)
                    {
                        if (isStrike(jugada[tiradaNro - 3]))
                            resultado += jugada[tiradaNro - 1] + jugada[tiradaNro];

                        else if (isSpare(jugada[tiradaNro - 2], jugada[tiradaNro - 3]))
                            resultado += jugada[tiradaNro - 1];
                    }
                }
            }

            Assert.AreEqual(83, resultado);

            Console.WriteLine("Puntaje final: " + resultado);
        }

        [TestMethod]
        public void TestTodosSpare()
        {
            int resultado = 0;

            int[] jugada = { 1, 9, 4, 6, 7, 3, 2, 8, 6, 4, 4, 6, 1, 9, 3, 7, 7, 3, 4, 6, 1 };
            
            for (int tiradaNro = 1; tiradaNro < 22; tiradaNro++)
            {
                resultado += Tirar(jugada[tiradaNro - 1]);
                if (tiradaNro > 2)
                {
                    int impar = tiradaNro % 2;

                    if (impar == 1)
                    {
                        if (isSpare(jugada[tiradaNro - 2], jugada[tiradaNro - 3]))
                            resultado += jugada[tiradaNro - 1];
                    }
                }
            }

            Assert.AreEqual(140, resultado);

            Console.WriteLine("Puntaje final: " + resultado);
        }
        [TestMethod]
        public void TestTodosStrike()
        {
            int resultado = 0;

            int[] jugada = { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 10, 10 };

            for (int tiradaNro = 1; tiradaNro < 22; tiradaNro++)
            {
                resultado += Tirar(jugada[tiradaNro - 1]);

                if (tiradaNro > 2)
                {
                    int impar = tiradaNro % 2;

                    if (impar == 1)
                    {
                        if (tiradaNro < 20)
                        {
                            if (isStrike(jugada[tiradaNro - 3]))
                                resultado += jugada[tiradaNro - 1] * 2;
                        }
                    }
                }
            }

            Assert.AreEqual(300, resultado);

            Console.WriteLine("Puntaje final: "+resultado);
        }

        private int Tirar(int pinos)
        {
            return pinos;
        }

        private bool isSpare(int jugada1,int jugada2)
        {
            bool isSpare = false;

            int spare = jugada1+jugada2;

            if (spare==10)
            {
                isSpare = true;
            }

            return isSpare;
        }

        private bool isStrike(int jugada)
        {
            bool isStrike = false;

            if (jugada == 10)
            {
                isStrike = true;
            }

            return isStrike;
        }
    }
}
