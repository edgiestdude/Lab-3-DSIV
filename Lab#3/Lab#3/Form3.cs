using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{   /*GRUPO: 1GS125
     * INTEGRANTES:
     * Arauz, Anyeline 8-1040-2428
     * Hernandez, Diego  20-70-8359
     * Martez, Alanis 8-1019-2389
     * Rodriguez Analia 8-1037-1667 */
    public partial class Form3 : Form
    {

        ProPalabras procesador = new ProPalabras();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        { // pa deshabilitar el boton de agregar
            btAgregarPalabra.Enabled = false;
        }

        void VerificarTexto() //pa validar que la caja de texto tiene contenido
        {
            if (!string.IsNullOrWhiteSpace(txtPalabra.Text))
            {
                btAgregarPalabra.Enabled = true;
            }
            else
            {
                btAgregarPalabra.Enabled = false;
            }
        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        { //validación si escribió
            VerificarTexto();
        }

        private void btAgregarPalabra_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            //agrega la palabra al ListBox
            listPalabras.Items.Add(palabra);

            //la manda a la clase ProPalabras 
            procesador.AgregarPalabra(palabra);

            //pregunta si desea ingresar otra palabra
            DialogResult respuesta = MessageBox.Show(
                "¿Desea ingresar otra palabra?",
                "Continuar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                //borra el contenido del textbox para escribir una nueva palabra
                txtPalabra.Clear();
                txtPalabra.Focus();
            }
            else
            {
                //deshabilita el textbox y el boton
                txtPalabra.Enabled = false;
                btAgregarPalabra.Enabled = false;

                //muestra en los labes el resultado de las palabras 
                ActualizarLabels();
            }
        }

        void ActualizarLabels() 
        {
            lbCantPalabras.Text = "Cantidad de Palabras: " + procesador.ObtenerCantidad();
            lbPalabraLarga.Text = "Palabra más Larga: " + procesador.ObtenerPalabraL();
            lbPalabraCorta.Text = "Palabra más corta: " + procesador.ObtenerPalabraC();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();
            listPalabras.Items.Clear(); //limpia la lista
            procesador.Limpiar(); //limpia también la clase procesadora
            txtPalabra.Enabled = true; //vuelve a habilitar todo para empezar de nuevo
            VerificarTexto();
            //reestablece la info
            lbCantPalabras.Text = "Cantidad de Palabras: 0";
            lbPalabraLarga.Text = "Palabra más Larga: ";
            lbPalabraCorta.Text = "Palabra más corta: ";
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}