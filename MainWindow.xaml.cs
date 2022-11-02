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

namespace WPF_Rassokhin_PR7
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

        float a, b;
        int count;
        bool znak = true;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void M_g_Checked(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "1. Геркулес 200 рублей ";
            Itog_3.Text = Itog_3.Text + 250;
        }

        private void By(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "2. Булочка с сгущенкой 20 рублей ";
            Itog_3.Text = Itog_3.Text + 20;
        }

        private void hai(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "3. Чай 10 рублей ";
            Itog_3.Text = Itog_3.Text + 10;
        }
        private void MK(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "4. Котлета свиная 50 рублей ";
            Itog_3.Text = Itog_3.Text + 50;
        }
        private void M_KM(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "5. Картошка с мясом 250 рублей ";
            Itog_3.Text = Itog_3.Text + 250;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            a = float.Parse(Itog_3.Text);
            Itog_3.Text = a.ToString() + "+";
            znak = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = a + float.Parse(Itog_3.Text);
            Itog_2.Text = b.ToString();
        }
    }
}
