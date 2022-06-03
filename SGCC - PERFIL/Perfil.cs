using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SGCC___PERFIL
{
    public partial class Perfil : Form
    {
        String Modo = string.Empty;
        string ModoMensalidade = string.Empty;
        string date;


        string[] ValoresInscricao = new string[1000];
        string[] valorMensalidade = new string[1000];
        string[] valorCartao = new string[1000];
        string[] valorCertificado = new string[1000];

        string[] valorEnergia = new string[1000];
        string[] valorCombustivel = new string[1000];
        string[] valorTinteiro = new string[1000];
        string[] valorPapel = new string[1000];
        string[] valorDevolucoes = new string[1000];

        Dialogs.Mensagens Mensagem;


        SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\CentroPerfilBD;Initial Catalog=BD;Integrated Security=True");
        SqlCommand ComandoSQL;
        string StringSQL;
        SqlDataAdapter DA;
        SqlDataReader DR;
        public Perfil(string usuario, string password)
        {
            InitializeComponent();
        }


        private void StatsEntrada()
        {
            //Valor de Inscrição
            try
            {
                StringSQL = "select inscricoes from RelatorioEntrada";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                ValoresInscricao = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            //valor de Mensalidade
            try
            {
                StringSQL = "select mensalidade from RelatorioEntrada";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorMensalidade = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            //valor cartão
            try
            {
                StringSQL = "select cartao from RelatorioEntrada";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorCartao = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            //valor certificado
            try
            {
                StringSQL = "select certficado from RelatorioEntrada";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorCertificado = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void StatsSaida()
        {
            //Valor de energia
            try
            {
                StringSQL = "select pagamentoEnergia from RelatorioSaida";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorEnergia = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            //valor de combustivel do gerador
            try
            {
                StringSQL = "select combustivelGerador from RelatorioSaida";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorCombustivel = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            //valor tinteiro
            try
            {
                StringSQL = "select compraTinteiro from RelatorioSaida";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorTinteiro = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            //valor papeis
            try
            {
                StringSQL = "select compraResmaPapeis from RelatorioSaida";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorPapel = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            //valor devoluções
            try
            {
                StringSQL = "select devolucoes from RelatorioSaida";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                List<string> lst = new List<string>();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                valorDevolucoes = lst.ToArray();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        private void SetarDadosGerais()
        {
            SetarDadosDGV_Cursos();
            SetarDadosDGV_Formadores();
            SetarDadosDGV_Formandos();
            lblStatsFormandos.Text = dgvVistaFormandos.Rows.Count.ToString();
            lblStatsFormadores.Text = dgvVistaFormadores.Rows.Count.ToString();
            lblStatsCursos.Text = dgvVistaCursos.Rows.Count.ToString();
        }

        private void SetarDadosDGV_Mensalidade()
        {
            try
            {
                StringSQL = "select formando, curso, mensalidade, mensalidadeAt from Formandos";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvVistaMensalidade.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvVistaMensalidade.Columns.Count; i++)
                {
                    dgvVistaMensalidade.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvVistaMensalidade.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvVistaMensalidade.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvVistaMensalidade.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvVistaMensalidade.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvVistaMensalidade.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvVistaMensalidade.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvVistaMensalidade.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvVistaMensalidade.Columns[i].HeaderText = "Formando";
                    }
                    else if (i == 1)
                    {
                        dgvVistaMensalidade.Columns[i].HeaderText = "Curso";
                    }
                    else if (i == 2)
                    {
                        dgvVistaMensalidade.Columns[i].HeaderText = "Inscrito em";
                    }
                    else if (i == 3)
                    {
                        dgvVistaMensalidade.Columns[i].HeaderText = "Ultimo Mês Pago";
                    }
                    else if (i == 4)
                    {
                        dgvVistaMensalidade.Columns[i].HeaderText = "Início";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();

            }
        }

        private void SetarDadosDGVEdit_Mensalidade()
        {
            try
            {
                StringSQL = "select formando, curso, mensalidade, mensalidadeAt from Formandos";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvEditMensalidade.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvEditMensalidade.Columns.Count; i++)
                {
                    dgvEditMensalidade.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvEditMensalidade.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvEditMensalidade.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvEditMensalidade.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvEditMensalidade.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvEditMensalidade.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvEditMensalidade.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvEditMensalidade.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvEditMensalidade.Columns[i].HeaderText = "Nome Formando";
                    }
                    else if (i == 1)
                    {
                        dgvEditMensalidade.Columns[i].HeaderText = "Curso";
                    }
                    else if (i == 2)
                    {
                        dgvEditMensalidade.Columns[i].HeaderText = "Inscrito em ";
                    }
                    else if (i == 3)
                    {
                        dgvEditMensalidade.Columns[i].HeaderText = "Ultimo Mês Pago";
                    }
                    else if (i == 4)
                    {
                        dgvEditMensalidade.Columns[i].HeaderText = "Gênero";
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }



        }

        private void SetarDadosDGV_Cursos()
        {
            try
            {
                StringSQL = "select * from Cursos";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvVistaCursos.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvVistaCursos.Columns.Count; i++)
                {
                    dgvVistaCursos.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvVistaCursos.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvVistaCursos.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvVistaCursos.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvVistaCursos.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvVistaCursos.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvVistaCursos.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvVistaCursos.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvVistaCursos.Columns[i].HeaderText = "Nº Curso";
                    }
                    else if (i == 1)
                    {
                        dgvVistaCursos.Columns[i].HeaderText = "Nome Curso";
                    }
                    else if (i == 2)
                    {
                        dgvVistaCursos.Columns[i].HeaderText = "Nº de Formandos";
                    }
                    else if (i == 3)
                    {
                        dgvVistaCursos.Columns[i].HeaderText = "Nome Formador";
                    }
                    else if (i == 4)
                    {
                        dgvVistaCursos.Columns[i].HeaderText = "Início";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void SetarDadosDGV_Formandos()
        {
            try
            {
                StringSQL = "select cod_formando, formando, curso, numero_tlf, data from Formandos";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);
                dgvVistaFormandos.DataSource = DS.Tables[0];

                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvVistaFormandos.Columns.Count; i++)
                {
                    dgvVistaFormandos.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvVistaFormandos.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvVistaFormandos.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvVistaFormandos.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvVistaFormandos.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvVistaFormandos.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvVistaFormandos.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvVistaFormandos.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvVistaFormandos.Columns[i].HeaderText = "Nº Formando";
                    }
                    else if (i == 1)
                    {
                        dgvVistaFormandos.Columns[i].HeaderText = "Nome Formando";
                    }
                    else if (i == 2)
                    {
                        dgvVistaFormandos.Columns[i].HeaderText = "Curso que frequenta";
                    }
                    else if (i == 3)
                    {
                        dgvVistaFormandos.Columns[i].HeaderText = "Telefone";
                    }
                    else if (i == 4)
                    {
                        dgvVistaFormandos.Columns[i].HeaderText = "Data de Inscrição";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void SetarDadosDGVEdit_Cursos()
        {
            //Preencher a DGV de edição de Cursos
            try
            {
                StringSQL = "select * from Cursos";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvEditCurso.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvEditCurso.Columns.Count; i++)
                {
                    dgvEditCurso.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvEditCurso.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvEditCurso.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvEditCurso.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvEditCurso.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvEditCurso.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvEditCurso.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvEditCurso.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvEditCurso.Columns[i].HeaderText = "Nº Curso";
                    }
                    else if (i == 1)
                    {
                        dgvEditCurso.Columns[i].HeaderText = "Nome Curso";
                    }
                    else if (i == 2)
                    {
                        dgvEditCurso.Columns[i].HeaderText = "Nº de Formandos";
                    }
                    else if (i == 3)
                    {
                        dgvEditCurso.Columns[i].HeaderText = "Nome Formador";
                    }
                    else if (i == 4)
                    {
                        dgvEditCurso.Columns[i].HeaderText = "Início";
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void SetarDadosDGV_Formadores()
        {
            try
            {
                StringSQL = "select * from Formadores";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvVistaFormadores.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvVistaFormadores.Columns.Count; i++)
                {
                    dgvVistaFormadores.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvVistaFormadores.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvVistaFormadores.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvVistaFormadores.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvVistaFormadores.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvVistaFormadores.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvVistaFormadores.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvVistaFormadores.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvVistaFormadores.Columns[i].HeaderText = "Nº Formador";
                    }
                    else if (i == 1)
                    {
                        dgvVistaFormadores.Columns[i].HeaderText = "Nome Formador";
                    }
                    else if (i == 2)
                    {
                        dgvVistaFormadores.Columns[i].HeaderText = "Curso que Leciona";
                    }
                    else if (i == 3)
                    {
                        dgvVistaFormadores.Columns[i].HeaderText = "Telefone";
                    }
                    else if (i == 4)
                    {
                        dgvVistaFormadores.Columns[i].HeaderText = "Nº BI";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void SetarDadosDGV_RelatoriosEntrada()
        {
            try
            {
                string data = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                StringSQL = "select * from RelatorioEntrada";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvRelatorioEntrada.DataSource = DS.Tables[0];

                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvRelatorioEntrada.Columns.Count; i++)
                {
                    dgvRelatorioEntrada.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvRelatorioEntrada.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvRelatorioEntrada.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvRelatorioEntrada.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvRelatorioEntrada.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvRelatorioEntrada.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvRelatorioEntrada.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvRelatorioEntrada.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Nº Registo";
                    }
                    else if (i == 1)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Inscrição";
                    }
                    else if (i == 2)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Mensalidade";
                    }
                    else if (i == 3)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Cartão";
                    }
                    else if (i == 4)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Certificado";
                    }
                    else if (i == 5)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Curso";
                    }
                    else if (i == 6)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Hora";
                    }
                    else if (i == 7)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Operador";
                    }
                    else if (i == 8)
                    {
                        dgvRelatorioEntrada.Columns[i].HeaderText = "Registado aos...";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void SetarDadosDGV_RelatoriosSaida()
        {
            try
            {
                string data = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                StringSQL = "select * from RelatorioSaida";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvRelatorioSaida.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvRelatorioSaida.Columns.Count; i++)
                {
                    dgvRelatorioSaida.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvRelatorioSaida.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvRelatorioSaida.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvRelatorioSaida.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvRelatorioSaida.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvRelatorioSaida.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvRelatorioSaida.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvRelatorioSaida.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Nº Registo";
                    }
                    else if (i == 1)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Energia";
                    }
                    else if (i == 2)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Combustivel do Gerador";
                    }
                    else if (i == 3)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Tinteiros";
                    }
                    else if (i == 4)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Resma de Papeis";
                    }
                    else if (i == 5)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Devoluções";
                    }
                    else if (i == 6)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Outro";
                    }
                    else if (i == 7)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Quantidade";
                    }
                    else if (i == 8)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Hora";
                    }
                    else if (i == 9)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Operador";
                    }
                    else if (i == 10)
                    {
                        dgvRelatorioSaida.Columns[i].HeaderText = "Registado em...";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void SetarDadosDGV_Usuarios()
        {
            try
            {
                StringSQL = "select cod, usuario, tipo from Conta";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvUsuarios.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvUsuarios.Columns.Count; i++)
                {
                    dgvUsuarios.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvUsuarios.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvUsuarios.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvUsuarios.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvUsuarios.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvUsuarios.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvUsuarios.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvUsuarios.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvUsuarios.Columns[i].HeaderText = "Nº Conta";
                    }
                    else if (i == 1)
                    {
                        dgvUsuarios.Columns[i].HeaderText = "Usuário";
                    }
                    else if (i == 2)
                    {
                        dgvUsuarios.Columns[i].HeaderText = "Tipo de Conta";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void SetarDadosDGVEdit_Formadores()
        {
            //Preencher a DGV de edição de formadores
            try
            {
                StringSQL = "select * from Formadores";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvEditFormador.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvEditFormador.Columns.Count; i++)
                {
                    dgvEditFormador.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvEditFormador.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvEditFormador.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvEditFormador.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvEditFormador.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvEditFormador.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvEditFormador.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvEditFormador.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvEditFormador.Columns[i].HeaderText = "Nº Formador";
                    }
                    else if (i == 1)
                    {
                        dgvEditFormador.Columns[i].HeaderText = "Nome Formador";
                    }
                    else if (i == 2)
                    {
                        dgvEditFormador.Columns[i].HeaderText = "Curso que Leciona";
                    }
                    else if (i == 3)
                    {
                        dgvEditFormador.Columns[i].HeaderText = "Telefone";
                    }
                    else if (i == 4)
                    {
                        dgvEditFormador.Columns[i].HeaderText = "Nº BI";
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void SetarDadosDGVEdit_Formandos()
        {
            //Preencher a DGV de edição de Cursos
            try
            {
                StringSQL = "select cod_formando, formando, curso, sexo, numero_tlf, " +
                    "numeroBI, " +
                    "numeroPassaporte, " +
                    "naturalidade, " +
                    "moradaProvincia, " +
                    "periodo, " +
                    "horario " +
                    "from Formandos";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvEditFormando.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvEditFormando.Columns.Count; i++)
                {
                    dgvEditFormando.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvEditFormando.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvEditFormando.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvEditFormando.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvEditFormando.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvEditFormando.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvEditFormando.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvEditFormando.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Nº Formando";
                    }
                    else if (i == 1)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Nome Formando";
                    }
                    else if (i == 2)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Curso";
                    }
                    else if (i == 3)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Gênero";
                    }
                    else if (i == 4)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Contacto";
                    }
                    else if (i == 5)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Nº BI";
                    }
                    else if (i == 6)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Nº Passaporte";
                    }
                    else if (i == 7)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Naturalidade";
                    }
                    else if (i == 8)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Provincia";
                    }
                    else if (i == 9)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Periodo";
                    }
                    else if (i == 10)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Horario";
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaginaStats_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.DodgerBlue;
            btn_stats.ForeColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.Image = Properties.Resources.status_branco;

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_cursos.Image = BackgroundImage = Properties.Resources.curso;

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formadores.Image = Properties.Resources.formadores;

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formandos.Image = Properties.Resources.formandos;

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);
            btn_logout.Image = Properties.Resources.logout;

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);
            btn_mensalidade.Image = Properties.Resources.Mensalidade;

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);
            btn_opc.Image = Properties.Resources.Opções;

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            btn_settings.Image = Properties.Resources.Config;

            paginas.SelectedTab = status;

            StatsEntrada();
            SetarDados_Grafico();

            //if( btn_stats.Image == Properties.Resources.status)
            //{
            //    btn_stats.Image = Properties.Resources.status_branco;
            //}
            //else if( btn_stats.Image == Properties.Resources.status_branco)
            //{
            //    btn_stats.Image = Properties.Resources.status;
            //}

        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            SetarDadosDGV_Cursos();

            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);
            btn_stats.Image = Properties.Resources.status;

            btn_cursos.BaseColor = Color.DodgerBlue;
            btn_cursos.ForeColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.Image = Properties.Resources.curso_branco;

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formandos.Image = Properties.Resources.formandos;

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formadores.Image = Properties.Resources.formadores;

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);
            btn_logout.Image = Properties.Resources.logout;

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);
            btn_mensalidade.Image = Properties.Resources.Mensalidade;
            //btn_mensalidade.Image = Properties.Resources.

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);
            btn_opc.Image = Properties.Resources.Opções;

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            btn_settings.Image = Properties.Resources.Config;

            paginas.SelectedTab = cursos;
        }

        private void btn_formandos_Click(object sender, EventArgs e)
        {
            SetarDadosDGV_Formandos();

            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);
            btn_stats.Image = Properties.Resources.status;


            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_cursos.Image = BackgroundImage = Properties.Resources.curso;

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formadores.Image = Properties.Resources.formadores;

            btn_formandos.BaseColor = Color.DodgerBlue;
            btn_formandos.ForeColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.Image = Properties.Resources.formandos_branco;

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);
            btn_logout.Image = Properties.Resources.logout;

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);
            btn_mensalidade.Image = Properties.Resources.Mensalidade;

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);
            btn_opc.Image = Properties.Resources.Opções;

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            btn_settings.Image = Properties.Resources.Config;

            paginas.SelectedTab = formandos;

            //if (btn_formandos.Image == Properties.Resources.formandos)
            //{
            //    btn_formandos.Image = Properties.Resources.formadores_branco;
            //}
            //else if(btn_formandos.Image == Properties.Resources.formandos_branco)
            //{
            //    btn_formandos.Image = Properties.Resources.status;
            //}
        }

        private void btn_formadores_Click(object sender, EventArgs e)
        {
            SetarDadosDGV_Formadores();

            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);
            btn_stats.Image = Properties.Resources.status;

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_cursos.Image = BackgroundImage = Properties.Resources.curso;

            btn_formadores.BaseColor = Color.DodgerBlue;
            btn_formadores.ForeColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.Image = Properties.Resources.formadores_branco;

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formandos.Image = Properties.Resources.formandos;

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);
            btn_logout.Image = Properties.Resources.logout;

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);
            btn_mensalidade.Image = Properties.Resources.Mensalidade;

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);
            btn_opc.Image = Properties.Resources.Opções;

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            btn_settings.Image = Properties.Resources.Config;

            paginas.SelectedTab = formadores;

        }

        private void btn_mensalidade_Click(object sender, EventArgs e)
        {
            SetarDadosDGV_Mensalidade();

            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);
            btn_stats.Image = Properties.Resources.status;

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_cursos.Image = BackgroundImage = Properties.Resources.curso;

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formadores.Image = Properties.Resources.formadores;

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formandos.Image = Properties.Resources.formandos;

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);
            btn_logout.Image = Properties.Resources.logout;

            btn_mensalidade.BaseColor = Color.DodgerBlue;
            btn_mensalidade.ForeColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.Image = Properties.Resources.Mensalidade_branco;

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);
            btn_opc.Image = Properties.Resources.Opções;

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            btn_settings.Image = Properties.Resources.Config;

            paginas.SelectedTab = mensalidade;
        }

        private void btn_opc_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);
            btn_stats.Image = Properties.Resources.status;

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_cursos.Image = Properties.Resources.curso;

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formadores.Image = Properties.Resources.formadores;

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formandos.Image = Properties.Resources.formandos;

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);
            btn_logout.Image = Properties.Resources.logout;

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);
            btn_mensalidade.Image = Properties.Resources.Mensalidade;

            btn_opc.BaseColor = Color.DodgerBlue;
            btn_opc.ForeColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.Image = Properties.Resources.Opções_branco;

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            btn_settings.Image = Properties.Resources.Config;
            //paginas.SelectedTab = ;

            paginas.SelectedTab = opcoes;
        }

        //private void btn_GerenCursos_Click(object sender, EventArgs e)
        //{
        //    paginas.SelectedTab = gestao_curso;
        //}

        //private void btn_GerenFormandos_Click(object sender, EventArgs e)
        //{
        //    paginas.SelectedTab = gestao_fomandos;
        //}

        //private void btnGerenFrormadores_Click(object sender, EventArgs e)
        //{
        //    paginas.SelectedTab = gestao_formadores;
        //}

        private void btn_settings_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);
            btn_stats.Image = Properties.Resources.status;

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_cursos.Image = Properties.Resources.curso;

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formadores.Image = Properties.Resources.formadores;

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);
            btn_formandos.Image = Properties.Resources.formandos;

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);
            btn_logout.Image = Properties.Resources.logout;

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);
            btn_mensalidade.Image = Properties.Resources.Mensalidade;

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);
            btn_opc.Image = Properties.Resources.Opções;

            btn_settings.BaseColor = Color.DodgerBlue;
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            btn_settings.Image = Properties.Resources.Config_branco;
            //paginas.SelectedTab = ;

            paginas.SelectedTab = definicoes;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerenFormandos_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = gestao_fomandos;
            SetarComboBox(cbxCursoFormando);
            SetarDadosDGVEdit_Formandos();
        }

        private void btnGerenCursos_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = gestao_curso;
            SetarComboBox(cbxFormador);
            SetarDadosDGVEdit_Cursos();
        }

        private void btnGerenFormadores_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = gestao_formadores;
            SetarComboBox(cbxCursoFormador);
            SetarDadosDGVEdit_Formadores();
        }

        private void btnGerenMensalidade_Click(object sender, EventArgs e)
        {
            SetarDadosDGVEdit_Mensalidade();
            paginas.SelectedTab = gestao_mensalidade;
            SetarMesAPagarMensalidade();

        }

        private void btnNovoCurso_Click(object sender, EventArgs e)
        {
            //Adicionar novo Registo(Curso)

            if (Modo == "Adição")
            {
                if (!ErroCampos("curso"))
                {
                    try
                    {

                        StringSQL = "insert into Cursos (curso, n_formandos, formador, data_inicio) " +
                            "values (@curso, @n_formandos, @formador, @data_inicio)";
                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        //ComandoSQL.Parameters.AddWithValue("@cod", txtNumeroCurso.Text);
                        ComandoSQL.Parameters.AddWithValue("@curso", txtNomeCurso.Text);
                        ComandoSQL.Parameters.AddWithValue("@n_formandos", 3);
                        ComandoSQL.Parameters.AddWithValue("@formador", cbxFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@data_inicio", dtpInicioCurso.Text);

                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception E)
                    {

                        MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        MessageBox.Show("Novo Curso Adicionado Com Sucesso!", "Novo Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaCampos();
                        SetarDadosDGVEdit_Cursos();
                        SetarDadosGerais();
                        Modo = "";
                        btnNovoCurso.Text = "Novo Curso";
                        Campos("curso", "desativar");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Falha ao inserir novo curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Modo = "Adição";
                btnNovoCurso.Text = "Adicionar Curso";
                Campos("curso", "ativar");
            }
        }

        private void btnNovoFormadores_Click(object sender, EventArgs e)
        {
            //Adicionar novo Registo(Formmador)

            if (Modo == "Adição")
            {
                if (!ErroCampos("formadores"))
                {
                    try
                    {
                        StringSQL = "insert into Formadores (formador, curso, numero_tlf, numero_BI) " +
                            "values (@formador, @curso, @numero_tlf, @numero_BI)";
                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        //ComandoSQL.Parameters.AddWithValue("@cod", txtCodFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@formador", txtNomeFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@curso", cbxCursoFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@numero_tlf", txtNumeroTlfFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@numero_BI", txtNumeroBIFormador.Text);

                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception E)
                    {

                        MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        StringSQL = null;
                        MessageBox.Show("Novo Formador Adicionado Com Sucesso!", "Novo formador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaCampos();
                        SetarDadosGerais();
                        SetarDadosDGVEdit_Formadores();
                        Modo = "";
                        btnNovoFormadores.Text = "Novo Formador";
                        Campos("formador", "desativar");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios", "Erro ao adicionar novo formador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Modo = "Adição";
                btnNovoFormadores.Text = "Adicionar Formador";
                Campos("formador", "ativar");
            }
        }

        private void gunaDataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetarMesAPagarMensalidade()
        {
            if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Janeiro")
            {
                txtMensalidadeMesPago.SelectedIndex = 1;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Fevereiro")
            {
                txtMensalidadeMesPago.SelectedIndex = 2;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Março")
            {
                txtMensalidadeMesPago.SelectedIndex = 3;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Abril")
            {
                txtMensalidadeMesPago.SelectedIndex = 4;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Maio")
            {
                txtMensalidadeMesPago.SelectedIndex = 5;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Junho")
            {
                txtMensalidadeMesPago.SelectedIndex = 6;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Julho")
            {
                txtMensalidadeMesPago.SelectedIndex = 7;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Agosto")
            {
                txtMensalidadeMesPago.SelectedIndex = 8;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Setembro")
            {
                txtMensalidadeMesPago.SelectedIndex = 9;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Outubro")
            {
                txtMensalidadeMesPago.SelectedIndex = 10;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Novembro")
            {
                txtMensalidadeMesPago.SelectedIndex = 11;
            }
            else if (dgvEditMensalidade.SelectedRows[0].Cells[2].Value.ToString().Trim() == "Dezembro")
            {
                txtMensalidadeMesPago.SelectedIndex = 0;
            }
        }
        private void SetarComboBox(Guna.UI.WinForms.GunaComboBox cbx)
        {
            try
            {
                if (cbx.Name == "cbxFormador")
                {
                    StringSQL = "select * from Formadores";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);
                    DataSet DS = new DataSet();
                    DA = new SqlDataAdapter(StringSQL, conexao);
                    conexao.Open();
                    DA.Fill(DS);

                    List<string> lst = new List<string>();
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lst.Add(DS.Tables[0].Rows[i].ItemArray[1].ToString());
                    }

                    cbx.DataSource = lst;
                }
                else if (cbx.Name == "cbxCursoFormador" || cbx.Name == "cbxCursoFormando" || cbx.Name == "cbxMensalidadeCurso")
                {
                    StringSQL = "select * from Cursos";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);
                    DataSet DS = new DataSet();
                    DA = new SqlDataAdapter(StringSQL, conexao);
                    conexao.Open();
                    DA.Fill(DS);

                    List<string> lst = new List<string>();
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lst.Add(DS.Tables[0].Rows[i].ItemArray[1].ToString());
                    }

                    cbx.DataSource = lst;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void cbxFormador_Click(object sender, EventArgs e)
        {
            //SetarComboBox(cbxFormador);
        }

        private void gestao_fomandos_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Eliminar Este Curso?", "Eliminar Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    StringSQL = "delete from Cursos where cod=@cod";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@cod", dgvEditCurso.SelectedCells[0].Value);
                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    MessageBox.Show("Curso Eliminado com Sucesso!", "Eliminar curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetarDadosDGVEdit_Cursos();
                }
            }
        }

        private void btnNovoFormando_Click(object sender, EventArgs e)
        {


            if (Modo == "Adição")
            {
                if (!ErroCampos("formandos"))
                {
                    try
                    {
                        StringSQL = "insert into Formandos (" +
                            "formando, " +
                            "curso, " +
                            "numero_tlf, " +
                            "sexo, " +
                            "numeroBI, " +
                            "numeroPassaporte, " +
                            "naturalidade, " +
                            "moradaProvincia, " +
                            "periodo, " +
                            "data, " +
                            "horario, " +
                            "pagamentoCert, " +
                            "mensalidade," +
                            "mensalidadeAt, " +
                            "pagamentoCart)" +
                            "values (" +
                            "@formando, " +
                            "@curso, " +
                            "@numero_tlf, " +
                            "@sexo, " +
                            "@numeroBI, " +
                            "@numeroPassaporte, " +
                            "@naturalidade, " +
                            "@moradaProvincia, " +
                            "@periodo, " +
                            "@data, " +
                            "@horario, " +
                            "@pagamentoCert, " +
                            "@mensalidade, " +
                            "@mensalidadeAt, " +
                            "@pagamentoCart)";

                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        //ComandoSQL.Parameters.AddWithValue("@cod_formando", txtCodFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("@formando", txtNomeFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("@curso", cbxCursoFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("@numero_tlf", txtNumeroTlfFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("sexo", rbtnSexoMasculinoFormando.Checked ? "Masculino" : "Femenino");
                        string IDBI = string.Empty;
                        string IDPASS = string.Empty;
                        if (rbtnIDBI.Checked) { IDBI = txtIDBI.Text; } else if (rbtnIDPassaporte.Checked) { IDPASS = txtIDPassaporte.Text; } else { IDBI = "Outro"; IDPASS = "Outro"; }
                        ComandoSQL.Parameters.AddWithValue("@numeroBI", IDBI);
                        ComandoSQL.Parameters.AddWithValue("@numeroPassaporte", IDPASS);
                        ComandoSQL.Parameters.AddWithValue("@naturalidade", txtNaturalidade.Text);
                        ComandoSQL.Parameters.AddWithValue("@moradaProvincia", txtMoradaProv.Text);
                        ComandoSQL.Parameters.AddWithValue("@periodo", cbxPeriodo.Text);
                        ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                        ComandoSQL.Parameters.AddWithValue("@horario", cbxHorario.Text);
                        ComandoSQL.Parameters.AddWithValue("@pagamentoCert", chbxPagamentoCertificado.Checked ? "Sim" : "Não");
                        ComandoSQL.Parameters.AddWithValue("@pagamentoCart", chbxPagamentoCartao.Checked ? "Sim" : "Não");
                        //string mes = Mes(DateTime.Now.Month);
                        //string nMes = Mes(DateTime.Now.Month);
                        //string mesPagamento = "";
                        //if (chbxPagamentoMes.Checked) { mesPagamento = mes; }else { mesPagamento = nMes; }
                        ComandoSQL.Parameters.AddWithValue("@mensalidade", Mes(DateTime.Now.Month));
                        ComandoSQL.Parameters.AddWithValue("@mensalidadeAt", "Primeiro Pagamento a se fazer");


                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        StringSQL = string.Empty;
                        MessageBox.Show("Novo Formando Adicionado Com Sucesso!", "Novo Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Gerar Relatório
                        RelatorioEntrada(Properties.Precario.Default.inscricao.ToString(), "", chbxPagamentoCartao.Checked ? Properties.Precario.Default.cartao_formando.ToString() : "", chbxPagamentoCertificado.Checked ? Properties.Precario.Default.certificado.ToString() : "", cbxCursoFormando.Text, "Juciano Silva");

                        LimpaCampos();
                        SetarDadosGerais();
                        SetarDadosDGVEdit_Formandos();
                        btnNovoFormando.Text = "Novo Formando";
                        Modo = "";
                        Campos("formando", "desativar");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro ao adicionar novo formando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Modo = "Adição";
                btnNovoFormando.Text = "Adicionar Formando";
                Campos("formando", "ativar");
            }
        }

        private void btnEliminarFormandos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar este formando?", "Eliminar formando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    StringSQL = "delete from Formandos where cod_formando=@cod_formando";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@cod_formando", dgvEditFormando.SelectedCells[0].Value);
                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    MessageBox.Show("Formando Eliminado Com Sucesso!", "Eliminar Formando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    SetarDadosDGVEdit_Formandos();
                }
            }
        }

        private void btnEliminarFormador_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar este formador?", "Eliminar Formador", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    StringSQL = "delete from Formadores where cod=@cod";
                    ComandoSQL = new SqlCommand(StringSQL, conexao);

                    ComandoSQL.Parameters.AddWithValue("@cod", dgvEditFormador.SelectedCells[0].Value);
                    conexao.Open();
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    MessageBox.Show("Formador Eliminado com SUcesso", "Eliminar formador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    SetarDadosDGVEdit_Formadores();
                }
            }
        }

        private void LimpaCampos()
        {
            txtCodFormador.Text = "";
            txtCodFormando.Text = "";
            txtIDBI.Text = "";
            txtIDPassaporte.Text = "";
            txtMoradaProv.Text = "";
            txtNaturalidade.Text = "";
            txtNomeCurso.Text = "";
            txtNomeFormador.Text = "";
            txtNomeFormando.Text = "";
            txtNumeroBIFormador.Text = "";
            txtNumeroTlfFormador.Text = "";
            txtNumeroTlfFormando.Text = "";
            txtPesquisaFormadores.Text = "";
            txtPesquisaFormandos.Text = "";
            txt_pesquisaCursos.Text = "";
            cbxCursoFormador.Text = "";
            cbxCursoFormando.Text = "";
            cbxFormador.Text = "";
            cbxHorario.Text = "";
            //cbxPagamentoMes.Text = "";
            cbxPeriodo.Text = "";
            txtNomeUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void TruncateCodigos()
        {
            //Para Cursos
            try
            {
                StringSQL = "truncate table Cursos";
                ComandoSQL = new SqlCommand(StringSQL, conexao);
                conexao.Open();
                ComandoSQL.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

            //Para Formandos
            try
            {
                StringSQL = "truncate table Formandos";
                ComandoSQL = new SqlCommand(StringSQL, conexao);
                conexao.Open();
                ComandoSQL.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

            //Para Formadores
            try
            {
                StringSQL = "truncate table Formadores";
                ComandoSQL = new SqlCommand(StringSQL, conexao);
                conexao.Open();
                ComandoSQL.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SetarUltimoPagamento()
        {
            try
            {
                StringSQL = "update Formandos set mensalidadeAt = Propinas.mesPago " +
                    "where Formandos.formando = Propinas.formando";
                ComandoSQL = new SqlCommand(StringSQL, conexao);

                conexao.Open();
                ComandoSQL.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetarDadosDGVEdit_Mensalidade();
                conexao.Close();
            }
        }

        private void btnNovoPagamento_Click(object sender, EventArgs e)
        {

            if (ModoMensalidade == "Pagar")
            {
                if (!ErroCampos("mensalidade"))
                {
                    try
                    {
                        StringSQL = "update Formandos set mensalidadeAt = @mensalidadeAt" +
                            " where formando = @formando";

                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        //ComandoSQL.Parameters.AddWithValue("@periodo", cbxMensalidadePeriodo.Text);
                        ComandoSQL.Parameters.AddWithValue("@formando", txtMensalidadeFormando.Text);
                        //ComandoSQL.Parameters.AddWithValue("@horario", cbxMensalidadeHorario.Text);
                        ComandoSQL.Parameters.AddWithValue("@mensalidadeAt", txtMensalidadeMesPago.Text);

                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        MessageBox.Show("Pagamento Efeito", "Pagamento de Mensalidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetarDadosGerais();
                        SetarDadosDGVEdit_Mensalidade();
                        Modo = string.Empty;
                        btnNovoPagamento.Enabled = false;
                        txtMensalidadeMesPago.Enabled = false;

                        //Gerar Relatório
                        RelatorioEntrada("", Properties.Precario.Default.mensalidade.ToString(), "", "", "", "Juciano Silva");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro fazer o pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ModoMensalidade = "Pagar";
                btnNovoPagamento.Enabled = true;
                txtMensalidadeMesPago.Enabled = true;
                btnNovoPagamento.Text = "Efetuar Pagamento";
            }


        }

        private void dgvEditMensalidade_Click(object sender, EventArgs e)
        {
            txtMensalidadeFormando.Text = dgvEditMensalidade.SelectedRows[0].Cells[0].Value.ToString();
            SetarMesAPagarMensalidade();
        }

        private string Mes(int mes)
        {
            string ReturnMes = "";
            if (mes == 1)
            {
                ReturnMes = "Janeiro";
            }
            else if (mes == 2)
            {
                ReturnMes = "Fevereiro";
            }
            else if (mes == 3)
            {
                ReturnMes = "Março";
            }
            else if (mes == 4)
            {
                ReturnMes = "Abril";
            }
            else if (mes == 5)
            {
                ReturnMes = "Maio";
            }
            else if (mes == 6)
            {
                ReturnMes = "Junho";
            }
            else if (mes == 7)
            {
                ReturnMes = "Julho";
            }
            else if (mes == 8)
            {
                ReturnMes = "Agosto";
            }
            else if (mes == 9)
            {
                ReturnMes = "Setembro";
            }
            else if (mes == 10)
            {
                ReturnMes = "Outubro";
            }
            else if (mes == 11)
            {
                ReturnMes = "Novembro";
            }
            else if (mes == 12)
            {
                ReturnMes = "Dezembro";
            }



            return ReturnMes;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            SetarDadosGerais();
            Campos("formador", "desativar");
            Campos("Curso", "desativar");
            Campos("formando", "Desativar");
            StatsCursos();
            StatsFormandos();
            StatsEntrada();
            StatsSaida();
            SetarDados_Grafico();

        }

        private void SetarDados_Grafico()
        {
            if (Properties.Config.Default.DadosGraficoEntrada == "Inscrição")
            {
                int vInscri = 0;
                for (int i = 0; i < ValoresInscricao.Length; i++)
                {
                    if (ValoresInscricao[i] != "")
                    {
                        vInscri += int.Parse(ValoresInscricao[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[0].SetValueY(vInscri);
            }
            else if (Properties.Config.Default.DadosGraficoEntrada == "Mensalidade")
            {
                int vMens = 0;
                for (int i = 0; i < valorMensalidade.Length; i++)
                {
                    if (valorMensalidade[i] != "")
                    {
                        vMens += int.Parse(valorMensalidade[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[0].SetValueY(vMens);
            }
            else if (Properties.Config.Default.DadosGraficoEntrada == "Cartão")
            {
                int vCart = 0;
                for (int i = 0; i < valorCartao.Length; i++)
                {
                    if (valorCartao[i] != "")
                    {
                        vCart += int.Parse(valorCartao[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[0].SetValueY(vCart);
            }
            else if (Properties.Config.Default.DadosGraficoEntrada == "Certificado")
            {
                int vCert = 0;
                for (int i = 0; i < valorCertificado.Length; i++)
                {
                    if (valorCertificado[i] != "")
                    {
                        vCert += int.Parse(valorCertificado[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[0].SetValueY(vCert);
            }

            if (Properties.Config.Default.DadosGraficoSaida == "Energia")
            {
                int vEnergia = 0;
                for (int i = 0; i < valorEnergia.Length; i++)
                {
                    if (valorEnergia[i] != "")
                    {
                        vEnergia += int.Parse(valorEnergia[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[1].SetValueY(vEnergia);
            }
            else if (Properties.Config.Default.DadosGraficoSaida == "Combustivel")
            {
                int vCombus = 0;
                for (int i = 0; i < valorCombustivel.Length; i++)
                {
                    if (valorCombustivel[i] != "")
                    {
                        vCombus += int.Parse(valorCombustivel[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[1].SetValueY(vCombus);
            }
            else if (Properties.Config.Default.DadosGraficoSaida == "Tinteiro")
            {
                int vTinteiro = 0;
                for (int i = 0; i < valorTinteiro.Length; i++)
                {
                    if (valorTinteiro[i] != "")
                    {
                        vTinteiro += int.Parse(valorTinteiro[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[1].SetValueY(vTinteiro);
            }
            else if (Properties.Config.Default.DadosGraficoSaida == "Papeis")
            {
                int vPapeis = 0;
                for (int i = 0; i < valorPapel.Length; i++)
                {
                    if (valorPapel[i] != "")
                    {
                        vPapeis += int.Parse(valorPapel[i]);
                    }
                }

                DataPoint point = new DataPoint(2, 1293);
                statsGrafico.Series[0].Points[1].SetValueY(vPapeis);
            }
        }

        private void StatsCursos()
        {
            try
            {
                StringSQL = "select top 10 curso, formador from Cursos " +
                    "order by cod desc";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvStatsCursos.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvStatsCursos.Columns.Count; i++)
                {
                    dgvStatsCursos.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvStatsCursos.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvStatsCursos.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvStatsCursos.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvStatsCursos.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvStatsCursos.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvStatsCursos.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvStatsCursos.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvStatsCursos.Columns[i].HeaderText = "Curso";
                    }
                    else if (i == 1)
                    {
                        dgvStatsCursos.Columns[i].HeaderText = "Formador";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao carregar dados da Base de Dados - " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void StatsFormandos()
        {
            try
            {
                StringSQL = "select top 8 formando, curso from Formandos " +
                    "order by cod_formando desc";

                DataSet DS = new DataSet();
                DA = new SqlDataAdapter(StringSQL, conexao);
                conexao.Open();
                DA.Fill(DS);

                dgvStatsformandos.DataSource = DS.Tables[0];
                //Loop para adicionar e editar colunas da DGV
                for (int i = 0; i < dgvStatsformandos.Columns.Count; i++)
                {
                    dgvStatsformandos.Columns[i].Resizable = DataGridViewTriState.False;
                    dgvStatsformandos.Columns[i].HeaderCell.Style.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    //dgvStatsformandos.Columns[i].DefaultCellStyle.BackColor = Color.Black;
                    dgvStatsformandos.Columns[i].DataGridView.AllowUserToAddRows = false;
                    dgvStatsformandos.Columns[i].DataGridView.AllowUserToDeleteRows = false;
                    dgvStatsformandos.Columns[i].DataGridView.AllowUserToResizeColumns = false;
                    dgvStatsformandos.Columns[i].DataGridView.AllowUserToResizeRows = false;
                    dgvStatsformandos.Columns[i].DataGridView.ReadOnly = true;
                    if (i == 0)
                    {
                        dgvStatsformandos.Columns[i].HeaderText = "Formando";
                    }
                    else if (i == 1)
                    {
                        dgvStatsformandos.Columns[i].HeaderText = "Curso";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao carregar dados da Base de Dados - " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (Modo == "Edição")
            {
                if (!ErroCampos("Curso"))
                {
                    try
                    {
                        StringSQL = "update Cursos set curso = @curso, " +
                            "formador = @formador, " +
                            "data_inicio = @data_inicio " +
                            "where cod = @cod";
                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        ComandoSQL.Parameters.AddWithValue("@cod", dgvEditCurso.SelectedRows[0].Cells[0].Value);
                        ComandoSQL.Parameters.AddWithValue("@curso", txtNomeCurso.Text);
                        ComandoSQL.Parameters.AddWithValue("@formador", cbxFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@data_inicio", dtpInicioCurso.Text);

                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        SetarDadosDGVEdit_Cursos();
                        SetarDadosGerais();
                        btnEditarCurso.Text = "Editar Curso";
                        Modo = string.Empty;
                        Campos("curso", "desativar");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro ao editar o curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Modo = "Edição";
                btnEditarCurso.Text = "Guardar Alterações";
                Campos("Curso", "ativar");
            }
        }

        private void btnEditarFormador_Click(object sender, EventArgs e)
        {
            if (Modo == "Edição")
            {
                if (!ErroCampos("formadores"))
                {
                    try
                    {
                        StringSQL = "update Formadores set formador = @formador, curso = @curso, " +
                            "numero_tlf = @numero_tlf, " +
                            "numero_BI = @numero_BI " +
                            "where cod = @cod";
                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        ComandoSQL.Parameters.AddWithValue("@cod", dgvEditFormador.SelectedRows[0].Cells[0].Value);
                        ComandoSQL.Parameters.AddWithValue("@formador", txtNomeFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@curso", cbxCursoFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@numero_tlf", txtNumeroTlfFormador.Text);
                        ComandoSQL.Parameters.AddWithValue("@numero_BI", txtNumeroBIFormador.Text);

                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        SetarDadosDGVEdit_Formadores();
                        SetarDadosGerais();
                        btnEditarFormador.Text = "Editar Formador";
                        Modo = string.Empty;
                        Campos("formador", "desativar");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os dados obrigatórios.", "Erro ao editar formador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Modo = "Edição";
                btnEditarFormador.Text = "Guardar Alterações";
                Campos("formador", "ativar");
            }
        }

        private void dgvEditFormador_Click(object sender, EventArgs e)
        {
            txtNomeFormador.Text = dgvEditFormador.SelectedRows[0].Cells[1].Value.ToString();
            txtNumeroTlfFormador.Text = dgvEditFormador.SelectedRows[0].Cells[3].Value.ToString();
            cbxCursoFormador.Text = dgvEditFormador.SelectedRows[0].Cells[2].Value.ToString();
            txtNumeroBIFormador.Text = dgvEditFormador.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void Campos(string campos, string modo)
        {
            if (modo.ToLower() == "ativar")
            {
                if (campos.ToLower() == "formador")
                {
                    txtCodFormador.Enabled = true;
                    txtNomeFormador.Enabled = true;
                    cbxCursoFormador.Enabled = true;
                    txtNumeroTlfFormador.Enabled = true;
                    txtNumeroBIFormador.Enabled = true;
                }
                else if (campos.ToLower() == "curso")
                {
                    txtNomeCurso.Enabled = true;
                    cbxFormador.Enabled = true;
                    dtpInicioCurso.Enabled = true;
                    dtpFimCurso.Enabled = true;
                }
                else if (campos.ToLower() == "formando")
                {
                    txtNomeFormando.Enabled = true;
                    cbxCursoFormando.Enabled = true;
                    txtNumeroTlfFormando.Enabled = true;
                    rbtnSexoFemeninoFormando.Enabled = true;
                    rbtnSexoMasculinoFormando.Enabled = true;
                    rbtnIDPassaporte.Enabled = true;
                    rbtnIDBI.Enabled = true;
                    rbtnIDOutro.Enabled = true;
                    txtIDBI.Enabled = true;
                    txtIDPassaporte.Enabled = true;
                    txtNaturalidade.Enabled = true;
                    txtMoradaProv.Enabled = true;
                    cbxPeriodo.Enabled = true;
                    cbxHorario.Enabled = true;
                }
                else if (campos.ToLower() == "conta")
                {
                    txtNomeUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                }
            }
            else if (modo.ToLower() == "desativar")
            {
                if (campos.ToLower() == "formador")
                {
                    txtCodFormador.Enabled = false;
                    txtNomeFormador.Enabled = false;
                    cbxCursoFormador.Enabled = false;
                    txtNumeroTlfFormador.Enabled = false;
                    txtNumeroBIFormador.Enabled = false;
                }
                else if (campos.ToLower() == "curso")
                {
                    txtNomeCurso.Enabled = false;
                    cbxFormador.Enabled = false;
                    dtpInicioCurso.Enabled = false;
                    dtpFimCurso.Enabled = false;
                }
                else if (campos.ToLower() == "formando")
                {
                    txtNomeFormando.Enabled = false;
                    cbxCursoFormando.Enabled = false;
                    txtNumeroTlfFormando.Enabled = false;
                    rbtnSexoFemeninoFormando.Enabled = false;
                    rbtnSexoMasculinoFormando.Enabled = false;
                    rbtnIDPassaporte.Enabled = false;
                    rbtnIDBI.Enabled = false;
                    rbtnIDOutro.Enabled = false;
                    txtIDBI.Enabled = false;
                    txtIDPassaporte.Enabled = false;
                    txtNaturalidade.Enabled = false;
                    txtMoradaProv.Enabled = false;
                    cbxPeriodo.Enabled = false;
                    cbxHorario.Enabled = false;
                }
                else if (campos.ToLower() == "conta")
                {
                    txtNomeUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                }
            }

        }

        private void dgvEditCurso_Click(object sender, EventArgs e)
        {
            txtNomeCurso.Text = dgvEditCurso.SelectedRows[0].Cells[1].Value.ToString();
            cbxFormador.Text = dgvEditCurso.SelectedRows[0].Cells[3].Value.ToString();
            dtpInicioCurso.Text = dgvEditCurso.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void btnEditarFormando_Click(object sender, EventArgs e)
        {
            if (Modo == "Edição")
            {
                if (!ErroCampos("formandos"))
                {
                    try
                    {
                        StringSQL = "update Formandos set " +
                            "formando = @formando, " +
                            "curso = @curso, " +
                            "numero_tlf = @numero_tlf, " +
                            "sexo = @sexo, " +
                            "numeroBI = @numeroBI, " +
                            "numeroPassaporte = @numeroPassaporte, " +
                            "naturalidade = @naturalidade, " +
                            "moradaProvincia = @moradaProvincia, " +
                            "periodo = @periodo, " +
                            "data = @data, " +
                            "horario = @horario " +
                            "where cod_formando = @cod_formando";

                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        //ComandoSQL.Parameters.AddWithValue("@cod_formando", txtCodFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("@cod_formando", dgvEditFormando.SelectedRows[0].Cells[0].Value);
                        ComandoSQL.Parameters.AddWithValue("@formando", txtNomeFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("@curso", cbxCursoFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("@numero_tlf", txtNumeroTlfFormando.Text);
                        ComandoSQL.Parameters.AddWithValue("sexo", rbtnSexoMasculinoFormando.Checked ? "Masculino" : "Femenino");
                        string IDBI = string.Empty;
                        string IDPASS = string.Empty;
                        if (rbtnIDBI.Checked) { IDBI = txtIDBI.Text; } else if (rbtnIDPassaporte.Checked) { IDPASS = txtIDPassaporte.Text; } else { IDBI = "Outro"; IDPASS = "Outro"; }
                        ComandoSQL.Parameters.AddWithValue("@numeroBI", IDBI);
                        ComandoSQL.Parameters.AddWithValue("@numeroPassaporte", IDPASS);
                        ComandoSQL.Parameters.AddWithValue("@naturalidade", txtNaturalidade.Text);
                        ComandoSQL.Parameters.AddWithValue("@moradaProvincia", txtMoradaProv.Text);
                        ComandoSQL.Parameters.AddWithValue("@periodo", cbxPeriodo.Text);
                        ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Date);
                        ComandoSQL.Parameters.AddWithValue("@horario", cbxHorario.Text);


                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        SetarDadosDGVEdit_Formandos();
                        SetarDadosGerais();
                        btnEditarFormando.Text = "Editar Formando";
                        Modo = string.Empty;
                        Campos("formando", "desativar");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro ao editar formando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Modo = "Edição";
                btnEditarFormando.Text = "Guardar Alterações";
                Campos("Formando", "ativar");
            }
        }

        private void dgvEditFormando_Click(object sender, EventArgs e)
        {
            txtNomeFormando.Text = dgvEditFormando.SelectedRows[0].Cells[1].Value.ToString();
            cbxCursoFormando.Text = dgvEditFormando.SelectedRows[0].Cells[2].Value.ToString();
            if (dgvEditFormando.SelectedRows[0].Cells[3].Value.ToString().Trim() == "Masculino")
            {
                rbtnSexoMasculinoFormando.Checked = true;
            }
            else
            {
                rbtnSexoFemeninoFormando.Checked = true;
            }
            txtNumeroTlfFormando.Text = dgvEditFormando.SelectedRows[0].Cells[4].Value.ToString();
            if (dgvEditFormando.SelectedRows[0].Cells[5].Value.ToString().Trim() != "")
            {
                txtIDBI.Text = dgvEditFormando.SelectedRows[0].Cells[5].Value.ToString();
            }
            else
            {
                txtIDPassaporte.Text = dgvEditFormando.SelectedRows[0].Cells[6].Value.ToString();
            }
            txtNaturalidade.Text = dgvEditFormando.SelectedRows[0].Cells[7].Value.ToString();
            txtMoradaProv.Text = dgvEditFormando.SelectedRows[0].Cells[8].Value.ToString();
            cbxPeriodo.Text = dgvEditFormando.SelectedRows[0].Cells[9].Value.ToString().Trim();
            cbxHorario.Text = dgvEditFormando.SelectedRows[0].Cells[10].Value.ToString().Trim();

        }

        private void RelatorioEntrada(string vInsc, string vMens, string vCart, string vCert, string Curso, string operador)
        {
            try
            {
                StringSQL = "insert into RelatorioEntrada(inscricoes, mensalidade, cartao, certficado, curso, hora, operador, data) values (@inscricoes, @mensalidade, @cartao, @certficado, @curso, @hora, @operador, @data)";

                ComandoSQL = new SqlCommand(StringSQL, conexao);

                ComandoSQL.Parameters.AddWithValue("@inscricoes", vInsc);
                ComandoSQL.Parameters.AddWithValue("@mensalidade", vMens);
                ComandoSQL.Parameters.AddWithValue("@cartao", vCart);
                ComandoSQL.Parameters.AddWithValue("@certficado", vCert);
                ComandoSQL.Parameters.AddWithValue("@curso", Curso);
                ComandoSQL.Parameters.AddWithValue("@operador", operador);
                ComandoSQL.Parameters.AddWithValue("@hora", DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);

                conexao.Open();
                ComandoSQL.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VerRelatorios_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = relatorioEntrada;
            SetarDadosDGV_RelatoriosEntrada();
        }

        private void btnGerenUsuarios_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = usuarios;
            SetarDadosDGV_Usuarios();
        }

        private bool ErroCampos(string campos)
        {
            bool erro = false;

            if (campos == "curso")
            {
                if (txtNomeCurso.Text == "" || cbxFormador.Text == "")
                {
                    erro = true;
                }
            }
            else if (campos == "formandos")
            {
                if (txtNomeFormando.Text == "" || cbxCursoFormando.Text == "" || txtNaturalidade.Text == "" || cbxPeriodo.Text == "" || cbxHorario.Text == "")
                {
                    erro = true;
                }
            }
            else if (campos == "formadores")
            {
                if (txtNomeFormador.Text == "" || cbxCursoFormador.Text == "" || txtNumeroTlfFormador.Text == "" || txtNumeroBIFormador.Text == "")
                {
                    erro = true;
                }
            }
            else if (campos == "mensalidade")
            {
                if (txtMensalidadeFormando.Text == "" || txtMensalidadeMesPago.Text == "")
                {
                    erro = true;
                }
            }
            else if (campos == "conta")
            {
                if (txtNomeUsuario.Text == "" || txtPassword.Text == "")
                {
                    erro = true;
                }
            }
            return erro;
        }

        private void btn_verRegistos_Click(object sender, EventArgs e)
        {
            //Dialogs.dlg_TodosRegistos frm = new Dialogs.dlg_TodosRegistos();
            //frm.ShowDialog();

            paginas.SelectedTab = relatorioSaida;
            SetarDadosDGV_RelatoriosSaida();
        }

        private void btnVerRelatorioEntrada_Click(object sender, EventArgs e)
        {
            paginas.SelectedTab = relatorioEntrada;
            SetarDadosDGV_RelatoriosEntrada();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGerarRegistos_Saida_Click(object sender, EventArgs e)
        {
            Form dlg = new Dialogs.dl_GerarRegistoSaida();
            dlg.ShowDialog();
        }

        private void btn_addUsuario_Click(object sender, EventArgs e)
        {
            if (Modo == "Adição")
            {
                if (!ErroCampos("conta"))
                {
                    try
                    {

                        StringSQL = "insert into Conta (usuario, senha, tipo) " +
                            "values (@usuario, @senha, @tipo)";
                        ComandoSQL = new SqlCommand(StringSQL, conexao);

                        string tipo = "";
                        if (rbtn_admin.Checked == true)
                        {
                            tipo = "Administrador";
                        }
                        else if (rbtn_dg.Checked == true)
                        {
                            tipo = "Director Geral";
                        }
                        else if (rbtn_secretario.Checked == true)
                        {
                            tipo = "Secretário";
                        }

                        //ComandoSQL.Parameters.AddWithValue("@cod", txtNumeroCurso.Text);
                        ComandoSQL.Parameters.AddWithValue("@usuario", txtNomeUsuario.Text);
                        ComandoSQL.Parameters.AddWithValue("@senha", txtPassword.Text);
                        ComandoSQL.Parameters.AddWithValue("@tipo", tipo);

                        conexao.Open();
                        ComandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception E)
                    {
                        Mensagem = new Dialogs.Mensagens(E.Message, "Erro");
                        Mensagem.Show();
                        Mensagem.Dispose();

                    }
                    finally
                    {
                        conexao.Close();
                        Mensagem = new Dialogs.Mensagens("Novo Usuário Adicionado Com Sucesso!", "Novo Usuário");
                        Mensagem.Show();
                        Mensagem.Dispose();

                        LimpaCampos();
                        SetarDadosDGV_Usuarios();
                        SetarDadosGerais();
                        Modo = "";
                        btn_addUsuario.Text = "Novo Usuário";
                        Campos("conta", "desativar");
                    }
                }
                else
                {

                    Mensagem = new Dialogs.Mensagens("Preencha todos os campos obrigatórios.", "Falha ao adicionar usuário.");
                    Mensagem.Show();
                    Mensagem.Dispose();

                }
            }
            else
            {
                Modo = "Adição";
                btn_addUsuario.Text = "Adicionar Usuário";
                Campos("conta", "ativar");
            }
        }
    }

}
