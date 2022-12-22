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

namespace MultiEdit
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            LittleTextBox1.Text = BigTextbox1.Text;
            LittleTextBox2.Text = BigTextbox1.Text;
            LittleTextBox3.Text = BigTextbox1.Text;
            LittleTextBox4.Text = BigTextbox1.Text;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            SecTextBox1.Text = SecBigTextbox.Text;
            SecTextBox2.Text = SecBigTextbox.Text;
            SecTextBox3.Text = SecBigTextbox.Text;
            SecTextBox4.Text = SecBigTextbox.Text;
        }

    }
}
