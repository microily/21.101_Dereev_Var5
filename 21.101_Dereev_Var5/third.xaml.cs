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
    /// Логика взаимодействия для third.xaml
    /// </summary>
    public partial class third : Window
    {

        public third()
        {
            InitializeComponent();
        }

        private void MainWindow1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(SizeTextBox.Text, out int size))
            { 
            int[] array = GenerateRandomArray(size);

            int[] evenNumbers = array.Where(x => x % 2 == 0).ToArray();
            int[] oddNumbers = array.Where(x => x % 2 != 0).ToArray();

            string evenNumbersString = string.Join(", ", evenNumbers);
            string oddNumbersString = string.Join(", ", oddNumbers);

            RandomArrayTextBlock.Text = "Сгенерированный массив: " + string.Join(", ", array);
            ResultTextBlock.Text = "Четные элементы: " + evenNumbersString + "\nНечетные элементы: " + oddNumbersString;
        }
        else 
        {
                MessageBox.Show("Некоректный размер массива. Введите целое число");
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
