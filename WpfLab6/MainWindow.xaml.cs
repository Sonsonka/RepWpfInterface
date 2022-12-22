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

namespace WpfLab6
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


        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = firstCombo1.SelectedIndex;
            if (index == 1)
            {
                firstText.Style = (Style)Resources["GradiendBox"];
            }
            else if (index == 0)
            {
                firstText.Style = (Style)Resources["DefaultBox"];
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int index = secCombo.SelectedIndex;
            if (index == 1)
            {
                secText.Style = (Style)Resources["GradiendBox"];
            }
            else if (index == 0)
            {
                secText.Style = (Style)Resources["DefaultBox"];
            }
        }

        private void firstCombo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int index = firstCombo2.SelectedIndex;
            if (index == 1)
            {
                firstText.FontFamily = new FontFamily("Comic Sans MS");
            }
            else if (index == 0)
            {
                firstText.FontFamily = new FontFamily("Segoe UI");
            }
            else if (index == 2)
            {
                firstText.FontWeight = FontWeights.Bold;
                firstText.FontSize = 18;
            }
            else if (index == 3)
            {
                firstText.FontStyle = FontStyles.Italic;
                firstText.FontSize = 12;
            }
        }

        private void secCombo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = secCombo2.SelectedIndex;
            if (index == 1)
            {
                secText.FontFamily = new FontFamily("Comic Sans MS");
            }
            else if (index == 0)
            {
                secText.FontFamily = new FontFamily("Segoe UI");
            }
            else if (index == 2)
            {
                secText.FontWeight = FontWeights.Bold;
                secText.FontSize = 18;
            }
            else if (index == 3)
            {
                secText.FontStyle = FontStyles.Italic;
                secText.FontSize = 12;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            firstText.IsEnabled = false;
            secText.IsEnabled = false;
        }

        private void firstText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (firstText.Text != "" && secText.Text != "")
            {
                CloseButton.IsEnabled = false;
            }
            else
            {
                CloseButton.IsEnabled = true;
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            firstText.IsEnabled = true;
            secText.IsEnabled = true;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            firstText.Text = string.Empty;
            secText.Text = string.Empty;
            secCombo2.SelectedIndex = 0;
            firstCombo1.SelectedIndex = 0;
            secCombo.SelectedIndex = 0;
            firstCombo2.SelectedIndex = 0;
        }


    }

}
