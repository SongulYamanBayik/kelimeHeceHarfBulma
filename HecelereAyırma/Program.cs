using System;

namespace HecelereAyırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            int kelime = 0;
            int harf = 0;
            int hece1 = 0;
            string[] hece = { "a", "e", "i", "ı", "o", "ö", "u", "ü" };
            Console.WriteLine("Bir Cümle Giriniz.");
            cumle = Console.ReadLine();
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i].ToString() == " ")
                {
                    kelime++;
                }
                harf = cumle.Length;
            }
            foreach (char item in cumle)
            {
                for (int j = 0; j <hece.Length; j++)
                {
                    if (item.ToString() == hece[j])
                    {
                        hece1++;
                    }
                }
                
            }
           
            Console.WriteLine("Hece Sayısı: " + hece1);
            Console.WriteLine("Kelime Sayısı: "+ (kelime+1));
            Console.WriteLine("Harf Sayısı: "+ (harf-(kelime)));
        }
    }
}
