using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Ventasporvendedor.models;

namespace Ventasporvendedor
{

    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();

        public Form1()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Llama a métodos para guardar la venta y mostrar las ventas actualizadas
            GuardarVenta();
            MostrarVentas();

        }

        public void GuardarVenta()
        {
            Ventasx venta;
            int vendedor, producto, valor;

            try
            {
                // Convierte las selecciones y el valor de texto a enteros
                vendedor = Convert.ToInt32(cmbIdVendedor.SelectedItem);
                producto = Convert.ToInt32(cmbIdProducto.SelectedItem);

                // Verifica que el valor de la venta no sea negativo
                if (Convert.ToInt32(tbValor.Text) < 0)
                {
                    throw new Exception("El valor de la venta no puede ser negativo");
                }
                valor = Convert.ToInt32(tbValor.Text);

                // Crea una nueva instancia de Ventasx con los datos ingresados
                venta = new Ventasx(vendedor - 1, producto - 1, valor);

                // Agrega la venta a la empresa
                empresa.AgregarVenta(venta);

                // Limpia los campos de entrada para nuevas ventas
                LimpiarDRegistro();

                MessageBox.Show("Venta guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void MostrarVentas()
        {
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();

            // Agrega columnas para los productos y los vendedores
            Aggcolumnasxvendedor();

            // Muestra los productos y las ventas totales por vendedor
            Showproductyvendedor();

            // Muestra el total de ventas por vendedor
            MostrarTtlProducto();

            // Muestra el total de ventas por producto
            MostrarTtlVendedor();
        }
        public void Showproductyvendedor()
        {

            // Agrega filas con los productos y las ventas totales
            double[,] ventas = empresa.CambVentas();
            for (int producto = 0; producto < 5; producto++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvVentas);
                row.Cells[0].Value = producto + 1;

                // Asigna las ventas por cada vendedor a la fila
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    row.Cells[vendedor + 1].Value = ventas[producto, vendedor];
                }

                dgvVentas.Rows.Add(row);
            }
        }
        public void Aggcolumnasxvendedor()
        {
            // Agrega una columna para cada vendedor
            dgvVentas.Columns.Add("Producto", "Producto");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                dgvVentas.Columns.Add("Vendedor" + (vendedor + 1), "Vendedor " + (vendedor + 1));
            }
        }


        public void MostrarTtlVendedor()
        {
            dgvVentas.Rows.Add("T. Vendedor $");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                double total = empresa.TotalVentasVendedor(vendedor + 1);
                dgvVentas.Rows[5].Cells[vendedor + 1].Value = total;
            }
        }
        public void MostrarTtlProducto()
        {
            //Agregar Total Producto
            dgvVentas.Columns.Add(ToString(), "Total Producto $");

            // Muestra el total de ventas para cada producto en la columna agregada
            for (int producto = 0; producto < 5; producto++)
            {
                double total = empresa.TotalVentasProducto(producto + 1);
                dgvVentas.Rows[producto].Cells[5].Value = total;
            }
        }
        public void LimpiarDRegistro()
        {
            // Limpia los campos de entrada para permitir registrar nuevas ventas
            cmbIdProducto.SelectedIndex = -1; // Desmarca el producto seleccionado
            cmbIdVendedor.SelectedIndex = -1; // Desmarca el producto seleccionado
            tbValor.Text = ""; // Desmarca el producto seleccionado

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}


