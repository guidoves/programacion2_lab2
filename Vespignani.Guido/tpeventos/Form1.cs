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
    public partial class Form1 : Form
    {
        
        public delegate void Delegado(string nombre);
        public Delegado del;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            
            Form2 f2 = new Form2();
            f2.Show(this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            del = new Delegado(f3.Manejador);
            f3.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
