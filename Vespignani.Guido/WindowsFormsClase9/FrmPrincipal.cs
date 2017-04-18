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
    public partial class FrmPrincipal : Form
    {
        private List<Tempera> _temperas;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this._temperas = new List<Tempera>();
        } 

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempera formTempera = new FrmTempera();
            formTempera.StartPosition = FormStartPosition.CenterScreen;
            formTempera.ShowDialog();
            //formTempera.MdiParent = this;
            if(formTempera.DialogResult == System.Windows.Forms.DialogResult.OK)
            this._temperas.Add(formTempera.Tempera);
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar1 formMostrar = new FrmMostrar1(_temperas);
            formMostrar.Show();
        }
    }
}
