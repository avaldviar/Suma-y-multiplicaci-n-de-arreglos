using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasporComision.Clases
{
    internal class SalarioDeVendedores
    {
        // Constante que define el pago fijo de $200
        private const int PagoFijo = 200;

        // Constante que define la comisión del 9% sobre las ventas brutas
        private const double Comision = 0.09;

        public int CalcularSalario(int ventasBrutas)
        {
            // Retorna el salario calculado como la suma del pago fijo y la comisión
            return (int)(PagoFijo + (ventasBrutas * Comision));
        }
    }
}
