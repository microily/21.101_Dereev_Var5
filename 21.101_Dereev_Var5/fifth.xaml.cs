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
    /// Логика взаимодействия для fifth.xaml
    /// </summary>
    public partial class fifth : Window
    {
        public fifth()
        {
            InitializeComponent();
        }

        private void MainWindow3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            mas1.Text = "";
            mas2.Text = "";
            mas3.Text = "";
            int M = Convert.ToInt32(NumberM.Text);
            int N = Convert.ToInt32(NumberN.Text);
            if (M > 0 && N > 0)
            {
                int a;
                int max = 0;
                int min = 1000000000;
                int n;
                Random rnd = new Random();
                int[] arr1 = new int[M * N];
                int[,] arr = new int[M, N];
                for (n = 0; n < M * N; n++)
                {
                    arr1[n] = rnd.Next(-10, 10);
                }
                n = 0;
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        arr[i, j] = arr1[n];
                        n++;
                    }
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        mas1.Text += Convert.ToString(arr[i, j] + ", ");
                        if (max < arr[i, j])
                        {
                            max = arr[i, j];
                        }
                        else if (min > arr[i, j])
                        {
                            min = arr[i, j];
                        }
                        if (j == N - 1)
                        {
                            mas1.Text += "\n";
                        }

                    }
                }
                max1.Text = max.ToString();
                min1.Text = min.ToString();
                n = 0;
                Array.Sort(arr1);
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        arr[i, j] = arr1[n];
                        n++;
                    }
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        mas2.Text += Convert.ToString(arr[i, j] + ", ");
                        if (j == N - 1)
                        {
                            mas2.Text += "\n";
                        }
                    }
                }
                Array.Reverse(arr1);
                n = 0;
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        arr[i, j] = arr1[n];
                        n++;
                    }
                }
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        mas3.Text += Convert.ToString(arr[i, j] + ", ");
                        if (j == N - 1)
                        {
                            mas3.Text += "\n";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите количество больше нуля");
            }
        }
    }
    }
