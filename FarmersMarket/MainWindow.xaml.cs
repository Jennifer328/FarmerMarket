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

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sales_Click(object sender, RoutedEventArgs e)
        {
            SalesWithRESTApi salesWithRESTApi = new SalesWithRESTApi();
            salesWithRESTApi.Show();
            this.Close();
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            AdminWithRESTApi adminWithRESTApi = new AdminWithRESTApi();
            adminWithRESTApi.Show();
            this.Close();
        }
    }
}
