
namespace atividade_16._05._2023
{
    partial class Tela_Livro_Emprestar
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
            this.label_sistema_livros = new System.Windows.Forms.Label();
            this.label_codigo_livro = new System.Windows.Forms.Label();
            this.textBox_codigo_livro = new System.Windows.Forms.TextBox();
            this.button_emprestar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_sistema_livros
            // 
            this.label_sistema_livros.AutoSize = true;
            this.label_sistema_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sistema_livros.Location = new System.Drawing.Point(83, 9);
            this.label_sistema_livros.Name = "label_sistema_livros";
            this.label_sistema_livros.Size = new System.Drawing.Size(290, 42);
            this.label_sistema_livros.TabIndex = 1;
            this.label_sistema_livros.Text = "Emprestimo 📗⬆️";
            // 
            // label_codigo_livro
            // 
            this.label_codigo_livro.AutoSize = true;
            this.label_codigo_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codigo_livro.Location = new System.Drawing.Point(9, 63);
            this.label_codigo_livro.Name = "label_codigo_livro";
            this.label_codigo_livro.Size = new System.Drawing.Size(99, 16);
            this.label_codigo_livro.TabIndex = 2;
            this.label_codigo_livro.Text = "Código do livro";
            // 
            // textBox_codigo_livro
            // 
            this.textBox_codigo_livro.Location = new System.Drawing.Point(106, 61);
            this.textBox_codigo_livro.Name = "textBox_codigo_livro";
            this.textBox_codigo_livro.Size = new System.Drawing.Size(220, 20);
            this.textBox_codigo_livro.TabIndex = 3;
            // 
            // button_emprestar
            // 
            this.button_emprestar.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_emprestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_emprestar.ForeColor = System.Drawing.SystemColors.Window;
            this.button_emprestar.Location = new System.Drawing.Point(12, 99);
            this.button_emprestar.Name = "button_emprestar";
            this.button_emprestar.Size = new System.Drawing.Size(128, 36);
            this.button_emprestar.TabIndex = 5;
            this.button_emprestar.Text = "Emprestar ✔";
            this.button_emprestar.UseVisualStyleBackColor = false;
            this.button_emprestar.Click += new System.EventHandler(this.button_emprestar_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(167, 99);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(115, 36);
            this.button_limpar.TabIndex = 6;
            this.button_limpar.Text = "Limpar 🧹";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(308, 99);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(115, 36);
            this.button_voltar.TabIndex = 7;
            this.button_voltar.Text = "Voltar ↩️";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Location = new System.Drawing.Point(334, 60);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(89, 23);
            this.button_pesquisar.TabIndex = 8;
            this.button_pesquisar.Text = "Pesquisar 🔎\r\n";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // Tela_Livro_Emprestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 146);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_emprestar);
            this.Controls.Add(this.textBox_codigo_livro);
            this.Controls.Add(this.label_codigo_livro);
            this.Controls.Add(this.label_sistema_livros);
            this.Name = "Tela_Livro_Emprestar";
            this.Text = "Emprestar Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sistema_livros;
        private System.Windows.Forms.Label label_codigo_livro;
        private System.Windows.Forms.TextBox textBox_codigo_livro;
        private System.Windows.Forms.Button button_emprestar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_pesquisar;
    }
}