﻿using Apallon1;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage());
            Manager.MainFrame = MainFrame;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

          
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.GoBack();

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                btn_back.Visibility = Visibility.Visible;
            }
            else
            {
                //MessageBox.Show("Что закрывать будем ?", "Вопрос на засыпку");
               // btn_back.Visibility = Visibility.Hidden;
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_prof_go_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке", "Профиль");
        }

        private void Btn_help_go_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке", "Помощь");
        }

        private void Btn_go_LoginEnterPage_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new LoginEnterPage());
        }
    }
}