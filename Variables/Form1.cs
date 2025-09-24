using System;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables
{
    public partial class Form1 : Form
    {
        Facultad fac = new Facultad();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            Facultad fia = new Facultad();
            fia.Codigo = tbCodigo.Text;
            fia.Nombre = tbNombre.Text;

            fac = fia;
            lblVariableLocal.Text = fia.MostrarDatos();

        }

        private void btnVerificarG_Click(object sender, EventArgs e)
        {
            lblVariableGlobal.Text = fac.MostrarDatos();
        }
    }
}
