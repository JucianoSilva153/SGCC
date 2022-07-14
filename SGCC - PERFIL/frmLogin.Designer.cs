
namespace SGCC___PERFIL
{
    partial class frmLogin
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
            this.btn_Login = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctbx_LogoUser = new Guna.UI.WinForms.GunaPictureBox();
            this.txtNomeUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_LogoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.AnimationHoverSpeed = 0.07F;
            this.btn_Login.AnimationSpeed = 0.03F;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.BorderColor = System.Drawing.Color.Black;
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = null;
            this.btn_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Login.Location = new System.Drawing.Point(514, 275);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Login.OnHoverImage = null;
            this.btn_Login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Login.Radius = 10;
            this.btn_Login.Size = new System.Drawing.Size(212, 42);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pctbx_LogoUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 380);
            this.panel1.TabIndex = 2;
            // 
            // pctbx_LogoUser
            // 
            this.pctbx_LogoUser.BackgroundImage = global::SGCC___PERFIL.Properties.Resources.usuário_branco;
            this.pctbx_LogoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbx_LogoUser.BaseColor = System.Drawing.Color.White;
            this.pctbx_LogoUser.Location = new System.Drawing.Point(39, 40);
            this.pctbx_LogoUser.Name = "pctbx_LogoUser";
            this.pctbx_LogoUser.Size = new System.Drawing.Size(285, 285);
            this.pctbx_LogoUser.TabIndex = 1;
            this.pctbx_LogoUser.TabStop = false;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeUsuario.BaseColor = System.Drawing.Color.White;
            this.txtNomeUsuario.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtNomeUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNomeUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNomeUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomeUsuario.Location = new System.Drawing.Point(429, 96);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.PasswordChar = '\0';
            this.txtNomeUsuario.Radius = 10;
            this.txtNomeUsuario.SelectedText = "";
            this.txtNomeUsuario.Size = new System.Drawing.Size(396, 48);
            this.txtNomeUsuario.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(436, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome de Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(429, 198);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(396, 48);
            this.txtPassword.TabIndex = 39;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(436, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Palavra-Passe";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AnimationHoverSpeed = 0.07F;
            this.btn_cancelar.AnimationSpeed = 0.03F;
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancelar.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = null;
            this.btn_cancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cancelar.Location = new System.Drawing.Point(514, 323);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cancelar.OnHoverImage = null;
            this.btn_cancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cancelar.Radius = 10;
            this.btn_cancelar.Size = new System.Drawing.Size(212, 42);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(821, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaControlBox1.TabIndex = 41;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 380);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Perfil - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_LogoUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_Login;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox pctbx_LogoUser;
        private Guna.UI.WinForms.GunaTextBox txtNomeUsuario;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btn_cancelar;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}