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
    public partial class dl_GerarRegistoSaida : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\CentroPerfilBD;Initial Catalog=BD;Integrated Security=True");
        SqlCommand ComandoSQL;
        string StringSQL;
        SqlDataAdapter DA;
        SqlDataReader DR;

        public dl_GerarRegistoSaida()
        {
            InitializeComponent();
        }

        private void btn_concluido_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_relatar.SelectedIndex == 0)
                {
                    StringSQL = "insert into RelatorioSaida (pagamentoEnergia, horas, data, operador) values (@pagamentoEnergia, @horas, @operador, @data)";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@pagamentoEnergia", txtValor.Text);
                    ComandoSQL.Parameters.AddWithValue("@horas", DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                    ComandoSQL.Parameters.AddWithValue("@operador", "Juciano Silva");

                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                else if (cbx_relatar.SelectedIndex == 1)
                {
                    StringSQL = "insert into RelatorioSaida (combustivelGerador, quantidade, horas, data, operador) values (@combustivelGerador, @quantidade, @horas, @operador, @data)";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@combustivelGerador", txtValor.Text);
                    ComandoSQL.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                    ComandoSQL.Parameters.AddWithValue("@horas", DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                    ComandoSQL.Parameters.AddWithValue("@operador", "Juciano Silva");

                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                else if (cbx_relatar.SelectedIndex == 2)
                {
                    StringSQL = "insert into RelatorioSaida (compraTinteiro, quantidade, horas, data, operador) values (@compraTinteiro, @quantidade, @horas, @operador, @data)";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@compraTinteiro", txtValor.Text);
                    ComandoSQL.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                    ComandoSQL.Parameters.AddWithValue("@horas", DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                    ComandoSQL.Parameters.AddWithValue("@operador", "Juciano Silva");

                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                else if (cbx_relatar.SelectedIndex == 3)
                {
                    StringSQL = "insert into RelatorioSaida (compraResmaPapeis, quantidade, horas, data, operador) values (@compraResmaPapeis, @quantidade, @horas, @operador, @data)";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@compraResmaPapeis", txtValor.Text);
                    ComandoSQL.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                    ComandoSQL.Parameters.AddWithValue("@horas", DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                    ComandoSQL.Parameters.AddWithValue("@operador", "Juciano Silva");

                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                else if (cbx_relatar.SelectedIndex == 4)
                {
                    StringSQL = "insert into RelatorioSaida (devolucoes, horas, data, operador) values (@devolucoes,  @horas, @operador, @data)";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@devolucoes", txtValor.Text);
                    ComandoSQL.Parameters.AddWithValue("@horas", DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                    ComandoSQL.Parameters.AddWithValue("@operador", "Juciano Silva");

                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                else if (cbx_relatar.SelectedIndex == 5)
                {
                    StringSQL = "insert into RelatorioSaida (outrasSaidasDe, horas, data, operador) values (@outrasSaidasDe, @horas, @operador, @data)";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@outrasSaidasDe", txtValor.Text);
                    ComandoSQL.Parameters.AddWithValue("@horas", DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                    ComandoSQL.Parameters.AddWithValue("@operador", "Juciano Silva");

                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
            }
            catch (Exception erro)
            {
                Form msg = new Dialogs.Mensagens(erro.Message,"Erro ao Inserir Relatório");
                msg.ShowDialog();
            }
            finally
            {
                conexao.Close();
                this.Close();
                Form msg = new Dialogs.Mensagens("Relatório Efetuado com Sucesso", "Novo Relatório");
            }
        }

        private void cbx_relatar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbx_relatar.SelectedIndex == 0)
            {
                txtValor.Enabled = true;
                txtQuantidade.Enabled = false;
                txtOutro.Enabled = false;
            }
            else if (cbx_relatar.SelectedIndex == 1)
            {
                txtValor.Enabled = true;
                txtQuantidade.Enabled = false;
                txtOutro.Enabled = false;
            }
            else if (cbx_relatar.SelectedIndex == 2)
            {
                txtValor.Enabled = true;
                txtQuantidade.Enabled = true;
                txtOutro.Enabled = false;
            }
            else if (cbx_relatar.SelectedIndex == 3)
            {
                txtValor.Enabled = true;
                txtQuantidade.Enabled = true;
                txtOutro.Enabled = false;
            }
            else if (cbx_relatar.SelectedIndex == 4)
            {
                txtValor.Enabled = true;
                txtQuantidade.Enabled = false;
                txtOutro.Enabled = false;
            }
            else if (cbx_relatar.SelectedIndex == 5)
            {
                txtValor.Enabled = false;
                txtQuantidade.Enabled = false;
                txtOutro.Enabled = true;
            }
        }

        private void cbx_relatar_SelectedValueChanged(object sender, EventArgs e)
        {
        }
    }
}
