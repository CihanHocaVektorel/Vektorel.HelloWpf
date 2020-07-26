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

            ////foreach (DictionaryEntry item in ht)
            ////{
            ////    Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
            ////}

            //Console.WriteLine("Plaka gir");
            //int plaka = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Plakası {plaka} olan şehir:{ht[plaka]}");

            // Queue q = new Queue();

            // q.Enqueue("Muharrem");
            // q.Enqueue("Kemal");
            // q.Enqueue("Halil İbo");
            // q.Enqueue("Habip");

            //// Console.WriteLine(q.Peek());
            // q.Dequeue();
            // foreach (var item in q)
            // {
            //     Console.WriteLine(item);
            // }

            Stack s = new Stack();
            s.Push("Muharrem");
            s.Push("Kemal");
            s.Push("Halil İbo");
            s.Push("Habip");
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}            
           // Console.WriteLine(s.Peek());
            s.Pop();
            foreach (var item in s)
            {
                Console.WriteLine(item);
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


}
