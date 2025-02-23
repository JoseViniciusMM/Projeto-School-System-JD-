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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System_Escola.Views;

namespace System_Escola
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cadastro cha = new Cadastro();
            cha.ShowDialog();
        }


        private void Button_listar(object sender, RoutedEventArgs e)
        {
            ListaCurso cha = new ListaCurso();
            cha.ShowDialog();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            CadastroCurso cha = new CadastroCurso();
            cha.ShowDialog();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ListaCurso cha = new ListaCurso();
            cha.ShowDialog();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            ListarEscola cha = new ListarEscola();
            cha.ShowDialog();
        }
    }
}
