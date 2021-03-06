﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Vektorel.HelloWpf.Models;

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
        List<int> skorlar = new List<int>();
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
                SkorKaydet(new Skor(o, puan, DateTime.Now));
                timer.Stop();
                btnKac.Visibility = Visibility.Hidden;
                MessageBoxResult cevap = MessageBox.Show($"Oyun Bitti!\nPuanınız:{puan}\nYeniden Başlamak İster misiniz?", "Game Over", MessageBoxButton.YesNo);
                skorlar.Add(puan);
                if (cevap == MessageBoxResult.Yes)
                {                    
                    OyunuBaslat();
                }
                else
                {
                    int maxpuan = 0;
                    int minpuan = skorlar[0];
                    foreach (int item in skorlar)
                    {
                        if (item>maxpuan)
                        {
                            maxpuan = item;
                        }
                        if (item<minpuan)
                        {
                            minpuan = item;
                        }
                    }                   
                    MessageBox.Show($"Bitti.En yüksek skorunuz:{maxpuan}\nEn düşük Skorunuz:{minpuan}");
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
        void SkorKaydet(Skor s)
        {
            File.AppendAllText(@"D:\Skorlar.txt", $"{s.Player.Ad} {s.Player.Soyad} isimli oyuncu {s.Tarih} tarihinde {s.Puan} puan aldı.\r\n");
        }
        #endregion

        private void BtnSkorGoster_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show(File.ReadAllText(@"D:\Skorlar.txt"));
        }
    }
}
