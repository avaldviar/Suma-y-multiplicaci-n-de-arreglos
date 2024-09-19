using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilidadDeDados.Clases
{
    internal class TiroDeDados
    {
        public int[] frecuencia;
        public ClaseDado dado1;
        public ClaseDado dado2;


        public TiroDeDados()
        {
            frecuencia = new int[13];
            dado1 = new ClaseDado();
            dado2 = new ClaseDado();
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
