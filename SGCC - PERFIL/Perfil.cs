using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCC___PERFIL
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
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

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);

            paginas.SelectedTab = status;

        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);

            btn_cursos.BaseColor = Color.DodgerBlue;
            btn_cursos.ForeColor = Color.FromKnownColor(KnownColor.Control);

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);

            paginas.SelectedTab = cursos;
        }

        private void btn_formandos_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formandos.BaseColor = Color.DodgerBlue;
            btn_formandos.ForeColor = Color.FromKnownColor(KnownColor.Control);

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);

            paginas.SelectedTab = formandos;
        }

        private void btn_formadores_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formadores.BaseColor = Color.DodgerBlue;
            btn_formadores.ForeColor = Color.FromKnownColor(KnownColor.Control);

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);

            paginas.SelectedTab = formadores;
        }

        private void btn_mensalidade_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);

            btn_mensalidade.BaseColor = Color.DodgerBlue;
            btn_mensalidade.ForeColor = Color.FromKnownColor(KnownColor.Control);

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromArgb(151, 151, 151);

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);

            paginas.SelectedTab = mensalidade;
        }

        private void btn_opc_Click(object sender, EventArgs e)
        {
            btn_stats.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_stats.ForeColor = Color.FromArgb(151, 151, 151);

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);

            btn_opc.BaseColor = Color.DodgerBlue;
            btn_opc.ForeColor = Color.FromKnownColor(KnownColor.Control);

            btn_settings.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
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

            btn_cursos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_cursos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formadores.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formadores.ForeColor = Color.FromArgb(151, 151, 151);

            btn_formandos.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_formandos.ForeColor = Color.FromArgb(151, 151, 151);

            btn_logout.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_logout.ForeColor = Color.FromArgb(151, 151, 151);

            btn_mensalidade.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_mensalidade.ForeColor = Color.FromArgb(151, 151, 151);

            btn_opc.BaseColor = Color.FromKnownColor(KnownColor.Control);
            btn_opc.ForeColor = Color.FromKnownColor(KnownColor.Control);

            btn_settings.BaseColor = Color.DodgerBlue;
            btn_settings.ForeColor = Color.FromArgb(151, 151, 151);
            //paginas.SelectedTab = ;

            paginas.SelectedTab = definicoes;
        }
    }
}
