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
    public partial class FrmMostrar1 : Form
    {

        public FrmMostrar1()
        {
            InitializeComponent();
            
        }
        public FrmMostrar1(List<Tempera> temperas):this()
        {
            foreach(Tempera i in temperas)
            {
                listBox1.Items.Add(Tempera.mostrar(i));
            }
               
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
