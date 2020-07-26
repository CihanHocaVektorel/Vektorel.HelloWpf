using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.HelloWpf.Models
{
    public class Skor
    {
        public Skor()
        {

        }

        public Skor(Oyuncu o, int puan, DateTime tarih)
        {
            this.Puan = puan;
            this.Tarih = tarih;
            this.Player = o;
        }

        public int Puan { get; set; }
        public DateTime Tarih { get; set; }
        public Oyuncu Player { get; set; }
    }
}
