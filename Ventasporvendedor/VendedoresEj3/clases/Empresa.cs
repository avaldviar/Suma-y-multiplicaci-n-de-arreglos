using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventasporvendedor.models
{
    internal class Empresa
    {
        // Matriz para almacenar las ventas, donde las filas representan productos y las columnas representan vendedores
        public double[,] AllVentas = new double[5, 4];
        public void AgregarVenta(Ventasx venta)
        {
            // Actualiza el total de ventas para el producto y el vendedor específicos
            AllVentas[venta.IdProducto, venta.IdVendedor] += venta.Valor;
        }

        // Método para calcular el total de ventas de un vendedor específico
        public double TotalVentasVendedor(int vendedor)
        {
            double total = 0;

            // Recorre todas las filas (productos) y suma las ventas del vendedor
            for (int i = 0; i < 5; i++)
            {
                total += AllVentas[i, vendedor - 1];
            }

            // Retorna el total de ventas del vendedor
            return total;
        }

        // Método para calcular el total de ventas de un producto específico
        public double TotalVentasProducto(int producto)
        {
            double total = 0;

            // Recorre todas las columnas (vendedores) y suma las ventas del producto
            for (int i = 0; i < 4; i++)
            {
                total += AllVentas[producto-1, i];
            }
            return total;
        }

        // Método para obtener la matriz de ventas
        public double[,] CambVentas()
        {
            // Retorna la matriz de ventas
            return AllVentas;
        }
    }
}
