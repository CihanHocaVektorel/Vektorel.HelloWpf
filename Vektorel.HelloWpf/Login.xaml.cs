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
using Vektorel.HelloWpf.Models;

namespace Vektorel.HelloWpf
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, RoutedEventArgs e)
        {
            //Oyuncu oyn = new Oyuncu();
            //oyn.Ad = txtAd.Text;
            //oyn.Soyad = txtSoyad.Text;
            KacanButon kacanButon = new KacanButon(new Oyuncu { Ad = txtAd.Text, Soyad = txtSoyad.Text });
            kacanButon.Show();
        }
    }
}
