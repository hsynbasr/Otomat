using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.hafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler ={ "kola", "bisküvi", "çikolata" };
            int[] fiyat ={ 15, 9, 6 };
            string kullanıcıadı = "admin";
            string sifre = "1234";
            Console.WriteLine("        ***Hoşgeldiniz***");
            
            while (true)
            {
                Console.WriteLine("\n1-Kullanıcı Girişi\n2-Admin Girişi");
                int girissecim = Convert.ToInt32(Console.ReadLine());

                if (girissecim == 1)
                {
                    while (true)
                    {


                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine((i + 1) + ".Ürün " + urunler[i] + "= " + fiyat[i] + " TL");
                        }
                        Console.Write("\n Almak İstediğiniz Ürünü Yazınız  :  ");
                        string urunsecim = Console.ReadLine();

                        int arraysayi = Array.IndexOf(urunler, urunsecim);

                        if (arraysayi >= 0)
                        {
                            Console.WriteLine("Lütfen Ödeme için bir tutar giriniz");
                            Console.Write("Yatırılan Tutar : ");
                            int musteripara = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nİşleminiz Kontrol Ediliyor...\nLütfen Bekleyiniz");
                            Thread.Sleep(1000);
                            int paraustu = musteripara - fiyat[arraysayi];
                            Thread.Sleep(1000);
                            Console.WriteLine("Para Üstünüz : " + paraustu);
                           
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş:");
                            continue;
                        }
                        
                    }
                }
                else if (girissecim == 2)
                {
                    while (true)
                    {


                        Console.Write("Kullanıcı Adı : ");
                        string kullanicigiris = Console.ReadLine();
                        Console.Write("Şifre         : ");
                        string sifregiris = Console.ReadLine();
                        if (kullanıcıadı == kullanicigiris && sifre == sifregiris)
                        {
                            Console.Write("\nKaç Ürün Ekleyeceksiniz : ");
                            int uruneklemeadedi = Convert.ToInt32(Console.ReadLine());
                            Array.Resize(ref urunler, (3 + uruneklemeadedi));
                            Array.Resize(ref fiyat, (3 + uruneklemeadedi));
                            for (int i = 0; i < uruneklemeadedi; i++)
                            {
                                Console.WriteLine("-----------------------------------");
                                Console.Write((i + 1) + ".Eklenecek Ürünü Giriniz : ");
                                string yeniurun = Console.ReadLine();
                                Console.Write("Eklenecek Ürün Fiyatı Giriniz  : ");
                                int yenifiyat = Convert.ToInt32(Console.ReadLine());
                                urunler[i + 3] = yeniurun;
                                fiyat[i + 3] = yenifiyat;
                            }
                            Console.WriteLine("\nİşleminiz Yapılıyor...");
                            Thread.Sleep(2000);
                            Console.WriteLine("\nEklediğiniz Ürünler...");
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                if (i > 2)
                                {
                                    Console.WriteLine("\n---------------------------");
                                    Console.WriteLine("\n" + (i - 2) + ".Ürün  " + urunler[i] + "  " + fiyat[i] + " TL");

                                }

                            }
                            break;

                        }
                        else
                        {
                            Console.WriteLine("\nHatalı Giriş...");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nHatalı giriş");
                    continue;
                }
            }
            Console.ReadLine();

        
        
        
        
        }
    }
}
