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

namespace WpfLabPavina
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.Orange);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Павина Софья ПР-31", "О разработчике");
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            window.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Павина Софья ПР-31", "О разработчике");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            window.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.Orange);
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            status.Text = "Color: LightPink Text: Розовый";
        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            status.Text = "Color: Orange Text: Оранжевый";
        }

        private void MenuItem_MouseEnter_2(object sender, MouseEventArgs e)
        {
            status.Text = "Color: LightGreen Text: Зелёный";
        }

        private void razrab_MouseEnter(object sender, MouseEventArgs e)
        {
            status.Text = "Text: Информация о разработчике MessageText: Павина Софья ПР-31";
        }

        private void MenuItem_MouseEnter_3(object sender, MouseEventArgs e)
        {
            status.Text = "Text: Закрыть Function: Close the window";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            pink.Height = 100;
            pink.Width = 100;
            status.Text = "Height: " + pink.ActualHeight + " Width: " + pink.ActualWidth + " ImgSource: https://cdn-icons-png.flaticon.com/512/4219/4219827.png";
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {

            orange.Height = 100;
            orange.Width = 100;
            status.Text = "Height: " + orange.ActualHeight + " Width: " + orange.ActualWidth + " ImgSource: Image/cat.png";
        }

        private void Button_MouseEnter_2(object sender, MouseEventArgs e)
        {

            green.Height = 100;
            green.Width = 100;
            status.Text = "Height: " + green.ActualHeight + " Width: " + green.ActualWidth + " ImgSource: Image/cat2.png";
        }

        private void Button_MouseEnter_3(object sender, MouseEventArgs e)
        {
            auphtor.Height = 100;
            auphtor.Width = 100;
            status.Text = "Height: " + auphtor.ActualHeight + " Width: " + auphtor.ActualWidth + " Text: Павина Софья ПР-31";
        }

        private void Button_MouseEnter_4(object sender, MouseEventArgs e)
        {
            bye.Height = 100;
            bye.Width = 100;
            status.Text = "Height: " + bye.ActualHeight + " Width: " + bye.ActualWidth + " Function: Close the window";
        }
    }
}
