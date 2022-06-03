using System;
using System.Windows.Forms;

namespace SGCC___PERFIL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form form = new Perfil(txtNomeUsuario.Text, txtPassword.Text);
            form.Show();
            this.Hide();
        }
    }
}
