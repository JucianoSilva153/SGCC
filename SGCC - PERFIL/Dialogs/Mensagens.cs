using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCC___PERFIL.Dialogs
{
    public partial class Mensagens : Form
    {
        string Mensagem;
        string Titulo;
        public Mensagens(string msg, string titulo)
        {
            InitializeComponent();
            Mensagem = msg;
            Titulo = titulo;
        }

        private void Mensagens_Load(object sender, EventArgs e)
        {
            lbl_msg.Text = Mensagem;
            lbl_tituloMsg.Text = Titulo;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
