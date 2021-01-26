using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<string, string> dictionary1 = new MyDictionary<string, string>();
            dictionary1.Add("Mavi", "Blue");
            dictionary1.Add("Yeşil", "Green");
            dictionary1.Add("Kırmızı", "Red");
            dictionary1.Add("Siyah", "Black");
            dictionary1.Add("Beyaz", "White");

        }
    }
}
