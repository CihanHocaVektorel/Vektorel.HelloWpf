using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Vektorel.HelloWpf
{
    public partial class KacanButon : Window
    {
        #region Tanımlamalar
        DispatcherTimer timer = new DispatcherTimer();
        int sure = 0;
        int puan = 0;
        int left = 0;
        Oyuncu o;
        #endregion

        #region Constructorlar
        public KacanButon()
        {
            InitializeComponent();
            OyunuBaslat();
        }

        public KacanButon(Oyuncu o)
        {
            InitializeComponent();
            this.o = o;
            lblAdSoyad.Content = $"{o.Ad} {o.Soyad}";
            timer.Tick += Timer_Tick;
            OyunuBaslat();
            //lblSure.Content = sure;            
        } 
        #endregion

        #region Timer Tick Eventi
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sure == 0)
            {
                SkorKaydet(puan, DateTime.Now, o);
                timer.Stop();
                btnKac.Visibility = Visibility.Hidden;
                MessageBoxResult cevap = MessageBox.Show($"Oyun Bitti!\nPuanınız:{puan}\nYeniden Başlamak İster misiniz?", "Game Over", MessageBoxButton.YesNo);
                if (cevap == MessageBoxResult.Yes)
                {
                    OyunuBaslat();
                }
                else
                {
                    MessageBox.Show("Bitti");
                    Application.Current.Shutdown();
                }
            }
            else
            {
                lblSure.Content = sure;
                sure--;
            }
        } 
        #endregion

        #region Oyunu Başlatan Metod
        public void OyunuBaslat()
        {
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            sure = 3;
            puan = 0;
            lblPuan.Content = puan;
            btnKac.Visibility = Visibility.Visible;
            this.WindowState = WindowState.Maximized;
        }
        #endregion

        #region Button Mouse Move Eventi
        private void BtnKac_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            // btnKac.Margin = new Thickness(rnd.Next((int)(this.ActualWidth - btnKac.Width - 2 * SystemParameters.BorderWidth)), rnd.Next((int)(this.ActualHeight - btnKac.Height - SystemParameters.CaptionHeight - 2 * SystemParameters.BorderWidth)), 0, 0);
            left = rnd.Next((int)(grdIcerik.ColumnDefinitions[0].ActualWidth - btnKac.Width));
            btnKac.Margin = new Thickness(rnd.Next((int)(grdIcerik.ColumnDefinitions[0].ActualWidth - btnKac.Width)), rnd.Next((int)(grdIcerik.ActualHeight - btnKac.Height)), 0, 0);
            puan++;
            lblPuan.Content = puan;
        }
        #endregion/**/

        #region Skor Kayıt İşlemi
        void SkorKaydet(int puan, DateTime tarih, Oyuncu o)
        {
            File.AppendAllText(@"D:\Skorlar.txt", $"{o.Ad} {o.Soyad} isimli oyuncu {tarih} tarihinde {puan} puan aldı.\r\n");
        }
        #endregion

        private void BtnSkorGoster_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show(File.ReadAllText(@"D:\Skorlar.txt"));
        }
    }
}
