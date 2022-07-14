using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGCC___PERFIL.Dialogs
{
    public partial class dlg_FirstTime : Form
    {
        bool configPadrao = true;
        

        public dlg_FirstTime()
        {
            InitializeComponent();
            this.Hide();
        }

        private void btn_comecar_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = tipoConfig;
        }

        private void btnConfigPers_Click(object sender, EventArgs e)
        {
            configPadrao = false;
            paginas.SelectedTab = conexaoBD;
        }

        private void btnConfigDefault_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = contAdmin;
            configPadrao = true;
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
        
            if(btnTestarConexao.Text == "Testar Conexão")
            {
                bool Erro = false;
                SqlConnection conexao = new SqlConnection(txtConexaoBD.Text);

                try
                {
                    string StringSQL = "select tipo from Conta";
                    SqlDataAdapter DA = new SqlDataAdapter(StringSQL, conexao);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);

                    conexao.Open();
                }
                catch (Exception erro)
                {
                    Mensagens mensagens = new Mensagens("Teste Falhado: " + erro.Message, "Teste de Conexão");
                    Erro = true;
                    mensagens.ShowDialog();
                }
                finally
                {
                    conexao.Close();
                    if (!Erro)
                    {
                        Mensagens mensagens = new Mensagens("Teste de conexão da base dados concluido.", "Teste de Conexão");
                        Properties.Config.Default.ConexaoPersonalizada = txtConexaoBD.Text;
                        btnTestarConexao.Text = "Seguinte";
                    }
                }
            }
            else
            {
                paginas.SelectedTab = contAdmin;
            }


        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguintePrecario_Click(object sender, EventArgs e)
        {
            if(txt_precarioCartao.Text != "" || txt_precarioCertificado.Text != "" || txt_precarioInscricao.Text != "" || txt_precarioMensalidade.Text != "")
            {
                Properties.Precario.Default.mensalidade = int.Parse(txt_precarioMensalidade.Text);
                Properties.Precario.Default.inscricao = int.Parse(txt_precarioInscricao.Text);
                Properties.Precario.Default.certificado = int.Parse(txt_precarioCertificado.Text);
                Properties.Precario.Default.cartao_formando = int.Parse(txt_precarioCartao.Text);
                Properties.Precario.Default.Save();
                Properties.Precario.Default.Upgrade();

                paginas.SelectedTab = terminar;
            }
        }

        private void btnSeguinteAdmin_Click(object sender, EventArgs e)
        {
            if(txtNomeUsuario.Text != "" || txtPassword.Text != "")
            {
                SqlConnection conexao;
                if (configPadrao)
                {
                    conexao = new SqlConnection(Properties.Config.Default.ConexaoPadrao);
                }
                else
                {
                    conexao = new SqlConnection(Properties.Config.Default.ConexaoPersonalizada);
                }

                try
                {
                    string StringSQL = "insert into Conta(usuario, senha, tipo) values(" + txtNomeUsuario.Text + "," + txtPassword.Text + ", " + "Administrador" + ")";
                    SqlCommand command = new SqlCommand(StringSQL, conexao);

                    conexao.Open();
                }
                catch (Exception err)
                {
                    Mensagens Mensagem = new Mensagens(err.Message, "Erro ao Adicionar Administrador");
                    Mensagem.ShowDialog();
                }
                finally
                {
                    conexao.Close();
                    paginas.SelectedTab = precario;
                }
            }
        }

        private void dlg_FirstTime_Load(object sender, EventArgs e)
        {
            if (Properties.Config.Default.FirstTime == false)
            {
                Form login = new frmLogin(false);
                login.Show();

                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
