using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Calculo
    {
        public int Sumar(string nums)
        {
            int suma = 0;

            string[] numeros;

            if (nums != "")
            {
                numeros = nums.Split(',', '\n');

                foreach (var numero in numeros)
                {
                    suma += int.Parse(numero);
                }
            }            

            return suma;
        }
    }
}
//int Sumar(string numeros)
//———————————————

//El método puede tomar dos números enteros, separados por coma. 
//Un string vacio suma 0.

//Ejemplos: “1,2”= 3 “4,2”= 6 “”= 0