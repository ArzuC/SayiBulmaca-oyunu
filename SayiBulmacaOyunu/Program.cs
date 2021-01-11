using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool devamMı = false;
            while (devamMı != true)
            {
                Console.WriteLine("Minimum değeri giriniz:");
                int MinimumDeger = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maksimum değeri giriniz:");
                int MaksimumDeger = Convert.ToInt32(Console.ReadLine());
                Random rastgeleSayiUretici = new Random();
                int uretilenSayi = rastgeleSayiUretici.Next(MinimumDeger, MaksimumDeger);

                bool sayiBulunduMu = false;

                while (sayiBulunduMu == false)
                {
                    Console.WriteLine("Bir sayi giriniz:");
                    int girilenSayi = Convert.ToInt32(Console.ReadLine());
                    if (girilenSayi > uretilenSayi)
                    {
                        Console.WriteLine("Aşagi");
                    }
                    else if (girilenSayi < uretilenSayi)
                    {
                        Console.WriteLine("Yukari");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler tahmin edilen sayi ile üretilen sayi eşittir. Girilen sayi = {0}", girilenSayi);
                        sayiBulunduMu = true;
                        Console.WriteLine("Tekrar oynamak ister misiniz ? : (Evet=E / Hayır= H)");
                        char cevap = Convert.ToChar(Console.ReadLine());
                        if (cevap == 'E' || cevap == 'e')
                        {
                            devamMı = false;
                        }
                        else
                        {
                            devamMı = true; return;
                        }
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
