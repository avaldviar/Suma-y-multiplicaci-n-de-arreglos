using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDadosEj1.models
{
    internal class Probandotiros
    {
        public int[] frecuencia;
        public Dado dado1;
        public Dado dado2;


        public Probandotiros()
        {
            frecuencia = new int[13];
            dado1 = new Dado();
            dado2 = new Dado();
        }
        public void ReanudarFrecuencia()
        {
            frecuencia = new int[13];
        }
        public void Reproducirlanzamientos(int lanzamientos)
        {
            ReanudarFrecuencia();
            for (int i = 0; i < lanzamientos; i++)
            {
                int suma = dado1.Darnumrand() + dado2.Darnumrand();
                frecuencia[suma]++;
            }
        }

        public int[] GetFrecuencias()
        {
            return frecuencia;
        }
    }
}
