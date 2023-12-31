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

namespace Portfolio
{
    
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Calendar(object sender, RoutedEventArgs e)
        {
            Window calendar = new Calendar(this);
            calendar.Show();
            calendar.Focus();
            Visibility = Visibility.Hidden;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Events(object sender, RoutedEventArgs e)
        {
            Window events = new Events(this);
            events.Show();
            events.Focus();
            Visibility = Visibility.Hidden;
            
        }

        private void Raports(object sender, RoutedEventArgs e)
        {
            Window raports = new Raports(this);
            raports.Show();
            raports.Focus();
            Visibility = Visibility.Hidden;
           
        }
    }
}
