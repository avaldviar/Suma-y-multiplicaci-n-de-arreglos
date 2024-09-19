using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilidadDeDados.Clases
{
    internal class ClaseDado
    {
        private static Random rand = new Random();
        public int Darnumrand()
        {
            // Tira un numero aleatorio entre 1 y 6
            return rand.Next(1, 7);

        }
    }
}
