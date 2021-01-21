using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();
            Ogrenci.Add(134, "Ahmet Öz");
            Ogrenci.Add(158, "Gülşah El");
            Ogrenci.Add(115, "Serpil Öz");
            Ogrenci.Add(174, "Muzaffer Öv");
            Console.WriteLine();
            Console.WriteLine("Toplam Öğrenci Sayısı: " + Ogrenci.Count);
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("Öğrenci Listesi");
            Console.WriteLine("=============================");
            Console.WriteLine("|Numara  | Ad Soyad     |");
            Console.WriteLine("------------------------");
            Ogrenci.List();
            Console.WriteLine("------------------------");
        }
    }
}
