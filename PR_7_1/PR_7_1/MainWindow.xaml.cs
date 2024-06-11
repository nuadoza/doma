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

namespace PR_7_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Оба не правы!");

            ArgumentsList.Text = "Аргументы правоты в споре:";
            ArgumentsList.Text += "\n1. Я прав потому что...";
            ArgumentsList.Text += "\n2. Ты не прав потому что...";
            ArgumentsList.Text += "\n3. Ладно, мы оба не правы...";
            ArgumentsList.Text += "\n4. Я не прав потому что...";
            ArgumentsList.Text += "\n5. Ты прав, потому что...";
        }
    }
}
