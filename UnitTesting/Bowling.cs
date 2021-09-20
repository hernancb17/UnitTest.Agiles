using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Bowling
    {
        public int Tirar(int[] jugada)
        {
            int resultado = 0;

            for (int tiradaNro = 1; tiradaNro < 22; tiradaNro++)
            {
                resultado += jugada[tiradaNro - 1];

                if (tiradaNro > 2)
                {
                    int impar = tiradaNro % 2;

                    if (impar == 1)
                    {
                        if (tiradaNro < 20)
                        {
                            if (isStrike(jugada[tiradaNro - 3]))
                                resultado += jugada[tiradaNro - 1] * 2;

                            else if (isSpare(jugada[tiradaNro - 2], jugada[tiradaNro - 3]))
                                resultado += jugada[tiradaNro - 1];
                        }
                        
                    }
                }
            }

            return Score(resultado);
        }

        private int Score(int resultado)
        {
            return resultado;
        }

        private bool isSpare(int jugada1, int jugada2)
        {
            bool isSpare = false;

            int spare = jugada1 + jugada2;

            if (spare == 10)
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
