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
    /// Lógica interna para MatriculaWindow.xaml
    /// </summary>
    public partial class MatriculaWindow : Window
    {
        public MatriculaWindow()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            ListTurma.ItemsSource = null;
            ListTurma.ItemsSource = NTurma.Listar();
            ListAlunos.ItemsSource = null;
            ListAlunos.ItemsSource = NAluno.Listar();
        }
        private void MatricularClick(object sender, RoutedEventArgs e)
        {
            if (listTurma.SelectedItem != null &&
                listAlunos.SelectedItem != null)
            {
                Aluno a = (Aluno)listAlunos.SelectedItem;
                Turma t = (Turma)listTurma.SelectedItem;
                NAluno.Matricular(a, t);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um aluno e uma turma");
            }
        }
    }
}
