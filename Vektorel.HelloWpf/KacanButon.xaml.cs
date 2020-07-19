using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Vektorel.HelloWpf
{

    /// <summary>
    /// Interaction logic for KacanButon.xaml
    /// </summary>
    public partial class KacanButon : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int sure = 3;
        int puan = 0;
        int left = 0;
        public KacanButon()
        {
            InitializeComponent();
            // MessageBox.Show("Height:"+this.Height.ToString()+"\nMax Height:"+this.MaxHeight+"\nActual Height:"+this.ActualHeight);
            //ClientSize            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sure == 0)
            {
                timer.Stop();
                btnKac.Visibility = Visibility.Hidden;
                MessageBox.Show($"Oyun Bitti!\nPuanınız:{puan}");
            }
            else
            {
                sure--;
                lblSure.Content = sure;
            }
        }

        public KacanButon(string ad, string soyad)
        {
            InitializeComponent();
            lblAdSoyad.Content = $"{ad} {soyad}";
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void BtnKac_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            // btnKac.Margin = new Thickness(rnd.Next((int)(this.ActualWidth - btnKac.Width - 2 * SystemParameters.BorderWidth)), rnd.Next((int)(this.ActualHeight - btnKac.Height - SystemParameters.CaptionHeight - 2 * SystemParameters.BorderWidth)), 0, 0);
            left = rnd.Next((int)(grdIcerik.ColumnDefinitions[0].ActualWidth - btnKac.Width));
            btnKac.Margin = new Thickness(rnd.Next((int)(grdIcerik.ColumnDefinitions[0].ActualWidth - btnKac.Width)), rnd.Next((int)(grdIcerik.ActualHeight - btnKac.Height)), 0, 0);
            puan++;
            lblPuan.Content = puan;            
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

            // lblSize.Content = "Height:" + this.Height.ToString() + "\nMax Height:" + this.MaxHeight + "\nActual Height:" + this.ActualHeight + "\nRender Size Width:" + this.RenderSize.Width + "\nRender Size Height:" + this.RenderSize.Height + "\nBorderWidth:" + SystemParameters.BorderWidth + "\nCaption Height:" + SystemParameters.CaptionHeight;
        }

        void ClickEvent()
        {

        }

        private void ClickEvent(object sender, RoutedEventArgs e)
        {

        }

        private void BtnKac_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
