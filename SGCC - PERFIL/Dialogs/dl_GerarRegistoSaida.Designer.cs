
namespace SGCC___PERFIL.Dialogs
{
    partial class dl_GerarRegistoSaida
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.btn_concluido = new Guna.UI.WinForms.GunaButton();
            this.cbx_relatar = new Guna.UI.WinForms.GunaComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtValor = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutro = new Guna.UI.WinForms.GunaTextBox();
            this.formDropShadow1 = new XanderUI.FormDropShadow();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label48);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 35);
            this.panel1.TabIndex = 0;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(8, 7);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(202, 20);
            this.label48.TabIndex = 48;
            this.label48.Text = "Gerar relatório de Saída";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(957, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // btn_concluido
            // 
            this.btn_concluido.AnimationHoverSpeed = 0.07F;
            this.btn_concluido.AnimationSpeed = 0.03F;
            this.btn_concluido.BackColor = System.Drawing.Color.Transparent;
            this.btn_concluido.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_concluido.BorderColor = System.Drawing.Color.Black;
            this.btn_concluido.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_concluido.FocusedColor = System.Drawing.Color.Empty;
            this.btn_concluido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_concluido.ForeColor = System.Drawing.Color.White;
            this.btn_concluido.Image = null;
            this.btn_concluido.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_concluido.Location = new System.Drawing.Point(395, 278);
            this.btn_concluido.Name = "btn_concluido";
            this.btn_concluido.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_concluido.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_concluido.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_concluido.OnHoverImage = null;
            this.btn_concluido.OnPressedColor = System.Drawing.Color.Black;
            this.btn_concluido.Radius = 10;
            this.btn_concluido.Size = new System.Drawing.Size(212, 42);
            this.btn_concluido.TabIndex = 50;
            this.btn_concluido.Text = "Concluido";
            this.btn_concluido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_concluido.Click += new System.EventHandler(this.btn_concluido_Click);
            // 
            // cbx_relatar
            // 
            this.cbx_relatar.BackColor = System.Drawing.Color.Transparent;
            this.cbx_relatar.BaseColor = System.Drawing.Color.White;
            this.cbx_relatar.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cbx_relatar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_relatar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_relatar.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_relatar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_relatar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbx_relatar.FormattingEnabled = true;
            this.cbx_relatar.ItemHeight = 42;
            this.cbx_relatar.Items.AddRange(new object[] {
            "Pagamento de Energia",
            "Combustível do Gerador",
            "Compra de Tinteiros",
            "Compra de Resma de Papeis",
            "Devoluções",
            "Outro"});
            this.cbx_relatar.Location = new System.Drawing.Point(12, 63);
            this.cbx_relatar.Name = "cbx_relatar";
            this.cbx_relatar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbx_relatar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_relatar.Radius = 10;
            this.cbx_relatar.Size = new System.Drawing.Size(298, 48);
            this.cbx_relatar.TabIndex = 52;
            this.cbx_relatar.SelectedIndexChanged += new System.EventHandler(this.cbx_relatar_SelectedIndexChanged);
            this.cbx_relatar.SelectedValueChanged += new System.EventHandler(this.cbx_relatar_SelectedValueChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(16, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Relatar sobre";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(16, 148);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 54;
            this.label27.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Transparent;
            this.txtValor.BaseColor = System.Drawing.Color.White;
            this.txtValor.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtValor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtValor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValor.Location = new System.Drawing.Point(12, 164);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.Radius = 10;
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(298, 42);
            this.txtValor.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidade.BaseColor = System.Drawing.Color.White;
            this.txtQuantidade.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantidade.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuantidade.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantidade.Location = new System.Drawing.Point(343, 164);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.Radius = 10;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.Size = new System.Drawing.Size(298, 42);
            this.txtQuantidade.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Outro";
            // 
            // txtOutro
            // 
            this.txtOutro.BackColor = System.Drawing.Color.Transparent;
            this.txtOutro.BaseColor = System.Drawing.Color.White;
            this.txtOutro.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtOutro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutro.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOutro.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOutro.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOutro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOutro.Location = new System.Drawing.Point(680, 164);
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.PasswordChar = '\0';
            this.txtOutro.Radius = 10;
            this.txtOutro.SelectedText = "";
            this.txtOutro.Size = new System.Drawing.Size(298, 42);
            this.txtOutro.TabIndex = 57;
            // 
            // formDropShadow1
            // 
            this.formDropShadow1.EffectedForm = this;
            this.formDropShadow1.ShadowAngle = 5;
            // 
            // dl_GerarRegistoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbx_relatar);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.btn_concluido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dl_GerarRegistoSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dl_GerarRegistoSaida";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label48;
        private Guna.UI.WinForms.GunaButton btn_concluido;
        private Guna.UI.WinForms.GunaComboBox cbx_relatar;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private Guna.UI.WinForms.GunaTextBox txtValor;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtOutro;
        private XanderUI.FormDropShadow formDropShadow1;
    }
}