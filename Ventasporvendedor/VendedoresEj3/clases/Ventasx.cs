using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventasporvendedor.models
{
    internal class Ventasx
    {
        public int IdVendedor { get; set; }
        public int IdProducto { get; set; }
        public int Valor { get; set; }

        public Ventasx(int vendedor, int producto, int cantidad)
        {
            IdVendedor = vendedor;
            IdProducto = producto;
            Valor = cantidad;
        }
    }
}
