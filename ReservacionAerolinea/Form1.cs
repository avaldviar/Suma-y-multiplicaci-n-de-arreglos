using ReservacionAerolinea.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservacionAerolinea
{
    public partial class Form1 : Form
    {
        // Objeto que contiene la lógica para asignar asientos.
        private NumAsientos avion;

        // Constructor del formulario. Inicializa componentes y el objeto 'avion'.

        public Form1()
        {
            InitializeComponent();
            avion = new NumAsientos();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // Determina la sección según si se selecciona "Fumar" o "No Fumar".
            int section = rdoSmoking.Checked ? 1 : 2;
            int seleccionarNum = avion.AsignarAsiento(section);
            string nombre = null;

            if (seleccionarNum == -1)
            {
                string OtraSeccion = (section == 1) ? "No Fumar" : "Fumar";

                // Muestra un mensaje al usuario preguntando si desea cambiar de sección.
                if (MessageBox.Show($"La sección está llena. ¿Te gustaría ser asignado a la sección de {OtraSeccion}?",
                    "Sección llena", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    section = (section == 1) ? 2 : 1;
                    seleccionarNum = avion.AsignarAsiento(section);
                }
            }

            // Si se ha asignado un asiento (no es -1), se muestra el pase de abordar con la información.
            if (seleccionarNum != -1)
            {
                nombre = tbNombre.Text;
                string NombreSeccion = (section == 1) ? "Fumar" : "No Fumar";
                lblBoardingPass.Text = $"Pasajero: {nombre}\nAsiento asignado: {seleccionarNum}\nSección: {NombreSeccion}";
            }
            else
            {
                lblBoardingPass.Text = "El próximo vuelo sale en 3 horas.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
