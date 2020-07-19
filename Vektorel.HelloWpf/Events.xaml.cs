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

namespace Vektorel.HelloWpf
{
    /// <summary>
    /// Interaction logic for Events.xaml
    /// </summary>
    public partial class Events : Window
    {
        int toplam = 0;
        public Events()
        {
            InitializeComponent();
            Random rnd = new Random();
            //btn1.Content = rnd.Next(10, 100);
            //btn2.Content = rnd.Next(10, 100);
            //btn3.Content = rnd.Next(10, 100);

            foreach (UIElement item in grd.Children)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    if (btn.Tag != null && btn.Tag.ToString() == "1")
                    {
                        btn.Content = rnd.Next(10, 100);
                    }
                }
            }
        }

        private void Msg(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnSonuc")
            {
                MessageBox.Show($"İşlemin Sonucu:{toplam}");
            }
            else
            {
                toplam += Convert.ToInt32(btn.Content);
                btn.Visibility = Visibility.Hidden;
            }
        }
    }
}
