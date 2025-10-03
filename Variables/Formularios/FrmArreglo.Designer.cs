namespace Variables.Formularios
{
    partial class FrmArreglo
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
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMayorDe = new System.Windows.Forms.Label();
            this.lblMenorEdad = new System.Windows.Forms.Label();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblMenorEdad);
            this.gbEdades.Controls.Add(this.lblMayorDe);
            this.gbEdades.Controls.Add(this.lblMenor);
            this.gbEdades.Controls.Add(this.lblMayor);
            this.gbEdades.Controls.Add(this.lblPromedio);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.tbEdad);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Location = new System.Drawing.Point(16, 10);
            this.gbEdades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEdades.Size = new System.Drawing.Size(141, 355);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades: 0";
            this.gbEdades.Enter += new System.EventHandler(this.gbEdades_Enter);
            // 
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(13, 275);
            this.lblMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(116, 19);
            this.lblMenor.TabIndex = 5;
            this.lblMenor.Text = "Menor: 0";
            // 
            // lblMayor
            // 
            this.lblMayor.Location = new System.Drawing.Point(14, 249);
            this.lblMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(116, 19);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Mayor: 0";
            this.lblMayor.Click += new System.EventHandler(this.lblMayor_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(14, 219);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(116, 19);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio: 0";
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.Location = new System.Drawing.Point(15, 62);
            this.lbEdades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(116, 147);
            this.lbEdades.TabIndex = 2;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(15, 39);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(117, 20);
            this.tbEdad.TabIndex = 1;
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Edad";
            // 
            // lblMayorDe
            // 
            this.lblMayorDe.Location = new System.Drawing.Point(14, 303);
            this.lblMayorDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayorDe.Name = "lblMayorDe";
            this.lblMayorDe.Size = new System.Drawing.Size(116, 19);
            this.lblMayorDe.TabIndex = 6;
            this.lblMayorDe.Text = "Mayores de edad:";
            // 
            // lblMenorEdad
            // 
            this.lblMenorEdad.Location = new System.Drawing.Point(14, 326);
            this.lblMenorEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenorEdad.Name = "lblMenorEdad";
            this.lblMenorEdad.Size = new System.Drawing.Size(116, 19);
            this.lblMenorEdad.TabIndex = 7;
            this.lblMenorEdad.Text = "Menores de edad:";
            this.lblMenorEdad.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 403);
            this.Controls.Add(this.gbEdades);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmArreglo";
            this.Text = "Arreglos";
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMenorEdad;
        private System.Windows.Forms.Label lblMayorDe;
    }
}