using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;



namespace SGCC___PERFIL
{
    public partial class frmLogin : Form
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;database=centro_bd;uID=root;pwd=;");
        MySqlCommand ComandoSQL;
        string StringSQL;
        MySqlDataAdapter DA;
        MySqlDataReader DR;
        string usuaro = Environment.UserName;

        bool Erro;
        Dialogs.Mensagens Mensagem = new Dialogs.Mensagens("Usuário ou Palavra-Passe incorreta!", "Erro de Credenciais");
        public frmLogin(bool erro)
        {
                InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                StringSQL = "select usuario, senha from Conta where usuario = '" + txtNomeUsuario.Text + "' and senha = '" + txtPassword.Text + "'";
                MySqlDataAdapter DA = new MySqlDataAdapter(StringSQL, conexao);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                conexao.Open();
                if (DT.Rows.Count < 1)
                {
                    Mensagem = new Dialogs.Mensagens("Usuário ou Palavra-Passe Incorreta!", "Erro de Credenciais");
                    Mensagem.ShowDialog();
                }
                else
                {
                    if (txtNomeUsuario.Text == "root")
                    {
                        Mensagem = new Dialogs.Mensagens("Logado como Administrador do Sistema!", "Login Efetuado");
                        Mensagem.ShowDialog();

                        this.Hide();
                        Form main = new Perfil(txtNomeUsuario.Text);
                        main.Show();
                    }
                    else
                    {
                        Mensagem = new Dialogs.Mensagens("Bem vindo(a) " + txtNomeUsuario.Text, "Login Efetuado");
                        Mensagem.ShowDialog();

                        this.Hide();
                        Form main = new Perfil(txtNomeUsuario.Text);
                        main.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Mensagem = new Dialogs.Mensagens(ex.Message, "Erro de Login");
                Mensagem.ShowDialog();
            }
            finally
            {
                conexao.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Erro)
            {
                Mensagem.ShowDialog();
            }
        }
    }
}
