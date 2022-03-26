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
    public partial class Perfil : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\CentroPerfilBD;Initial Catalog=BD;Integrated Security=True");
        SqlCommand ComandoSQL;
        string StringSQL;
        SqlDataAdapter DA;
        SqlDataReader DR;
        public Perfil()
        {
            InitializeComponent();
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
                        dgvVistaMensalidade.Columns[i].HeaderText = "Nome Formando";
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
                MessageBox.Show(e.Message);
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
                MessageBox.Show(E.Message);
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
                MessageBox.Show(e.Message);
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
                MessageBox.Show(e.Message);
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
                MessageBox.Show(E.Message);
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
                MessageBox.Show(e.Message);
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
                MessageBox.Show(E.Message);
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
                StringSQL = "select * from Formandos";

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
                        dgvEditFormando.Columns[i].HeaderText = "Telefone";
                    }
                    else if (i == 4)
                    {
                        dgvEditFormando.Columns[i].HeaderText = "Gênero";
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
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

                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Novo Curso Adicionado Com Sucesso!");
                LimpaCampos();
                SetarDadosDGVEdit_Cursos();
            }
        }

        private void btnNovoFormadores_Click(object sender, EventArgs e)
        {
            //Adicionar novo Registo(Formmador)
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

                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
                StringSQL = null;
                MessageBox.Show("Novo Formador Adicionado Com Sucesso!");
                LimpaCampos();
                SetarDadosDGVEdit_Formadores();
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
                MessageBox.Show(E.Message);
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
                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Curso Eliminado com Sucesso!");
                SetarDadosDGVEdit_Cursos();
            }
        }

        private void btnNovoFormando_Click(object sender, EventArgs e)
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
                    "mensalidadeAt)" +
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
                    "@mensalidade," +
                    " @mensalidadeAt)";

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
                ComandoSQL.Parameters.AddWithValue("@data", DateTime.Now.Date);
                ComandoSQL.Parameters.AddWithValue("@horario", cbxHorario.Text);
                ComandoSQL.Parameters.AddWithValue("@pagamentoCert", chbxPagamentoCertificado.Checked ? "Sim" : "Não");
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
                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
                StringSQL = string.Empty;
                MessageBox.Show("Novo Formando Adicionado Com Sucesso!");
                LimpaCampos();
                SetarDadosDGVEdit_Formandos();
            }
        }

        private void btnEliminarFormandos_Click(object sender, EventArgs e)
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
                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Formando Eliminado Com Sucesso!");
                LimpaCampos();
                SetarDadosDGVEdit_Formandos();
            }
        }

        private void btnEliminarFormador_Click(object sender, EventArgs e)
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
                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Formador Eliminado com SUcesso");
                LimpaCampos();
                SetarDadosDGVEdit_Formadores();
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
            txtNumeroCurso.Text = "";
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
                MessageBox.Show(erro.Message);
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
                MessageBox.Show(erro.Message);
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
                MessageBox.Show(erro.Message);
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
                MessageBox.Show(erro.Message);
            }
            finally
            {
                SetarDadosDGVEdit_Mensalidade();
                conexao.Close();
            }
        }

        private void btnNovoPagamento_Click(object sender, EventArgs e)
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
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Pagamento Efeito");
                SetarDadosDGVEdit_Mensalidade();
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
    }
}
