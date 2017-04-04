using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsCosa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int entero;
        String cadena;
        DateTime fecha;
        Cosa miCosa;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.entero = int.Parse(this.txtEntero.Text);
            this.cadena = this.txtCadena.Text;
            this.fecha = DateTime.Parse(this.txtFecha.Text);
            miCosa = new Cosa(this.entero,this.cadena,this.fecha);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miCosa.Mostrar(), "Mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        
    }
}
