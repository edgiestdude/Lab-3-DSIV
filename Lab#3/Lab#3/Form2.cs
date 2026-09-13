using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*GRUPO: 1GS125
    * INTEGRANTES:
    * Arauz, Anyeline 8-1040-2428
    * Hernandez, Diego  20-70-8359
    * Martez, Alanis 8-1019-2389
    * Rodriguez Analia 8-1037-1667 */
namespace Lab_3
{
    public partial class Form2 : Form
    {
        private OpFrase operaciones = new OpFrase();
        public Form2()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrase_DoubleClick(object sender, EventArgs e)
        {

            lvFrase.Items.Clear();//limpia el listview si se escribe una nueva frase

            List<string> palabras = operaciones.GetPalabras(txtFrase.Text);
            if (palabras.Count == 0) return;

            string masLarga = operaciones.GetMasLarga(palabras);
            bool rowUno = true;

            foreach (string palabra in palabras)
            {
                var item = new ListViewItem(operaciones.GetInicial(palabra).ToString());

                if (rowUno)
                {
                    item.SubItems.Add(masLarga);
                    item.SubItems.Add(masLarga.Length.ToString());
                    rowUno = false; //valida con booleano que solo se imprima la palabra mas larga y su longitud una sola vez
                }

                lvFrase.Items.Add(item);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtFrase.Clear();
            lvFrase.Items.Clear();

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
