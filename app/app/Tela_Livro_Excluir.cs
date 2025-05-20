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
    public partial class Tela_Livro_Excluir : Form
    {
        //Importando a lista de livros existente no programa e criado na "Tela_Livro_Cadastro"
        //como um construtor e inicializador da tela "Tela_Livro_Emprestar" para que ambas as telas
        //possam acessar a mesma lista.
        private List<Livro> livros;

        //Importando a "Tela_Livro_Principal" como construtor e inicializador da tela "Tela_Livro_Excluir"
        //para que a mesma possa ser iniciada pelo botão presente na "Tela_Livro_Principal".
        private Tela_Livro_Principal janela_tela_livro_principal;

        //Declarando a lista de livros e a "Tela_Livro_Principal" como construtores da "Tela_Livro_Excluir"
        //de maneira definitiva.
        public Tela_Livro_Excluir(List<Livro> listaLivros, Tela_Livro_Principal janela_tela_livro_principal)
        {
            InitializeComponent(); 
            livros = listaLivros; //Atribuindo a lista de livros a variavel "livros".
            this.janela_tela_livro_principal = janela_tela_livro_principal; //Atribuindo a "Tela_Livro_Principal" a variavel "janela_tela_livro_principal".
        }

        //Atribuino ações para o botão "Pesquisar" da "Tela_Livro_Excluir"
        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            int busca_codigo = int.Parse(textBox_codigo_livro.Text); //Realiza a leitura do código digitado na textbox de pesquisa.

            bool livro_emprestimo_encontrado = false;

            foreach (Livro livro in livros) //Percorre toda a lista de livros.
            {
                if (livro.CodigoPublico == busca_codigo) //Realiza a verificação entre os códigos de livro presentes na lista e o código de livro pesquisado na textbox de pesquisa.
                {
                    MessageBox.Show(livro.MostrarInformacoesMessageBox()); //Exibe uma MessageBox com as informãções do livro pesquisado, caso o mesmo exista na lista de livros com base no código.
                    livro_emprestimo_encontrado = true;
                    break;
                }
            }

            //Caso o código fornecido na textbox de pesquisa não exista na lista de livros, retorna uma MessageBox informando que o livro pesquisado não existe.
            if (!livro_emprestimo_encontrado)
            {
                MessageBox.Show("Livro não encontrado");
            }
        }

        //Atribuindo ações para o botão "Limpar" da "Tela_Livro_Exlcuir".
        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_codigo_livro.Text = ""; //Limpando a caixa de texto presente na "Tela_Livo_Emprestar".
        }

        //Atribuindo ações para o botão "Voltar" de "Tela_Livro_Excluir"
        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Atribuinfo ações para o botão "Excluir" da "Tela_Livro_Excluir"
        private void button_devolver_Click(object sender, EventArgs e)
        {
            int busca_codigo = int.Parse(textBox_codigo_livro.Text); //Realiza a leitura do código digitado na textbox de pesquisa.

            bool livro_emprestimo_encontrado = false;

            foreach (Livro livro in livros) //Percorre toda a lista de livros.
            {
                if (livro.CodigoPublico == busca_codigo) //Realiza a verificação entre os códigos de livro presentes na lista e o código de livro pesquisado na textbox de pesquisa.
                {
                    MessageBox.Show($"O livro de código: {livro.CodigoPublico}\nDe título: {livro.TituloPublico}\nEscrito por: {livro.AutorPublico}\nFoi excluido com sucesso!"); //Exibe uma MessageBox para o úsuario confirmando a exclusão do livro
                    janela_tela_livro_principal.RemoverLivro(livro); //Remove o livro da lista e da listbox presente em "Tela_Livro_Principal"
                    livro_emprestimo_encontrado = true; 
                    textBox_codigo_livro.Text = "";
                    break;
                }
            }

            //Caso o código fornecido na textbox de pesquisa não exista na lista de livros, retorna uma MessageBox informando que o livro pesquisado não existe.
            if (!livro_emprestimo_encontrado)
            {
                MessageBox.Show("Livro não encontrado");
                textBox_codigo_livro.Text = "";
            }
        }
    }
}
