//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//Heitor Santos Ferreira - RA: 081230042
//Engenharia de Computação - Segundo Semestre - EC2

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atividade_16._05._2023
{
    //Iniciando a tela com o codinome atribuido ao design dela
    public partial class Tela_Livro_Principal : Form
    {
        //Importando a lista de livros existente no programa e criado na "Tela_Livro_Cadastro"
        //como um construtor e inicializador da tela "Tela_Livro_Principal" para que ambas as telas
        //possam acessar a mesma lista.
        private List<Livro> livros;

        public Tela_Livro_Principal()
        {
            InitializeComponent();
            livros = new List<Livro>(); //Atribuindo a lista de livros a variavel "livros".
        }

        //Criando método "AdicionarListBox" que é responsável por adicionar os novos livros cadastrados em
        //"Tela_Livro_Cadastro" a listbox presente em "Tela_Livro_Principal".
        public void AdicionarListBox(string livro)
        {
            listBox_livros_cadastrados.Items.Add(livro);
        }

        //Criando método "AdicionarLivro" que é responsável por adicionar os novos livros cadastrados em
        //"Tela_Livro_Cadastro" a lista definitiva de livros que é utilizada por todas as outras telas
        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        //Criando método "AtualizarStatusLivro" que é responsável por alterar os status dos livros entre
        //"Disponível" e "Indisponível" conforme as ações de "Emprestar" e "Devolver" dos livros presentes
        //na lista de livros.
        public void AtualizarStatusLivro(int codigo, bool disponivel) //O código do livro que terá o status alerado, será lido pela várivel de declaração "codigo" e o status do livro será lido pela váriavel de declaração "disponível"
        {
            for (int i = 0; i < listBox_livros_cadastrados.Items.Count; i++) //Criando laço de relacionamento dinâmico entre os livros presentes na listbox e os presentes na lista, realizando a contagem de itens entre ambas.
            {
                string item = listBox_livros_cadastrados.Items[i].ToString();

                if (item.Contains($"Código do livro: {codigo}")) //Realizando verificação de código do livro emprestado ou devolvido.
                {
                    string novo_item;

                    if (disponivel)
                    {
                        novo_item = item.Replace("Indisponível", "Disponível");
                    }
                    else
                    {
                        novo_item = item.Replace("Disponível", "Indisponível");
                    }
                    listBox_livros_cadastrados.Items[i] = novo_item;
                    break;
                }
            }
        }

        //Criando o método "RemoverLivro" que é responsável por remover os livros selecionados da lista
        //de livros e da listbox presente em "Tela_Livro_Principal"
        public void RemoverLivro(Livro livro)
        {
            livros.Remove(livro);
            listBox_livros_cadastrados.Items.Remove(livro.MostrarInformacoesListBox());
        }

        //Atribuindo ação para o botão "Cadastrar" que ao ser acionado, irá realizar a iniciação da 
        //"Tela_Livro_Cadastrar"
        private void button_cadastrar_novo_livro_Click(object sender, EventArgs e)
        {
            Tela_Livro_Cadastro abrir_tela_cadastro = new Tela_Livro_Cadastro(this);

            abrir_tela_cadastro.Show();
        }

        //Atribuindo ação para o botão "Emprestar" que ao ser acionado, irá realizar a iniciação da 
        //"Tela_Livro_Emprestar"
        private void button_emprestar_livro_Click(object sender, EventArgs e)
        {
            Tela_Livro_Emprestar abrir_tela_emprestimo = new Tela_Livro_Emprestar(livros, this);

            abrir_tela_emprestimo.Show();
        }

        //Atribuindo ação para o botão "Devolver" que ao ser acionado, irá realizar a iniciação da 
        //"Tela_Livro_Devolver"
        private void button_devolver_livro_Click(object sender, EventArgs e)
        {
            Tela_Livro_Devolver abrir_tela_devolucao = new Tela_Livro_Devolver(livros, this);

            abrir_tela_devolucao.Show();
        }

        //Atribuindo ação para o botão "Excluir" que ao ser acionado, irá realizar a iniciação da 
        //"Tela_Livro_Excluir"
        private void button_deletar_livro_Click(object sender, EventArgs e)
        {
            Tela_Livro_Excluir abrir_janela_exclusao = new Tela_Livro_Excluir(livros, this);

            abrir_janela_exclusao.Show();
        }
    }
}
