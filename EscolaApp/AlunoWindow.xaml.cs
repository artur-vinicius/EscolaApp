using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();
        }

        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Aluno a = new Aluno();
            a.Id = int.Parse(id_txt.Text);
            a.Nome = nome_txt.Text;
            a.Matricula = int.Parse(matricula_txt.Text);
            a.IdTurma = int.Parse(idturma_txt.Text);
            //Inserir a turma na lista de turmas.
            NAluno.Inserir(a);
            // Lista a turma inserida
            listar_Click(sender, e);
        }
        private void listar_Click(object sender, RoutedEventArgs e)
        {
            alunos_list.ItemsSource = null;
            alunos_list.ItemsSource = NAluno.Listar();

        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(id_txt.Text);
            NAluno.Excluir(a);
            listar_Click(sender, e);
        }

        private void atualizar_Click(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(id_txt.Text);
            a.Nome = nome_txt.Text;
            a.Matricula = int.Parse(matricula_txt.Text);
            a.IdTurma = int.Parse(idturma_txt.Text);
            NAluno.Atualizar(a);
            listar_Click(sender, e);
        }
    }
}
