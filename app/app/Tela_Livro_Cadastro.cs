//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//Heitor Santos Ferreira - RA: 081230042
//Engenharia de Computação - Segundo Semestre - EC2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_16._05._2023
{
    //Iniciando a tela com o codinome atribuido ao design dela
    public partial class Tela_Livro_Cadastro : Form
    {
        //Importando a "Tela_Livro_Principal" como construtor e inicializador da tela "Tela_Livro_Cadastro"
        //para que a mesma possa ser iniciada pelo botão presente na "Tela_Livro_Principal".
        private Tela_Livro_Principal janela_tela_livro_principal;

        //Declarando  a "Tela_Livro_Principal" como construtor da "Tela_Livro_Cadastro"
        //de maneira definitiva.
        public Tela_Livro_Cadastro(Tela_Livro_Principal janela_tela_livro_principal)
        {
            InitializeComponent();
            this.janela_tela_livro_principal = janela_tela_livro_principal; //Atribuindo a "Tela_Livro_Principal" a variavel "janela_tela_livro_principal".
        }

        //Criando lista de livros
        List<Livro> livros = new List<Livro>();

        //Definindo ações para o botão "Cadastrar"
        private void button_confirmar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBox_codigo_livro.Text); //Lendo o código atribuido na textbox e usando o método nativo de C# "Parse()" para converter o input de texto pata inteiro.
            string titulo = textBox_titulo_livro.Text; //Lendo o titulo atribuido na textbox
            string autor = textBox_autor_livro.Text; //Lendo o autor atribuido na textbox

            Livro livro = new Livro(codigo, titulo, autor); //Criando novo objeto "livro" usando o construtor da classe declarado no código de criação da classe livro.
            janela_tela_livro_principal.AdicionarListBox(livro.MostrarInformacoesListBox()); //Adicionando o livro recem cadastrado na ListBox presente na "Tela_Livro_Principal".
            MessageBox.Show(livro.MostrarInformacoesMessageBox(), "As informações cadastradas foram:"); //Exibindo as informações do livro recentemente cadastrado.

            janela_tela_livro_principal.AdicionarLivro(livro); //Adicionando o livro recem cadastrado a lista de livros universal que está contida em "Tela_Livro_Principal"

            textBox_codigo_livro.Text = ""; //}
            textBox_titulo_livro.Text = ""; //} --> Limpando todas as caixas de texto da tela.
            textBox_autor_livro.Text = "";  //}
        }

        //Criando método para que a caixa de texto que recebe o código possa recebe-lo em valores inteiros através do método "Parse()".
        private void textBox_codigo_livro_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_codigo_livro.Text, "  ^ [0-9]"))
            {
                textBox_codigo_livro.Text = "";
            }
        }

        //Defininco as ações para o botão "Limpar"
        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_codigo_livro.Text = ""; //}
            textBox_titulo_livro.Text = ""; //} --> Limpando todas as caixas de texto da tela
            textBox_autor_livro.Text = "";  //}
        }

        //Definindo as ações para o botão "Voltar"
        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
