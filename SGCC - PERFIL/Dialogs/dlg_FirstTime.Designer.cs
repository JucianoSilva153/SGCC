
namespace SGCC___PERFIL.Dialogs
{
    partial class dlg_FirstTime
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlg_FirstTime));
            this.paginas = new Bunifu.UI.WinForms.BunifuPages();
            this.boasvindas = new System.Windows.Forms.TabPage();
            this.btn_comecar = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoConfig = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfigPers = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnConfigDefault = new Bunifu.UI.WinForms.BunifuImageButton();
            this.contAdmin = new System.Windows.Forms.TabPage();
            this.btnSeguinteAdmin = new Guna.UI.WinForms.GunaButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtNomeUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaCirclePictureBox9 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.conexaoBD = new System.Windows.Forms.TabPage();
            this.btnTestarConexao = new Guna.UI.WinForms.GunaButton();
            this.txtConexaoBD = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precario = new System.Windows.Forms.TabPage();
            this.btnSeguintePrecario = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txt_precarioCartao = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txt_precarioCertificado = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_precarioMensalidade = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_precarioInscricao = new Guna.UI.WinForms.GunaTextBox();
            this.terminar = new System.Windows.Forms.TabPage();
            this.btn_iniciar = new Guna.UI.WinForms.GunaButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paginas.SuspendLayout();
            this.boasvindas.SuspendLayout();
            this.tipoConfig.SuspendLayout();
            this.contAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox9)).BeginInit();
            this.conexaoBD.SuspendLayout();
            this.precario.SuspendLayout();
            this.terminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // paginas
            // 
            this.paginas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.paginas.AllowTransitions = true;
            this.paginas.Controls.Add(this.boasvindas);
            this.paginas.Controls.Add(this.tipoConfig);
            this.paginas.Controls.Add(this.contAdmin);
            this.paginas.Controls.Add(this.conexaoBD);
            this.paginas.Controls.Add(this.precario);
            this.paginas.Controls.Add(this.terminar);
            this.paginas.Cursor = System.Windows.Forms.Cursors.Default;
            this.paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginas.Location = new System.Drawing.Point(0, 0);
            this.paginas.Multiline = true;
            this.paginas.Name = "paginas";
            this.paginas.Page = this.terminar;
            this.paginas.PageIndex = 5;
            this.paginas.PageName = "terminar";
            this.paginas.PageTitle = "Terminar";
            this.paginas.SelectedIndex = 0;
            this.paginas.Size = new System.Drawing.Size(882, 557);
            this.paginas.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.paginas.Transition = animation1;
            this.paginas.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // boasvindas
            // 
            this.boasvindas.Controls.Add(this.btn_comecar);
            this.boasvindas.Controls.Add(this.label1);
            this.boasvindas.Controls.Add(this.label3);
            this.boasvindas.Cursor = System.Windows.Forms.Cursors.Default;
            this.boasvindas.Location = new System.Drawing.Point(4, 4);
            this.boasvindas.Name = "boasvindas";
            this.boasvindas.Padding = new System.Windows.Forms.Padding(3);
            this.boasvindas.Size = new System.Drawing.Size(874, 531);
            this.boasvindas.TabIndex = 0;
            this.boasvindas.Text = "Boas Vindas";
            this.boasvindas.UseVisualStyleBackColor = true;
            // 
            // btn_comecar
            // 
            this.btn_comecar.AnimationHoverSpeed = 0.07F;
            this.btn_comecar.AnimationSpeed = 0.03F;
            this.btn_comecar.BackColor = System.Drawing.Color.Transparent;
            this.btn_comecar.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_comecar.BorderColor = System.Drawing.Color.Black;
            this.btn_comecar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_comecar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_comecar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_comecar.ForeColor = System.Drawing.Color.White;
            this.btn_comecar.Image = null;
            this.btn_comecar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_comecar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_comecar.Location = new System.Drawing.Point(324, 384);
            this.btn_comecar.Name = "btn_comecar";
            this.btn_comecar.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_comecar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_comecar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_comecar.OnHoverImage = null;
            this.btn_comecar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_comecar.Radius = 10;
            this.btn_comecar.Size = new System.Drawing.Size(212, 42);
            this.btn_comecar.TabIndex = 11;
            this.btn_comecar.Text = "Começar";
            this.btn_comecar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_comecar.Click += new System.EventHandler(this.btn_comecar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(180, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "O Assistente de Primeiro uso do Software irá guiá-lo.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(285, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 94);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seja Bem-vindo(a)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoConfig
            // 
            this.tipoConfig.Controls.Add(this.label5);
            this.tipoConfig.Controls.Add(this.label4);
            this.tipoConfig.Controls.Add(this.label2);
            this.tipoConfig.Controls.Add(this.btnConfigPers);
            this.tipoConfig.Controls.Add(this.btnConfigDefault);
            this.tipoConfig.Cursor = System.Windows.Forms.Cursors.Default;
            this.tipoConfig.Location = new System.Drawing.Point(4, 4);
            this.tipoConfig.Name = "tipoConfig";
            this.tipoConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tipoConfig.Size = new System.Drawing.Size(874, 531);
            this.tipoConfig.TabIndex = 1;
            this.tipoConfig.Text = "Tipo de Configuração";
            this.tipoConfig.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(198, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(481, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Que tipo de configuração deseja?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(508, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Configurações Personalizadas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(97, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Configurações Padrão";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfigPers
            // 
            this.btnConfigPers.ActiveImage = null;
            this.btnConfigPers.AllowAnimations = true;
            this.btnConfigPers.AllowBuffering = false;
            this.btnConfigPers.AllowToggling = false;
            this.btnConfigPers.AllowZooming = true;
            this.btnConfigPers.AllowZoomingOnFocus = false;
            this.btnConfigPers.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigPers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigPers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfigPers.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnConfigPers.ErrorImage")));
            this.btnConfigPers.FadeWhenInactive = false;
            this.btnConfigPers.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnConfigPers.Image = global::SGCC___PERFIL.Properties.Resources.Editar;
            this.btnConfigPers.ImageLocation = null;
            this.btnConfigPers.ImageMargin = 40;
            this.btnConfigPers.ImageSize = new System.Drawing.Size(160, 160);
            this.btnConfigPers.ImageZoomSize = new System.Drawing.Size(200, 200);
            this.btnConfigPers.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnConfigPers.InitialImage")));
            this.btnConfigPers.Location = new System.Drawing.Point(542, 170);
            this.btnConfigPers.Name = "btnConfigPers";
            this.btnConfigPers.Rotation = 0;
            this.btnConfigPers.ShowActiveImage = true;
            this.btnConfigPers.ShowCursorChanges = true;
            this.btnConfigPers.ShowImageBorders = true;
            this.btnConfigPers.ShowSizeMarkers = false;
            this.btnConfigPers.Size = new System.Drawing.Size(200, 200);
            this.btnConfigPers.TabIndex = 0;
            this.btnConfigPers.ToolTipText = "";
            this.btnConfigPers.WaitOnLoad = false;
            this.btnConfigPers.ZoomSpeed = 10;
            this.btnConfigPers.Click += new System.EventHandler(this.btnConfigPers_Click);
            // 
            // btnConfigDefault
            // 
            this.btnConfigDefault.ActiveImage = null;
            this.btnConfigDefault.AllowAnimations = true;
            this.btnConfigDefault.AllowBuffering = false;
            this.btnConfigDefault.AllowToggling = false;
            this.btnConfigDefault.AllowZooming = true;
            this.btnConfigDefault.AllowZoomingOnFocus = false;
            this.btnConfigDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigDefault.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfigDefault.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnConfigDefault.ErrorImage")));
            this.btnConfigDefault.FadeWhenInactive = false;
            this.btnConfigDefault.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnConfigDefault.Image = global::SGCC___PERFIL.Properties.Resources.Config1;
            this.btnConfigDefault.ImageLocation = null;
            this.btnConfigDefault.ImageMargin = 40;
            this.btnConfigDefault.ImageSize = new System.Drawing.Size(160, 160);
            this.btnConfigDefault.ImageZoomSize = new System.Drawing.Size(200, 200);
            this.btnConfigDefault.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnConfigDefault.InitialImage")));
            this.btnConfigDefault.Location = new System.Drawing.Point(109, 170);
            this.btnConfigDefault.Name = "btnConfigDefault";
            this.btnConfigDefault.Rotation = 0;
            this.btnConfigDefault.ShowActiveImage = true;
            this.btnConfigDefault.ShowCursorChanges = true;
            this.btnConfigDefault.ShowImageBorders = true;
            this.btnConfigDefault.ShowSizeMarkers = false;
            this.btnConfigDefault.Size = new System.Drawing.Size(200, 200);
            this.btnConfigDefault.TabIndex = 0;
            this.btnConfigDefault.ToolTipText = "";
            this.btnConfigDefault.WaitOnLoad = false;
            this.btnConfigDefault.ZoomSpeed = 10;
            this.btnConfigDefault.Click += new System.EventHandler(this.btnConfigDefault_Click);
            // 
            // contAdmin
            // 
            this.contAdmin.Controls.Add(this.btnSeguinteAdmin);
            this.contAdmin.Controls.Add(this.label6);
            this.contAdmin.Controls.Add(this.label31);
            this.contAdmin.Controls.Add(this.label47);
            this.contAdmin.Controls.Add(this.txtPassword);
            this.contAdmin.Controls.Add(this.txtNomeUsuario);
            this.contAdmin.Controls.Add(this.gunaCirclePictureBox9);
            this.contAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.contAdmin.Location = new System.Drawing.Point(4, 4);
            this.contAdmin.Name = "contAdmin";
            this.contAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.contAdmin.Size = new System.Drawing.Size(874, 531);
            this.contAdmin.TabIndex = 2;
            this.contAdmin.Text = "Credenciais do Admin";
            this.contAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSeguinteAdmin
            // 
            this.btnSeguinteAdmin.AnimationHoverSpeed = 0.07F;
            this.btnSeguinteAdmin.AnimationSpeed = 0.03F;
            this.btnSeguinteAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnSeguinteAdmin.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnSeguinteAdmin.BorderColor = System.Drawing.Color.Black;
            this.btnSeguinteAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeguinteAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeguinteAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeguinteAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeguinteAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSeguinteAdmin.Image = null;
            this.btnSeguinteAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSeguinteAdmin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeguinteAdmin.Location = new System.Drawing.Point(333, 471);
            this.btnSeguinteAdmin.Name = "btnSeguinteAdmin";
            this.btnSeguinteAdmin.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnSeguinteAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeguinteAdmin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeguinteAdmin.OnHoverImage = null;
            this.btnSeguinteAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeguinteAdmin.Radius = 10;
            this.btnSeguinteAdmin.Size = new System.Drawing.Size(212, 42);
            this.btnSeguinteAdmin.TabIndex = 51;
            this.btnSeguinteAdmin.Text = "Seguinte";
            this.btnSeguinteAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeguinteAdmin.Click += new System.EventHandler(this.btnSeguinteAdmin_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(200, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(481, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Insira as Credenciais do Usuário Administrador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label31.Location = new System.Drawing.Point(246, 401);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(75, 13);
            this.label31.TabIndex = 48;
            this.label31.Text = "Palavra-Passe";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label47.Location = new System.Drawing.Point(246, 299);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(89, 13);
            this.label47.TabIndex = 49;
            this.label47.Text = "Nome de Usuário";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Enabled = false;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(239, 417);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(396, 48);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeUsuario.BaseColor = System.Drawing.Color.White;
            this.txtNomeUsuario.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtNomeUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeUsuario.Enabled = false;
            this.txtNomeUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNomeUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNomeUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomeUsuario.Location = new System.Drawing.Point(239, 315);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.PasswordChar = '\0';
            this.txtNomeUsuario.Radius = 10;
            this.txtNomeUsuario.SelectedText = "";
            this.txtNomeUsuario.Size = new System.Drawing.Size(396, 48);
            this.txtNomeUsuario.TabIndex = 47;
            // 
            // gunaCirclePictureBox9
            // 
            this.gunaCirclePictureBox9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.gunaCirclePictureBox9.Image = global::SGCC___PERFIL.Properties.Resources.usuário;
            this.gunaCirclePictureBox9.Location = new System.Drawing.Point(333, 82);
            this.gunaCirclePictureBox9.Name = "gunaCirclePictureBox9";
            this.gunaCirclePictureBox9.Size = new System.Drawing.Size(203, 188);
            this.gunaCirclePictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox9.TabIndex = 45;
            this.gunaCirclePictureBox9.TabStop = false;
            this.gunaCirclePictureBox9.UseTransfarantBackground = false;
            // 
            // conexaoBD
            // 
            this.conexaoBD.Controls.Add(this.btnTestarConexao);
            this.conexaoBD.Controls.Add(this.txtConexaoBD);
            this.conexaoBD.Controls.Add(this.label7);
            this.conexaoBD.Cursor = System.Windows.Forms.Cursors.Default;
            this.conexaoBD.Location = new System.Drawing.Point(4, 4);
            this.conexaoBD.Name = "conexaoBD";
            this.conexaoBD.Padding = new System.Windows.Forms.Padding(3);
            this.conexaoBD.Size = new System.Drawing.Size(874, 531);
            this.conexaoBD.TabIndex = 3;
            this.conexaoBD.Text = "Conexão com a Base de dados";
            this.conexaoBD.UseVisualStyleBackColor = true;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.AnimationHoverSpeed = 0.07F;
            this.btnTestarConexao.AnimationSpeed = 0.03F;
            this.btnTestarConexao.BackColor = System.Drawing.Color.Transparent;
            this.btnTestarConexao.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnTestarConexao.BorderColor = System.Drawing.Color.Black;
            this.btnTestarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestarConexao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTestarConexao.FocusedColor = System.Drawing.Color.Empty;
            this.btnTestarConexao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestarConexao.ForeColor = System.Drawing.Color.White;
            this.btnTestarConexao.Image = null;
            this.btnTestarConexao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTestarConexao.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTestarConexao.Location = new System.Drawing.Point(325, 405);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnTestarConexao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTestarConexao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTestarConexao.OnHoverImage = null;
            this.btnTestarConexao.OnPressedColor = System.Drawing.Color.Black;
            this.btnTestarConexao.Radius = 10;
            this.btnTestarConexao.Size = new System.Drawing.Size(212, 42);
            this.btnTestarConexao.TabIndex = 52;
            this.btnTestarConexao.Text = "Testar Conexão";
            this.btnTestarConexao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // txtConexaoBD
            // 
            this.txtConexaoBD.BackColor = System.Drawing.Color.Transparent;
            this.txtConexaoBD.BaseColor = System.Drawing.Color.White;
            this.txtConexaoBD.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtConexaoBD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConexaoBD.Enabled = false;
            this.txtConexaoBD.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConexaoBD.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtConexaoBD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConexaoBD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConexaoBD.Location = new System.Drawing.Point(114, 251);
            this.txtConexaoBD.Name = "txtConexaoBD";
            this.txtConexaoBD.PasswordChar = '\0';
            this.txtConexaoBD.Radius = 10;
            this.txtConexaoBD.SelectedText = "";
            this.txtConexaoBD.Size = new System.Drawing.Size(669, 48);
            this.txtConexaoBD.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(192, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(481, 70);
            this.label7.TabIndex = 11;
            this.label7.Text = "Conexão com a Base de dados\r\nInsira a String de Conexão coma Base de dados a ser " +
    "usada";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precario
            // 
            this.precario.Controls.Add(this.btnSeguintePrecario);
            this.precario.Controls.Add(this.label8);
            this.precario.Controls.Add(this.gunaLabel7);
            this.precario.Controls.Add(this.txt_precarioCartao);
            this.precario.Controls.Add(this.gunaLabel6);
            this.precario.Controls.Add(this.txt_precarioCertificado);
            this.precario.Controls.Add(this.gunaLabel5);
            this.precario.Controls.Add(this.txt_precarioMensalidade);
            this.precario.Controls.Add(this.gunaLabel3);
            this.precario.Controls.Add(this.txt_precarioInscricao);
            this.precario.Cursor = System.Windows.Forms.Cursors.Default;
            this.precario.Location = new System.Drawing.Point(4, 4);
            this.precario.Name = "precario";
            this.precario.Padding = new System.Windows.Forms.Padding(3);
            this.precario.Size = new System.Drawing.Size(874, 531);
            this.precario.TabIndex = 4;
            this.precario.Text = "Preçário";
            this.precario.UseVisualStyleBackColor = true;
            // 
            // btnSeguintePrecario
            // 
            this.btnSeguintePrecario.AnimationHoverSpeed = 0.07F;
            this.btnSeguintePrecario.AnimationSpeed = 0.03F;
            this.btnSeguintePrecario.BackColor = System.Drawing.Color.Transparent;
            this.btnSeguintePrecario.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnSeguintePrecario.BorderColor = System.Drawing.Color.Black;
            this.btnSeguintePrecario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeguintePrecario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeguintePrecario.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeguintePrecario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeguintePrecario.ForeColor = System.Drawing.Color.White;
            this.btnSeguintePrecario.Image = null;
            this.btnSeguintePrecario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSeguintePrecario.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeguintePrecario.Location = new System.Drawing.Point(319, 413);
            this.btnSeguintePrecario.Name = "btnSeguintePrecario";
            this.btnSeguintePrecario.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnSeguintePrecario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeguintePrecario.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeguintePrecario.OnHoverImage = null;
            this.btnSeguintePrecario.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeguintePrecario.Radius = 10;
            this.btnSeguintePrecario.Size = new System.Drawing.Size(212, 42);
            this.btnSeguintePrecario.TabIndex = 58;
            this.btnSeguintePrecario.Text = "Seguinte";
            this.btnSeguintePrecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeguintePrecario.Click += new System.EventHandler(this.btnSeguintePrecario_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(187, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(481, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Insira o preçário";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel7.Location = new System.Drawing.Point(478, 284);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(116, 15);
            this.gunaLabel7.TabIndex = 56;
            this.gunaLabel7.Text = "Cartão de Formando";
            // 
            // txt_precarioCartao
            // 
            this.txt_precarioCartao.BackColor = System.Drawing.Color.Transparent;
            this.txt_precarioCartao.BaseColor = System.Drawing.Color.White;
            this.txt_precarioCartao.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_precarioCartao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_precarioCartao.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_precarioCartao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_precarioCartao.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_precarioCartao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_precarioCartao.Location = new System.Drawing.Point(470, 302);
            this.txt_precarioCartao.Name = "txt_precarioCartao";
            this.txt_precarioCartao.PasswordChar = '\0';
            this.txt_precarioCartao.Radius = 10;
            this.txt_precarioCartao.SelectedText = "";
            this.txt_precarioCartao.Size = new System.Drawing.Size(283, 34);
            this.txt_precarioCartao.TabIndex = 55;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel6.Location = new System.Drawing.Point(112, 284);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(65, 15);
            this.gunaLabel6.TabIndex = 54;
            this.gunaLabel6.Text = "Certificado";
            // 
            // txt_precarioCertificado
            // 
            this.txt_precarioCertificado.BackColor = System.Drawing.Color.Transparent;
            this.txt_precarioCertificado.BaseColor = System.Drawing.Color.White;
            this.txt_precarioCertificado.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_precarioCertificado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_precarioCertificado.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_precarioCertificado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_precarioCertificado.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_precarioCertificado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_precarioCertificado.Location = new System.Drawing.Point(104, 302);
            this.txt_precarioCertificado.Name = "txt_precarioCertificado";
            this.txt_precarioCertificado.PasswordChar = '\0';
            this.txt_precarioCertificado.Radius = 10;
            this.txt_precarioCertificado.SelectedText = "";
            this.txt_precarioCertificado.Size = new System.Drawing.Size(283, 34);
            this.txt_precarioCertificado.TabIndex = 53;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel5.Location = new System.Drawing.Point(478, 157);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(74, 15);
            this.gunaLabel5.TabIndex = 52;
            this.gunaLabel5.Text = "Mensalidade";
            // 
            // txt_precarioMensalidade
            // 
            this.txt_precarioMensalidade.BackColor = System.Drawing.Color.Transparent;
            this.txt_precarioMensalidade.BaseColor = System.Drawing.Color.White;
            this.txt_precarioMensalidade.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_precarioMensalidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_precarioMensalidade.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_precarioMensalidade.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_precarioMensalidade.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_precarioMensalidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_precarioMensalidade.Location = new System.Drawing.Point(470, 175);
            this.txt_precarioMensalidade.Name = "txt_precarioMensalidade";
            this.txt_precarioMensalidade.PasswordChar = '\0';
            this.txt_precarioMensalidade.Radius = 10;
            this.txt_precarioMensalidade.SelectedText = "";
            this.txt_precarioMensalidade.Size = new System.Drawing.Size(283, 34);
            this.txt_precarioMensalidade.TabIndex = 51;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel3.Location = new System.Drawing.Point(112, 157);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(54, 15);
            this.gunaLabel3.TabIndex = 50;
            this.gunaLabel3.Text = "Inscrição";
            // 
            // txt_precarioInscricao
            // 
            this.txt_precarioInscricao.BackColor = System.Drawing.Color.Transparent;
            this.txt_precarioInscricao.BaseColor = System.Drawing.Color.White;
            this.txt_precarioInscricao.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_precarioInscricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_precarioInscricao.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_precarioInscricao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_precarioInscricao.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_precarioInscricao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_precarioInscricao.Location = new System.Drawing.Point(104, 175);
            this.txt_precarioInscricao.Name = "txt_precarioInscricao";
            this.txt_precarioInscricao.PasswordChar = '\0';
            this.txt_precarioInscricao.Radius = 10;
            this.txt_precarioInscricao.SelectedText = "";
            this.txt_precarioInscricao.Size = new System.Drawing.Size(283, 34);
            this.txt_precarioInscricao.TabIndex = 49;
            // 
            // terminar
            // 
            this.terminar.Controls.Add(this.btn_iniciar);
            this.terminar.Controls.Add(this.label9);
            this.terminar.Controls.Add(this.label10);
            this.terminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.terminar.Location = new System.Drawing.Point(4, 4);
            this.terminar.Name = "terminar";
            this.terminar.Padding = new System.Windows.Forms.Padding(3);
            this.terminar.Size = new System.Drawing.Size(874, 531);
            this.terminar.TabIndex = 5;
            this.terminar.Text = "Terminar";
            this.terminar.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.AnimationHoverSpeed = 0.07F;
            this.btn_iniciar.AnimationSpeed = 0.03F;
            this.btn_iniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciar.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_iniciar.BorderColor = System.Drawing.Color.Black;
            this.btn_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_iniciar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_iniciar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_iniciar.ForeColor = System.Drawing.Color.White;
            this.btn_iniciar.Image = null;
            this.btn_iniciar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_iniciar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_iniciar.Location = new System.Drawing.Point(308, 324);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_iniciar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_iniciar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_iniciar.OnHoverImage = null;
            this.btn_iniciar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_iniciar.Radius = 10;
            this.btn_iniciar.Size = new System.Drawing.Size(212, 42);
            this.btn_iniciar.TabIndex = 59;
            this.btn_iniciar.Text = "Iniciar Sessão";
            this.btn_iniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(138, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(558, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Agora poderá usar o sistema, tente entrar com suas credenciais.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(276, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 94);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sistema configurado!";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlg_FirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 557);
            this.Controls.Add(this.paginas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dlg_FirstTime";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dlg_FirstTime";
            this.Load += new System.EventHandler(this.dlg_FirstTime_Load);
            this.paginas.ResumeLayout(false);
            this.boasvindas.ResumeLayout(false);
            this.tipoConfig.ResumeLayout(false);
            this.contAdmin.ResumeLayout(false);
            this.contAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox9)).EndInit();
            this.conexaoBD.ResumeLayout(false);
            this.precario.ResumeLayout(false);
            this.precario.PerformLayout();
            this.terminar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages paginas;
        private System.Windows.Forms.TabPage boasvindas;
        private System.Windows.Forms.TabPage tipoConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btn_comecar;
        private Bunifu.UI.WinForms.BunifuImageButton btnConfigDefault;
        private Bunifu.UI.WinForms.BunifuImageButton btnConfigPers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage contAdmin;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label47;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtNomeUsuario;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox9;
        private Guna.UI.WinForms.GunaButton btnSeguinteAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage conexaoBD;
        private Guna.UI.WinForms.GunaButton btnTestarConexao;
        private Guna.UI.WinForms.GunaTextBox txtConexaoBD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage precario;
        private Guna.UI.WinForms.GunaButton btnSeguintePrecario;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txt_precarioCartao;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txt_precarioCertificado;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txt_precarioMensalidade;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_precarioInscricao;
        private System.Windows.Forms.TabPage terminar;
        private Guna.UI.WinForms.GunaButton btn_iniciar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}