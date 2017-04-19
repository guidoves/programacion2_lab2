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
                this.comboBox1.Items.Add(i);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tempera tempera = new Tempera((ConsoleColor)comboBox1.SelectedItem,(String)textBox1.Text,int.Parse(textBox3.Text));
            this._tempera = tempera;
            //MessageBox.Show(Tempera.mostrar(tempera));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
