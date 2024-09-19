using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasporComision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Inicializa los componentes del formulario
            InitializeComponent();
        }
        // Arreglo para almacenar la cantidad de vendedores en cada rango de salarios
        private int[] rangosSalarios = new int[9];

        // Método para calcular el salario basado en las ventas brutas
        private void CalcularSalario(int ventasBrutas)
        {
            // Calcula el salario como 200 más el 9% de las ventas brutas
            int salario = (int)(200 + 0.09 * ventasBrutas);

            // Clasifica el salario en uno de los nueve rangos
            if (salario >= 1000)
            {
                rangosSalarios[8]++;
            }
            else if (salario >= 900)
            {
                rangosSalarios[7]++;
            }
            else if (salario >= 800)
            {
                rangosSalarios[6]++;
            }
            else if (salario >= 700)
            {
                rangosSalarios[5]++;
            }
            else if (salario >= 600)
            {
                rangosSalarios[4]++;
            }
            else if (salario >= 500)
            {
                rangosSalarios[3]++;
            }
            else if (salario >= 400)
            {
                rangosSalarios[2]++;
            }
            else if (salario >= 300)
            {
                rangosSalarios[1]++;
            }
            else
            {
                rangosSalarios[0]++;
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            // Variable para almacenar las ventas brutas ingresadas por el usuario
            int ventasBrutas;
            if (int.TryParse(txtVentasButas.Text, out ventasBrutas))
            {
                // Si es válido, calcula el salario correspondiente y clasifica al vendedor
                CalcularSalario(ventasBrutas);
                MessageBox.Show("Venta registrada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }

            txtVentasButas.Clear();
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            // Agrega a la lista la cantidad de vendedores en cada rango salarial
            lstMostrarReporte.Items.Clear();
            lstMostrarReporte.Items.Add("Rangos de salarios:");
            lstMostrarReporte.Items.Add($"$200-$299:   {rangosSalarios[0]} vendedores");
            lstMostrarReporte.Items.Add($"$300-$399:   {rangosSalarios[1]} vendedores");
            lstMostrarReporte.Items.Add($"$400-$499:   {rangosSalarios[2]} vendedores");
            lstMostrarReporte.Items.Add($"$500-$599:   {rangosSalarios[3]} vendedores");
            lstMostrarReporte.Items.Add($"$600-$699:   {rangosSalarios[4]} vendedores");
            lstMostrarReporte.Items.Add($"$700-$799:   {rangosSalarios[5]} vendedores");
            lstMostrarReporte.Items.Add($"$800-$899:   {rangosSalarios[6]} vendedores");
            lstMostrarReporte.Items.Add($"$900-$999:   {rangosSalarios[7]} vendedores");
            lstMostrarReporte.Items.Add($"$1000 o más: {rangosSalarios[8]} vendedores");
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
