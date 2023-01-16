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

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Aluno a = new Aluno();
            a.Id = int.Parse(id_txt.Text);
            a.Nome = nome_txt.Text;
            a.Matricula = matricula_txt.Text;
            a.Email = email_txt.Text;
            //Inserir a turma na lista de turmas.
            NAluno.Inserir(a);
            // Lista a turma inserida
            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            AlunosList.ItemsSource = null;
            AlunosList.ItemsSource = NAluno.Listar();

        }
        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(id_txt.Text);
            a.Nome = nome_txt.Text;
            a.Matricula = matricula_txt.Text;
            a.Email = email_txt.Text;

            NAluno.Atualizar(a);
            ListarClick(sender, e);
        }
        
        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Id = int.Parse(id_txt.Text);
            NAluno.Excluir(a);
            ListarClick(sender, e);
        }
        
        private void AlunosList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AlunosList.SelectedItem != null)
            {
                Aluno obj = (Aluno)AlunosList.SelectedItem;
                id_txt.Text = obj.Id.ToString();
                nome_txt.Text = obj.Nome;
                matricula_txt.Text = obj.Matricula;
                email_txt.Text = obj.Email;
            }
        }
    }
}
