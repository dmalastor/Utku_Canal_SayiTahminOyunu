using System;

namespace Utku_Canal_SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte hak = 4, puan = 0, toppuan = 0, sayac = 1, sayi, randomsayi;
            char cevap;



            do
            {
                if (hak != 0)
                {
                    randomsayi = (byte)rnd.Next(1, 10);
                    Console.WriteLine(randomsayi);
                    Console.WriteLine("Bir sayı giriniz(1-10)");
                    sayi = byte.Parse(Console.ReadLine());


                    if (sayi != randomsayi)

                    {
                        hak--;
                        Console.WriteLine($"Bilemediniz kalan hakkınız= {hak}");
                    }
                    if (sayi == randomsayi)
                    {
                        if (hak == 4)
                        {
                            puan += 100;
                            toppuan += puan;

                        }
                        else if (hak == 3)
                        {
                            puan += 75;
                            toppuan += puan;
                        }
                        else if (hak == 2)
                        {
                            puan += 50;
                            toppuan += puan;
                        }
                        else if (hak == 1)
                        {
                            puan += 25;
                            toppuan += puan;
                        }
                        else if (hak == 0)
                        {
                            puan += 0;
                            toppuan += puan;
                        }
                        Console.WriteLine("Bildiniz");
                        Console.WriteLine("Devam etmek için (e) Çıkmak için (h) yazınız");
                        cevap = char.Parse(Console.ReadLine().ToLower());
                        sayac++;
                        if (cevap == 'h')
                        {
                            Console.WriteLine($"Çıkılıyor\nToplam puanınız= {toppuan / sayac}");
                            break;
                        }
                        hak = 4;
                    }
                }

                else
                {
                    Console.Write("Hakkınız bitti");
                    Console.WriteLine("Devam etmek için (e) Çıkmak için (h) yazınız");
                    cevap = char.Parse(Console.ReadLine().ToLower());
                    sayac++;
                    if (cevap == 'h')
                    {
                        Console.WriteLine($"Çıkılıyor\nToplam puanınızın ortalaması= {toppuan / sayac}");
                        break;
                    }
                    hak = 4;
                }



            } while (true);
        }
    }
}
