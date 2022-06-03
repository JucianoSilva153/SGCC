
namespace SGCC___PERFIL.Dialogs
{
    partial class Mensagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.lbl_tituloMsg = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_ok = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_tituloMsg);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 35);
            this.panel1.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(456, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // lbl_tituloMsg
            // 
            this.lbl_tituloMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloMsg.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloMsg.Location = new System.Drawing.Point(5, 2);
            this.lbl_tituloMsg.Name = "lbl_tituloMsg";
            this.lbl_tituloMsg.Size = new System.Drawing.Size(291, 30);
            this.lbl_tituloMsg.TabIndex = 49;
            this.lbl_tituloMsg.Text = "Titulo da Mensagem";
            this.lbl_tituloMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_msg
            // 
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_msg.Location = new System.Drawing.Point(8, 41);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(472, 175);
            this.lbl_msg.TabIndex = 50;
            this.lbl_msg.Text = "Titulo da Mensagem";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_ok
            // 
            this.btn_ok.AnimationHoverSpeed = 0.07F;
            this.btn_ok.AnimationSpeed = 0.03F;
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.BorderColor = System.Drawing.Color.Black;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ok.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Image = null;
            this.btn_ok.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ok.Location = new System.Drawing.Point(130, 219);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ok.OnHoverImage = null;
            this.btn_ok.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ok.Radius = 10;
            this.btn_ok.Size = new System.Drawing.Size(212, 42);
            this.btn_ok.TabIndex = 51;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Mensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 269);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensagens";
            this.Load += new System.EventHandler(this.Mensagens_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label lbl_tituloMsg;
        private System.Windows.Forms.Label lbl_msg;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaButton btn_ok;
    }
}