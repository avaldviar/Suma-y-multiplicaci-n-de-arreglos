using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionAerolinea.clases
{
    public class NumAsientos
    {
        // Array que representa los asientos del avión. 
        private bool[] Asientos = new bool[10];

        // Método para asignar un asiento en una sección específica.

        public int AsignarAsiento(int seccion)
        {

            int iniciar = (seccion == 1) ? 0 : 5;
            int fin = (seccion == 1) ? 4 : 9;

            // Recorre el rango de asientos para encontrar uno libre.

            for (int i = iniciar; i <= fin; i++)
            {
                if (!Asientos[i])
                {
                    Asientos[i] = true;
                    return i + 1;
                }
            }
            return -1;
        }

        public bool IsFull(int seccion)
        {
            int iniciar = (seccion == 1) ? 0 : 5;
            int fin = (seccion == 1) ? 4 : 9;

            for (int i = iniciar; i <= fin; i++)
            {
                if (!Asientos[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
