using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btCalcular_Click(object sender, EventArgs e)
        {
            lvNumeros.Items.Clear();
            int.TryParse(txtNumeros.Text, out int limite);
            int _cantpri = 0;
            int _cantper = 0;
            for (int i = 1; i <= limite; i++)
            {
                ListViewItem fila = new ListViewItem(i.ToString());
                bool esPrimo = true;
                
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if(esPrimo)
                {
                    _cantpri = _cantpri + 1;
                    fila.SubItems.Add("Primo");
                }
                else
                {
                    fila.SubItems.Add("");
                }

                //Calcular perfecto
                int contador = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        contador = contador + j;

                    }
                }

                if (contador == i) {
                    _cantper = _cantper + 1;
                    fila.SubItems.Add("Perfectos");
                  
                }
                else
                {
                    fila.SubItems.Add("");
                }
                lvNumeros.Items.Add(fila);
                lbPrimos.Text = "Primos: " + _cantpri;
                lbPerfectos.Text = "Perfectos: " + _cantper;
            }
            
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
