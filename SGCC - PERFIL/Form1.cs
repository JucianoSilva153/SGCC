using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SGCC___PERFIL
{
    public partial class Form1 : Form
    {
        MySqlCommand comandoSQL;
        MySqlConnection conexao;
        MySqlDataAdapter DA;
        MySqlDataReader DR;
        string STRConexao = @"server=localhost;database=centro_bd;uID=root;pwd=;";
        string strSQL = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(STRConexao);
                strSQL = "insert into Formando (cod, formando, curso, numero_tlf) values(@cod, @formando, @curso, @numero_tlf)";
                comandoSQL = new MySqlCommand(strSQL, conexao);

                comandoSQL.Parameters.AddWithValue("@cod", txt_cod.Text);
                comandoSQL.Parameters.AddWithValue("@formando", txt_nome.Text);
                comandoSQL.Parameters.AddWithValue("@curso", txt_curso.Text);
                comandoSQL.Parameters.AddWithValue("@numero_tlf", txt_contacto.Text);

                conexao.Open();
                comandoSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                strSQL = string.Empty;
                MessageBox.Show("Adicionado com Sucesso");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text != string.Empty)
            {
                try
                {
                    conexao = new MySqlConnection(STRConexao);
                    strSQL = "select * from Formando where cod = @cod";
                    comandoSQL = new MySqlCommand(strSQL, conexao);

                    comandoSQL.Parameters.AddWithValue("@cod", txt_cod.Text);

                    conexao.Open();
                    DR = comandoSQL.ExecuteReader();
                    while (DR.Read())
                    {
                        txt_nome.Text = (string)DR["formando"];
                        txt_curso.Text = (string)DR["curso"];
                        txt_contacto.Text = Convert.ToString(DR["numero_tlf"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    strSQL = string.Empty;
                    MessageBox.Show("Adicionado com Sucesso");
                }
            }
        }
    }
}
