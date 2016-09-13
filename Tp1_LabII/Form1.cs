using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1_LabII
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textNumero2_TextChanged(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// carga todos los campos con strings vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNumero1.Text = "";
            textNumero2.Text = "";
            cmbOperacion.Text = "";
        }
        /// <summary>
        /// Llama a la funcion operar y le pasa como parametros los campos ingresados desde el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            Numero obNumero1 = new Numero(textNumero1.Text);
            Numero obNumero2 = new Numero(textNumero2.Text);
            
            resultado = Calculadora.operar(obNumero1, obNumero2, cmbOperacion.Text);

            this.label1.Text = resultado.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

    }
}
