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

namespace _21._101_Dereev_Var5
{
    /// <summary>
    /// Логика взаимодействия для first.xaml
    /// </summary>
    public partial class first : Window
    {
        public first()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                int number;
                if (int.TryParse(NumberTextBox.Text, out number))
                {
                    if (NumberTextBox.Text.Length == 4) // Проверка длины числа
                    {
                        int sum = 0;
                        int product = 1;

                        while (number > 0)
                        {
                            int digit = number % 10;
                            sum += digit;
                            product *= digit;
                            number /= 10;
                        }

                        SumTextBlock.Text = "Сумма цифр: " + sum;
                        ProductTextBlock.Text = "Произведение цифр: " + product;
                    }
                    else
                    {
                        MessageBox.Show("Введите четырехзначное число.");
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректное число.");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SumTextBlock.Text = string.Empty;
            ProductTextBlock.Text = string.Empty;
        }
    }
}
