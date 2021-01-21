using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        Dictionary<TKey, TValue> Ogrenciler;
        public MyDictionary()
        {
            Ogrenciler = new Dictionary<TKey, TValue>();
        }
        public void Add(TKey tKey, TValue tValue)
        {
            Ogrenciler.Add(tKey, tValue);
            Console.WriteLine(tValue + " eklendi.");
        }

        public int Count
        {
            get { return Ogrenciler.Count; }

        }
        public void List()
        {
            foreach (KeyValuePair<TKey, TValue> veri in Ogrenciler)
            {
                Console.WriteLine(" {0}       {1}", veri.Key, veri.Value);
            }
        }

    }
}
