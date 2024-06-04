using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double acumNota = 0;
        static int cont = 0;

        private double CalcularPromedio()
        {
            double promedio = 0;
            if (cont > 0)
                promedio = acumNota / cont;
            return promedio;
        }

        private void RegistrarNota(double nota )
        {
            acumNota += nota;
            cont++;
        }

        private void agregarnota_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(ingresoNota.Text);
            RegistrarNota(nota);

            ingresoNota.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = CalcularPromedio();

            label3.Text = promedio.ToString();
        }
    }
}
