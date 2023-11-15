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
    /// Логика взаимодействия для fourth.xaml
    /// </summary>
    public partial class fourth : Window
    {
        public fourth()
        {
            InitializeComponent();
        }

        private void MainWindow2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(SizeTextBox.Text, out int size))
            {
                int[] array = GenerateRandomArray(size);

                int minIndex = Array.IndexOf(array, array.Min());
                int maxIndex = Array.IndexOf(array, array.Max());

                if (minIndex < maxIndex)
                {
                    Array.Reverse(array, minIndex + 1, maxIndex - minIndex - 1);
                }
                else
                {
                    Array.Reverse(array, maxIndex + 1, minIndex - maxIndex - 1);
                }

                GenerationTextBlock.Text = "Сгенерированный массив" + string.Join(", ", array    );
                ResultTextBlock.Text = "Переставленный массив: " + string.Join(", ", array);
            }
            else
            {
                MessageBox.Show("Некорректный размер массива. Пожалуйста, введите целое число.");
            }
        }

        private int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101); // Генерация случайного числа от 1 до 100
            }

            return array;
        }
    }
}
