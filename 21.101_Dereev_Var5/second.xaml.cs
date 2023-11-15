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
    /// Логика взаимодействия для second.xaml
    /// </summary>
    public partial class second : Window
    {
        public second()
        {
            InitializeComponent();
        }

        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            string sentence = SentenceTextBox.Text;
            string encryptedSentence = EncryptSentence(sentence);
            EncryptedSentenceTextBlock.Text = encryptedSentence;
        }

        private string EncryptSentence(string sentence)
        {
            StringBuilder encryptedSentence = new StringBuilder();

            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = EncryptCharacter(c);
                    encryptedSentence.Append(encryptedChar);
                }
                else
                {
                    encryptedSentence.Append(c);
                }
            }

            return encryptedSentence.ToString();
        }

        private char EncryptCharacter(char c)
        {
            const string alphabetLower = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            const string alphabetUpper = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            int index;
            bool isLower = char.IsLower(c);

            if (isLower)
            {
                index = alphabetLower.IndexOf(c);
                index = (index + 1) % alphabetLower.Length;
                return alphabetLower[index];
            }
            else
            {
                index = alphabetUpper.IndexOf(c);
                index = (index + 1) % alphabetUpper.Length;
                return alphabetUpper[index];
            }
        }

        private void main(object sender, RoutedEventArgs e)
        {

        }

        private void SentenseTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
