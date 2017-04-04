namespace WindowsFormsCosa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.formEntero = new System.Windows.Forms.Label();
            this.FormFecha = new System.Windows.Forms.Label();
            this.FormCadena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(58, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(170, 186);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(96, 36);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(100, 20);
            this.txtEntero.TabIndex = 2;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(96, 82);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(96, 122);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // formEntero
            // 
            this.formEntero.AutoSize = true;
            this.formEntero.Location = new System.Drawing.Point(43, 36);
            this.formEntero.Name = "formEntero";
            this.formEntero.Size = new System.Drawing.Size(38, 13);
            this.formEntero.TabIndex = 5;
            this.formEntero.Text = "Entero";
            // 
            // FormFecha
            // 
            this.FormFecha.AutoSize = true;
            this.FormFecha.Location = new System.Drawing.Point(43, 129);
            this.FormFecha.Name = "FormFecha";
            this.FormFecha.Size = new System.Drawing.Size(37, 13);
            this.FormFecha.TabIndex = 6;
            this.FormFecha.Text = "Fecha";
            // 
            // FormCadena
            // 
            this.FormCadena.AutoSize = true;
            this.FormCadena.Location = new System.Drawing.Point(43, 85);
            this.FormCadena.Name = "FormCadena";
            this.FormCadena.Size = new System.Drawing.Size(44, 13);
            this.FormCadena.TabIndex = 7;
            this.FormCadena.Text = "Cadena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.FormCadena);
            this.Controls.Add(this.FormFecha);
            this.Controls.Add(this.formEntero);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Cosa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label formEntero;
        private System.Windows.Forms.Label FormFecha;
        private System.Windows.Forms.Label FormCadena;
    }
}

