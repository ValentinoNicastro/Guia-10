using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] lista = new int[100];
        int cont = 0;

        private void btAgregar_Click(object sender, EventArgs e)
        {
            lista[cont] = Convert.ToInt32(tbNumero.Text);
            cont++;
            tbNumero.Clear();
        }

        public void ordenar()
        {
            int guardar;

            for (int i = 0; i < cont - 1; i++)
            {
                for (int n = i + 1; n < cont; n++)
                {
                    if (i > j)
                    {
                        guardar = lista[i];
                        lista[i] = lista[n];
                        lista[n] = guardar;
                    }
                }
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();

            ordenar();

            for (int i = 0; i < cont;i++)
            {
                lbLista.Items.Add(lista[i]);
            }
        }
    }
}
