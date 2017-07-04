using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpeventos
{
    public partial class FrmPrincipal : Form
    {
        
        public delegate void Delegado(string nombre);
        public Delegado del;

        public FrmPrincipal()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            
            FrmTestDelegados f2 = new FrmTestDelegados();
            f2.Show(this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDatos f3 = new FrmDatos();
            del = new Delegado(f3.Manejador);
            f3.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
