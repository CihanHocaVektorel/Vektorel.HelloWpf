using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic Collections
            //ArrayList al = new ArrayList();
            //al.Add(5);
            //al.Add(10);
            //al.Add(10);
            //al.Add(10);
            //al.Add(10);
            //al.Add(10);
            //al.Add(10);
            //al.Add(10);
            //al.Add(10);
            //al.Add("Ahmet");
            //al.Capacity = al.Count;
            //Console.WriteLine($"Kapasite:{al.Capacity}");
            //Console.WriteLine($"Eleman Sayısı:{al.Count}");

            //foreach (object item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}

            //Hashtable ht = new Hashtable();
            //ht.Add(6, "Ankara");
            //ht.Add(34, "İstanbul");
            //ht.Add(35, "İzmir");


            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
            //}

            //Console.WriteLine("Plaka gir");
            //int plaka = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Plakası {plaka} olan şehir:{ht[plaka]}");

            //Queue q = new Queue();

            //q.Enqueue("Muharrem");
            //q.Enqueue("Kemal");
            //q.Enqueue("Halil İbo");
            //q.Enqueue("Habip");

            //// Console.WriteLine(q.Peek());
            //q.Dequeue();
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item);
            //}

            // Stack s = new Stack();
            // s.Push("Muharrem");
            // s.Push("Kemal");
            // s.Push("Halil İbo");
            // s.Push("Habip");
            // //foreach (var item in s)
            // //{
            // //    Console.WriteLine(item);
            // //}            
            //// Console.WriteLine(s.Peek());
            // s.Pop();
            // foreach (var item in s)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            //Islem<int,string> islem = new Islem<int,string>();

            //islem.value = 5;
            //islem.value_ = "5";
            //islem.Yazdir();  

            //Dictionary<byte, string> plakalar = new Dictionary<byte, string>();
            //plakalar.Add(6, "Ankara");


            //foreach (KeyValuePair<byte,string> item in plakalar)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //List<int> lst = new List<int>();
            //lst.Add(5);
            //lst.Add(125);


            //List<Ogrenci> lst = new List<Ogrenci>();
            //lst.Add(new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet" });
            //lst.Add(new Ogrenci { Ad = "Osman", Soyad = "Mosman" });

            //foreach (Ogrenci item in lst)
            //{
            //    Console.WriteLine($"{item.Ad} {item.Soyad}");
            //}

            List<Ogrenci> lst = new List<Ogrenci>();
            while (true)
            {
                Ogrenci ogr = new Ogrenci();
                Console.WriteLine("Ogrenci Adı Giriniz");
                ogr.Ad = Console.ReadLine();
                Console.WriteLine("Soyadı Giriniz:");
                ogr.Soyad = Console.ReadLine();
                lst.Add(ogr);
                Console.WriteLine("Tamam/Devam");
                string cevap = Console.ReadLine();
                if (cevap=="T")               
                    break;                
            }





            Console.ReadKey();
        }
    }

    class Deneme : IDeneme
    {
        public int DigerMetod(int sayi)
        {
            throw new NotImplementedException();
        }

        public void TestMetodu()
        {
            throw new NotImplementedException();
        }
    }

    interface IDeneme
    {
        void TestMetodu();
        int DigerMetod(int sayi);
    }


    class Islem<T>
    {
       // public T value;
        //public U value_;
        public void Yazdir(T value)
        {
            Console.WriteLine(value);           
        }
    }



    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
