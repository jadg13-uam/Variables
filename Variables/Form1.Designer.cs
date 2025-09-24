namespace Variables
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.lblVariableLocal = new System.Windows.Forms.Label();
            this.lblVariableGlobal = new System.Windows.Forms.Label();
            this.btnVerificarG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(114, 24);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(310, 30);
            this.tbNombre.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(114, 75);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(148, 30);
            this.tbCodigo.TabIndex = 3;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(37, 127);
            this.BtnVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(203, 58);
            this.BtnVerificar.TabIndex = 4;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblVariableLocal
            // 
            this.lblVariableLocal.AutoSize = true;
            this.lblVariableLocal.Location = new System.Drawing.Point(32, 222);
            this.lblVariableLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariableLocal.Name = "lblVariableLocal";
            this.lblVariableLocal.Size = new System.Drawing.Size(136, 25);
            this.lblVariableLocal.TabIndex = 5;
            this.lblVariableLocal.Text = "Variable Local";
            // 
            // lblVariableGlobal
            // 
            this.lblVariableGlobal.AutoSize = true;
            this.lblVariableGlobal.Location = new System.Drawing.Point(32, 279);
            this.lblVariableGlobal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariableGlobal.Name = "lblVariableGlobal";
            this.lblVariableGlobal.Size = new System.Drawing.Size(145, 25);
            this.lblVariableGlobal.TabIndex = 6;
            this.lblVariableGlobal.Text = "Variable Global";
            // 
            // btnVerificarG
            // 
            this.btnVerificarG.Location = new System.Drawing.Point(259, 127);
            this.btnVerificarG.Name = "btnVerificarG";
            this.btnVerificarG.Size = new System.Drawing.Size(195, 58);
            this.btnVerificarG.TabIndex = 7;
            this.btnVerificarG.Text = "Verificar Global";
            this.btnVerificarG.UseVisualStyleBackColor = true;
            this.btnVerificarG.Click += new System.EventHandler(this.btnVerificarG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 332);
            this.Controls.Add(this.btnVerificarG);
            this.Controls.Add(this.lblVariableGlobal);
            this.Controls.Add(this.lblVariableLocal);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label lblVariableLocal;
        private System.Windows.Forms.Label lblVariableGlobal;
        private System.Windows.Forms.Button btnVerificarG;
    }
}

