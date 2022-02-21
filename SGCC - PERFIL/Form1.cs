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

namespace SGCC___PERFIL
{
    public partial class Form1 : Form
    {
        SqlCommand comandoSQL;
        SqlConnection conexao;
        SqlDataAdapter DA;
        SqlDataReader DR;
        string STRConexao = @"Data Source=(localdb)\CENTRO_BD;Initial Catalog=BD CENTRO;Integrated Security=True";
        string strSQL = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(STRConexao);
                strSQL = "insert into Formando (cod, formando, curso, numero_tlf) values(@cod, @formando, @curso, @numero_tlf)";
                comandoSQL = new SqlCommand(strSQL, conexao);

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
             if( txt_cod.Text != string.Empty)
            {
                try
                {
                    conexao = new SqlConnection(STRConexao);
                    strSQL = "select * from Formando where cod = @cod";
                    comandoSQL = new SqlCommand(strSQL, conexao);

                    comandoSQL.Parameters.AddWithValue("@cod", txt_cod.Text);

                    conexao.Open();
                    DR = comandoSQL.ExecuteReader();
                    while (DR.Read())
                    {
                        txt_nome.Text = (string) DR["formando"];
                        txt_curso.Text = (string) DR["curso"];
                        txt_contacto.Text = Convert.ToString(DR["numero_tlf"]);
                    }
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
        }
    }
}
