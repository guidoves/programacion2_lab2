﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void Manejador(string nombre)
        {
            this.label1.Text = nombre;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)this.Owner).del -= this.Manejador;
        }

         
    }
}
