using ProbabilidadDeDados.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilidadDeDados
{
    public partial class Form1 : Form
    {
        TiroDeDados simulacion = new TiroDeDados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultadoDado1 = dado1.Darnumrand();
            int resultadoDado2 = dado2.Darnumrand();

            // Se muestran resultados en los labels
            LblLandado1.Text = resultadoDado1.ToString();
            LblLandado2.Text = resultadoDado2.ToString();

            // Se calcula y se muestra la suma de los dos dados
            int suma = resultadoDado1 + resultadoDado2;
            Lblsuma.Text = suma.ToString();

            
        }

        public void LimpiarElementos()
        {
            dgvTablaResultados.Rows.Clear();
            tbProbabilidad.Clear();
            tbProbabilidadde7.Clear();
        }
        ClaseDado dado1 = new ClaseDado();
        ClaseDado dado2 = new ClaseDado();
        

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            simulacion.Reproducirlanzamientos(36000);
            int[] frecuencias = simulacion.GetFrecuencias();

            // Se limpian resultados anteriores
            LimpiarElementos();


            if (dgvTablaResultados.Columns.Count == 0)
            {
                dgvTablaResultados.Columns.Add("Suma", "Suma");
                dgvTablaResultados.Columns.Add("Frecuencia", "Frecuencia");
            }

            // Se agregan los resultados de suma
            for (int i = 2; i < frecuencias.Length; i++)
            {
                dgvTablaResultados.Rows.Add(i, frecuencias[i]);
            }

            // Se comprueba si la suma 7 se aproxima al 16.67% de las tiradas
            double probabilidad7 = (double)frecuencias[7] / 36000;
            tbProbabilidad.Text = $"\nLa Frecuencia estimada de la suma 7:\n son {frecuencias[7]} veces.\n";
            tbProbabilidadde7.Text = $"\nSe estima que la probabilidad de la suma 7:\n  Es {probabilidad7:P2} \n(Debe ser aprox. 16.67%)";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LblLandado2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblLandado1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
