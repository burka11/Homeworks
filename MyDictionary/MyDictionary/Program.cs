using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> sehirler = new MyDictionary<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");

            Console.WriteLine(sehirler.Count + " elemanlıdır.");
        }
    }
}
