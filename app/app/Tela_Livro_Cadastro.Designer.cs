
namespace atividade_16._05._2023
{
    partial class Tela_Livro_Cadastro
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
            this.label_cadastrar_livros = new System.Windows.Forms.Label();
            this.label_informacoes = new System.Windows.Forms.Label();
            this.label_codigo_livro = new System.Windows.Forms.Label();
            this.textBox_codigo_livro = new System.Windows.Forms.TextBox();
            this.textBox_titulo_livro = new System.Windows.Forms.TextBox();
            this.label_titulo_livro = new System.Windows.Forms.Label();
            this.textBox_autor_livro = new System.Windows.Forms.TextBox();
            this.label_autor_livro = new System.Windows.Forms.Label();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_cadastrar_livros
            // 
            this.label_cadastrar_livros.AutoSize = true;
            this.label_cadastrar_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cadastrar_livros.Location = new System.Drawing.Point(55, 9);
            this.label_cadastrar_livros.Name = "label_cadastrar_livros";
            this.label_cadastrar_livros.Size = new System.Drawing.Size(270, 42);
            this.label_cadastrar_livros.TabIndex = 0;
            this.label_cadastrar_livros.Text = "Cadastro 📗➕";
            // 
            // label_informacoes
            // 
            this.label_informacoes.AutoSize = true;
            this.label_informacoes.Location = new System.Drawing.Point(23, 72);
            this.label_informacoes.Name = "label_informacoes";
            this.label_informacoes.Size = new System.Drawing.Size(321, 13);
            this.label_informacoes.TabIndex = 1;
            this.label_informacoes.Text = "Preencha as informações abaixo sobre o livro que será cadastrado";
            // 
            // label_codigo_livro
            // 
            this.label_codigo_livro.AutoSize = true;
            this.label_codigo_livro.Location = new System.Drawing.Point(20, 107);
            this.label_codigo_livro.Name = "label_codigo_livro";
            this.label_codigo_livro.Size = new System.Drawing.Size(77, 13);
            this.label_codigo_livro.TabIndex = 2;
            this.label_codigo_livro.Text = "Código do livro\r\n";
            // 
            // textBox_codigo_livro
            // 
            this.textBox_codigo_livro.Location = new System.Drawing.Point(103, 104);
            this.textBox_codigo_livro.Name = "textBox_codigo_livro";
            this.textBox_codigo_livro.Size = new System.Drawing.Size(241, 20);
            this.textBox_codigo_livro.TabIndex = 3;
            this.textBox_codigo_livro.TextChanged += new System.EventHandler(this.textBox_codigo_livro_TextChanged);
            // 
            // textBox_titulo_livro
            // 
            this.textBox_titulo_livro.Location = new System.Drawing.Point(103, 130);
            this.textBox_titulo_livro.Name = "textBox_titulo_livro";
            this.textBox_titulo_livro.Size = new System.Drawing.Size(241, 20);
            this.textBox_titulo_livro.TabIndex = 5;
            // 
            // label_titulo_livro
            // 
            this.label_titulo_livro.AutoSize = true;
            this.label_titulo_livro.Location = new System.Drawing.Point(23, 133);
            this.label_titulo_livro.Name = "label_titulo_livro";
            this.label_titulo_livro.Size = new System.Drawing.Size(70, 13);
            this.label_titulo_livro.TabIndex = 4;
            this.label_titulo_livro.Text = "Titulo do livro\r\n";
            // 
            // textBox_autor_livro
            // 
            this.textBox_autor_livro.Location = new System.Drawing.Point(103, 156);
            this.textBox_autor_livro.Name = "textBox_autor_livro";
            this.textBox_autor_livro.Size = new System.Drawing.Size(241, 20);
            this.textBox_autor_livro.TabIndex = 7;
            // 
            // label_autor_livro
            // 
            this.label_autor_livro.AutoSize = true;
            this.label_autor_livro.Location = new System.Drawing.Point(26, 159);
            this.label_autor_livro.Name = "label_autor_livro";
            this.label_autor_livro.Size = new System.Drawing.Size(69, 13);
            this.label_autor_livro.TabIndex = 6;
            this.label_autor_livro.Text = "Autor do livro\r\n";
            // 
            // button_confirmar
            // 
            this.button_confirmar.BackColor = System.Drawing.Color.Green;
            this.button_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.button_confirmar.Location = new System.Drawing.Point(12, 200);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(118, 31);
            this.button_confirmar.TabIndex = 8;
            this.button_confirmar.Text = "Cadastrar ✔";
            this.button_confirmar.UseVisualStyleBackColor = false;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(141, 200);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(96, 31);
            this.button_limpar.TabIndex = 9;
            this.button_limpar.Text = "Limpar 🧹";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.SystemColors.Control;
            this.button_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_voltar.Location = new System.Drawing.Point(248, 200);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(96, 31);
            this.button_voltar.TabIndex = 10;
            this.button_voltar.Text = "Voltar ↩️";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // Tela_Livro_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 241);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_confirmar);
            this.Controls.Add(this.textBox_autor_livro);
            this.Controls.Add(this.label_autor_livro);
            this.Controls.Add(this.textBox_titulo_livro);
            this.Controls.Add(this.label_titulo_livro);
            this.Controls.Add(this.textBox_codigo_livro);
            this.Controls.Add(this.label_codigo_livro);
            this.Controls.Add(this.label_informacoes);
            this.Controls.Add(this.label_cadastrar_livros);
            this.Name = "Tela_Livro_Cadastro";
            this.Text = "Cadastrar Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cadastrar_livros;
        private System.Windows.Forms.Label label_informacoes;
        private System.Windows.Forms.Label label_codigo_livro;
        private System.Windows.Forms.TextBox textBox_codigo_livro;
        private System.Windows.Forms.TextBox textBox_titulo_livro;
        private System.Windows.Forms.Label label_titulo_livro;
        private System.Windows.Forms.TextBox textBox_autor_livro;
        private System.Windows.Forms.Label label_autor_livro;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_voltar;
    }
}

