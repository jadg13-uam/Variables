using System;

using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        int contador = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
           // tbUser.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
           // tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logear();
        }

        private void Logear()
        {
            if (Login(tbUser.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                contador++;
                MessageBox.Show("Contraseña invalidad");
            }
            if (contador == 3)
            {
                MessageBox.Show("Usted ha excedido los intentos.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
