using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Boton operar.
         * Crea dos instancias de Numero , opera y muestra el resultado.
         * 
        */
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(this.txtNumero1.Text);
            Numero numero2 = new Numero(this.txtNumero2.Text);
            this.lblResultado.Text = Calculadora.operar(numero1,numero2,this.cmbOperacion.Text).ToString();
            this.cmbOperacion.Text = Calculadora.validarOperador(this.cmbOperacion.Text);
        }
        /* Boton CC
         * Limpia todos los campos de la aplicacion.
         */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = "";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperacion.Text = "";
        }  
    }
}
