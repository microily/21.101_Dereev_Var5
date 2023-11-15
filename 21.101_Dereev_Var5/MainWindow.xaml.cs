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

namespace _21._101_Dereev_Var5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            first First = new first();
            First.Show();
            this.Close();
        }

        private void second_Click(object sender, RoutedEventArgs e)
        {
            second Second = new second();
            Second.Show();
            this.Close();
        }

        private void third_Click(object sender, RoutedEventArgs e)
        {
            third Third = new third();
            Third.Show();
            this.Close();
        }

        private void fourth_Click(object sender, RoutedEventArgs e)
        {
            fourth Fourth = new fourth();
            Fourth.Show();
            this.Close();
        }

        private void fifth_Click(object sender, RoutedEventArgs e)
        {
            fifth Fifth = new fifth();
            Fifth.Show();
            this.Close();
        }
    }
}
