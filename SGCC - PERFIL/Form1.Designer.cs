
namespace SGCC___PERFIL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(65, 24);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(164, 52);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(235, 24);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(164, 52);
            this.btn_eliminar.TabIndex = 0;
            this.btn_eliminar.Text = "Elimitar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(405, 24);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(164, 52);
            this.btn_consultar.TabIndex = 0;
            this.btn_consultar.Text = "Procurar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 52);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(65, 123);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(116, 20);
            this.txt_cod.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(65, 184);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(334, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_curso
            // 
            this.txt_curso.Location = new System.Drawing.Point(65, 246);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(278, 20);
            this.txt_curso.TabIndex = 1;
            // 
            // txt_contacto
            // 
            this.txt_contacto.Location = new System.Drawing.Point(65, 310);
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(191, 20);
            this.txt_contacto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de Formando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Formando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso do Formando";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contacto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_adicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

