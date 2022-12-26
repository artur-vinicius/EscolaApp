﻿using System;
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
    /// Lógica interna para TurmaWindow.xaml
    /// </summary>
    public partial class TurmaWindow : Window
    {
        public TurmaWindow()
        {
            InitializeComponent();
        }

        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            t.Id = int.Parse(txt_id_Turmas.Text);
            t.Curso = txt_curso_Turmas.Text;
            t.Descricao = txt_turma_Turmas.Text;
            t.AnoLetivo = int.Parse(txt_ano_Turmas.Text);
            //Inserir a turma na lista de turmas.
            NTurma.Inserir(t);
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            list_turmas.ItemsSource = null;
            list_turmas.ItemsSource = NTurma.Listar();

        }

        private void excluir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void atualizar_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
