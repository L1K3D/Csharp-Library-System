//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//Heitor Santos Ferreira - RA: 081230042
//Engenharia de Computação - Segundo Semestre - EC2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_16._05._2023
{
    public class Livro
    {

        //Declarando variaveis padrão do objeto "Livro" com as caracteristicas privadas
        private int _codigo;
        private string _titulo;
        private string _autor;
        private bool _disponivel = true;
        private string condicao_disponibilidade;

        //Criando construtor da classe para incorporação correta na tela gráfica
        public Livro(int Codigo, string Titulo, string Autor)
        {
            _codigo = Codigo;
            _titulo = Titulo;
            _autor = Autor;
            if (DisponivelPublico == true) 
            {
                condicao_disponibilidade = "Disponível";
            }
            if (DisponivelPublico == false)
            {
                condicao_disponibilidade = "Indisponivel";
            }
        }

        //Criando método "MostrarInformacoesListBox" que será responsável por padronizar a maneira de como as
        //informações do livro se apresentam na listbox presente em "Tela_Livro_Principal".
        public string MostrarInformacoesListBox()
        {
            return "Código do livro: " + _codigo + " | Titulo do livro: " + _titulo + " | Nome do autor: " + _autor + " | " + condicao_disponibilidade;
        }

        //Criando método "MostrarInformaçõesMessageBox" que será responsável por padronizar a maneira de como
        //as informações do livvro se apresentam em praticamente todas as MessageBox invocadas ao longo das
        //variadas execuções do programa
        public string MostrarInformacoesMessageBox()
        {
            return "Código do livro: " + _codigo + "\n Titulo do livro: " + _titulo + "\n Nome do autor: " + _autor + "\n Condição da disponibilidade do livro: " + condicao_disponibilidade;

        }

        //Criando método "AtualizarStatus" que será responsável por atualizar os status de disponibilidade do livro
        //de maneira continua conforme as variadas execuções do programa.
        public void AtualizarStatus(bool disponivel)
        {
            _disponivel = disponivel;
            if (_disponivel)
            {
                condicao_disponibilidade = "Disponível";
            }
            else
            {
                condicao_disponibilidade = "Indisponível";
            }
        }

        //Definindo as variaveis do livro que são privadas para variaveis de uso publico
            //Definindo a variavel "_codigo" como publico com a definição de "CodigoPublico"
        public int CodigoPublico
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

            //Definindo a variavel "_titulo" como publico com a definição de "TituloPublico"    
        public string TituloPublico
        {
            get { return _titulo; }
            set { _titulo = value; }
        }


            //Definindo a variavel "_autor" como publico com a definição de "AutorPublico"
        public string AutorPublico
        {
            get { return _autor; }
            set { _autor = value; }
        }

            //Definindo a variavel "_disponivel" como publico com a definição de "DisponivelPublico"
        public bool DisponivelPublico
        {
            get { return _disponivel; }
            set { _disponivel = value; }
        }

        //Criando método "Emprestar()" responsável por criar e definir as interações de emprestimo do livro com o
        //programa durante as variadas execuções do mesmo
        public string Emprestar()
        {
            if (!_disponivel)
            {
                return "Desculpe, o livro já está emprestado.";
            }

            _disponivel = false;
            return $"O livro de código: {_codigo}\nDe título: {_titulo}\nEscrito por: {_autor}\nFoi emprestado com sucesso!";
        }

        //Criando método "Devolver()" responsável por criar e definir as interações de devolução do livro com o
        //programa durante as variadas execuções do mesmo
        public void Devolver()
        {
            if (!_disponivel)
            {
                _disponivel = true;
                condicao_disponibilidade = "Disponível";
            }
        }
    }
}
