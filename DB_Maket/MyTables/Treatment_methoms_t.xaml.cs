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

namespace DB_Maket.MyTables
{
    /// <summary>
    /// Interaction logic for Treatment_methoms_t.xaml
    /// </summary>
    public partial class Treatment_methoms_t : Window
    {
        public Treatment_methoms_t()
        {
            InitializeComponent();

            if (MainWindow.isAdmin == true)
            {
                Go_to_form.Visibility = Visibility.Visible;
                Go_to_form.IsEnabled = true;

            }
            else
            {
                Go_to_form.Visibility = Visibility.Collapsed;
                Go_to_form.IsEnabled = false;
            }
        }

        private void Comeback_button_Click(object sender, RoutedEventArgs e)
        {
            Tables tb = new Tables();
            tb.Show();
            this.Close();
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Go_to_form_Click(object sender, RoutedEventArgs e)
        {
            Treatment_methoms_f ww = new Treatment_methoms_f();
            ww.Show();
            this.Close();
        }
    }


}