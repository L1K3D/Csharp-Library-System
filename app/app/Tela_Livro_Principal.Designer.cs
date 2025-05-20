
namespace atividade_16._05._2023
{
    partial class Tela_Livro_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Livro_Principal));
            this.label_sistema_livros = new System.Windows.Forms.Label();
            this.listBox_livros_cadastrados = new System.Windows.Forms.ListBox();
            this.label_explicacao_lista = new System.Windows.Forms.Label();
            this.button_cadastrar_novo_livro = new System.Windows.Forms.Button();
            this.button_emprestar_livro = new System.Windows.Forms.Button();
            this.button_devolver_livro = new System.Windows.Forms.Button();
            this.button_deletar_livro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_sistema_livros
            // 
            this.label_sistema_livros.AutoSize = true;
            this.label_sistema_livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sistema_livros.Location = new System.Drawing.Point(102, 19);
            this.label_sistema_livros.Name = "label_sistema_livros";
            this.label_sistema_livros.Size = new System.Drawing.Size(393, 42);
            this.label_sistema_livros.TabIndex = 0;
            this.label_sistema_livros.Text = "Sistema Biblioteca 📚\r\n";
            // 
            // listBox_livros_cadastrados
            // 
            this.listBox_livros_cadastrados.ColumnWidth = 20;
            this.listBox_livros_cadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_livros_cadastrados.FormattingEnabled = true;
            this.listBox_livros_cadastrados.HorizontalScrollbar = true;
            this.listBox_livros_cadastrados.ItemHeight = 16;
            this.listBox_livros_cadastrados.Location = new System.Drawing.Point(12, 189);
            this.listBox_livros_cadastrados.Name = "listBox_livros_cadastrados";
            this.listBox_livros_cadastrados.Size = new System.Drawing.Size(549, 116);
            this.listBox_livros_cadastrados.TabIndex = 1;
            // 
            // label_explicacao_lista
            // 
            this.label_explicacao_lista.AutoSize = true;
            this.label_explicacao_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_explicacao_lista.Location = new System.Drawing.Point(205, 160);
            this.label_explicacao_lista.Name = "label_explicacao_lista";
            this.label_explicacao_lista.Size = new System.Drawing.Size(181, 20);
            this.label_explicacao_lista.TabIndex = 2;
            this.label_explicacao_lista.Text = "Livros cadastrados 📜 📚\r\n";
            // 
            // button_cadastrar_novo_livro
            // 
            this.button_cadastrar_novo_livro.BackColor = System.Drawing.Color.Green;
            this.button_cadastrar_novo_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar_novo_livro.ForeColor = System.Drawing.SystemColors.Window;
            this.button_cadastrar_novo_livro.Location = new System.Drawing.Point(12, 73);
            this.button_cadastrar_novo_livro.Name = "button_cadastrar_novo_livro";
            this.button_cadastrar_novo_livro.Size = new System.Drawing.Size(283, 34);
            this.button_cadastrar_novo_livro.TabIndex = 3;
            this.button_cadastrar_novo_livro.Text = "Cadastrar novo livro 📗➕";
            this.button_cadastrar_novo_livro.UseVisualStyleBackColor = false;
            this.button_cadastrar_novo_livro.Click += new System.EventHandler(this.button_cadastrar_novo_livro_Click);
            // 
            // button_emprestar_livro
            // 
            this.button_emprestar_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_emprestar_livro.Location = new System.Drawing.Point(301, 113);
            this.button_emprestar_livro.Name = "button_emprestar_livro";
            this.button_emprestar_livro.Size = new System.Drawing.Size(260, 34);
            this.button_emprestar_livro.TabIndex = 4;
            this.button_emprestar_livro.Text = "Emprestar livro 📗⬆️";
            this.button_emprestar_livro.UseVisualStyleBackColor = true;
            this.button_emprestar_livro.Click += new System.EventHandler(this.button_emprestar_livro_Click);
            // 
            // button_devolver_livro
            // 
            this.button_devolver_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_devolver_livro.Location = new System.Drawing.Point(12, 113);
            this.button_devolver_livro.Name = "button_devolver_livro";
            this.button_devolver_livro.Size = new System.Drawing.Size(283, 34);
            this.button_devolver_livro.TabIndex = 5;
            this.button_devolver_livro.Text = "Devolver livro 📗⬇️";
            this.button_devolver_livro.UseVisualStyleBackColor = true;
            this.button_devolver_livro.Click += new System.EventHandler(this.button_devolver_livro_Click);
            // 
            // button_deletar_livro
            // 
            this.button_deletar_livro.BackColor = System.Drawing.Color.DarkRed;
            this.button_deletar_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletar_livro.ForeColor = System.Drawing.SystemColors.Window;
            this.button_deletar_livro.Location = new System.Drawing.Point(301, 73);
            this.button_deletar_livro.Name = "button_deletar_livro";
            this.button_deletar_livro.Size = new System.Drawing.Size(260, 34);
            this.button_deletar_livro.TabIndex = 6;
            this.button_deletar_livro.Text = "Deletar livro 📗❌";
            this.button_deletar_livro.UseVisualStyleBackColor = false;
            this.button_deletar_livro.Click += new System.EventHandler(this.button_deletar_livro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(501, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "#===Créditos===#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "FESA - Faculdade Engenheiro Salvador Arena\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Heitor Santos Ferreira - RA: 081230042";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Engenharia de Computação - Segundo Semestre - EC2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CEFSA - Centro Educacional da Fundação Salvador Arena\r\n";
            // 
            // Tela_Livro_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_deletar_livro);
            this.Controls.Add(this.button_devolver_livro);
            this.Controls.Add(this.button_emprestar_livro);
            this.Controls.Add(this.button_cadastrar_novo_livro);
            this.Controls.Add(this.label_explicacao_lista);
            this.Controls.Add(this.listBox_livros_cadastrados);
            this.Controls.Add(this.label_sistema_livros);
            this.Name = "Tela_Livro_Principal";
            this.Text = "Sistema Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sistema_livros;
        private System.Windows.Forms.ListBox listBox_livros_cadastrados;
        private System.Windows.Forms.Label label_explicacao_lista;
        private System.Windows.Forms.Button button_cadastrar_novo_livro;
        private System.Windows.Forms.Button button_emprestar_livro;
        private System.Windows.Forms.Button button_devolver_livro;
        private System.Windows.Forms.Button button_deletar_livro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}