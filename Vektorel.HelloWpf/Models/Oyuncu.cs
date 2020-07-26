using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.HelloWpf.Models
{//Model Classları
    public class Oyuncu
    {
        //public string Ad { get; set; }
        //public string Soyad { get; set; }

        string ad;
        string soyad;

        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }
    }
}
