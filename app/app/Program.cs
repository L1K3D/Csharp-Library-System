using System;
using System.Collections.Generic;
using System.Linq;
//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//Heitor Santos Ferreira - RA: 081230042
//Engenharia de Computação - Segundo Semestre - EC2

using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_16._05._2023
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tela_Livro_Principal()); //Forçando o programa a ser iniciado pela tela "Tela_Livro_Principal"
        }
    }
}
