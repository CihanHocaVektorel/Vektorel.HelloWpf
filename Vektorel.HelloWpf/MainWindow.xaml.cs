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

namespace Vektorel.HelloWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string isim;
        public MainWindow()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Margin = new Thickness(100, 50, 0, 0);            
            btn.Content = "Hello Wpf!";
            btn.Width = 200;
            btn.Height = 50;
            btn.Click += Btn_Click;
            btn.MouseMove += Btn_MouseMove;
            grd.Children.Add(btn);   
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            lblDeneme.Content = "Mouse Move Çalıştı";
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click Çalıştı");
        }

        private void BtnBizimButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vektörel!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Move Tetiklendi");
        }
    }
}
