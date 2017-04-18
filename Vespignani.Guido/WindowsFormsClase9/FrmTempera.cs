using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase9;

namespace WindowsFormsClase9
{
    public partial class FrmTempera : Form
    {
        private Tempera _tempera;
        
        
        public Tempera Tempera
        {
            get { return this._tempera; }
            
        }

        public FrmTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor i in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbColor.Items.Add(i);
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tempera tempera = new Tempera((ConsoleColor)cmbColor.SelectedItem,(String)txtMarca.Text,int.Parse(txtCantidad.Text));
            this._tempera = tempera;
            //MessageBox.Show(Tempera.mostrar(tempera));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
