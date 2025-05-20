
namespace atividade_16._05._2023
{
    partial class Tela_Livro_Devolver
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
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_devolver = new System.Windows.Forms.Button();
            this.textBox_codigo_livro = new System.Windows.Forms.TextBox();
            this.label_codigo_livro = new System.Windows.Forms.Label();
            this.label_sistema_livros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Location = new System.Drawing.Point(330, 59);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(82, 23);
            this.button_pesquisar.TabIndex = 15;
            this.button_pesquisar.Text = "Pesquisar 🔎";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.Location = new System.Drawing.Point(297, 99);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(115, 36);
            this.button_voltar.TabIndex = 14;
            this.button_voltar.Text = "Voltar ↩️";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(157, 99);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(115, 36);
            this.button_limpar.TabIndex = 13;
            this.button_limpar.Text = "Limpar 🧹";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_devolver
            // 
            this.button_devolver.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_devolver.ForeColor = System.Drawing.SystemColors.Window;
            this.button_devolver.Location = new System.Drawing.Point(19, 99);
            this.button_devolver.Name = "button_devolver";
            this.button_devolver.Size = new System.Drawing.Size(115, 36);
            this.button_devolver.TabIndex = 12;
            this.button_devolver.Text = "Devolver ✔";
            this.button_devolver.UseVisualStyleBackColor = false;
            this.button_devolver.Click += new System.EventHandler(this.button_devolver_Click);
            // 
            // textBox_codigo_livro
            // 
            this.textBox_codigo_livro.Location = new System.Drawing.Point(99, 61);
            this.textBox_codigo_livro.Name = "textBox_codigo_livro";
            this.textBox_codigo_livro.Size = new System.Drawing.Size(220, 20);
            this.textBox_codigo_livro.TabIndex = 11;
            // 
            // label_codigo_livro
            // 
            this.label_codigo_livro.AutoSize = true;
            this.label_codigo_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codigo_livro.Location = new System.Drawing.Point(2, 62);
            this.label_codigo_livro.Name = "label_codigo_livro";
            this.label_codigo_livro.Size = new System.Drawing.Size(99, 16);
            this.label_codigo_livro.TabIndex = 10;
            this.label_codigo_livro.Text = "Código do livro";
            // 
            // label_sistema_livros
            // 
            this.label_sistema_livros.AutoSize = true;
            this.label_sistema_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sistema_livros.Location = new System.Drawing.Point(75, 9);
            this.label_sistema_livros.Name = "label_sistema_livros";
            this.label_sistema_livros.Size = new System.Drawing.Size(270, 42);
            this.label_sistema_livros.TabIndex = 9;
            this.label_sistema_livros.Text = "Devolução 📗⬇️";
            // 
            // Tela_Livro_Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 149);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_devolver);
            this.Controls.Add(this.textBox_codigo_livro);
            this.Controls.Add(this.label_codigo_livro);
            this.Controls.Add(this.label_sistema_livros);
            this.Name = "Tela_Livro_Devolver";
            this.Text = "Devolver Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_devolver;
        private System.Windows.Forms.TextBox textBox_codigo_livro;
        private System.Windows.Forms.Label label_codigo_livro;
        private System.Windows.Forms.Label label_sistema_livros;
    }
}