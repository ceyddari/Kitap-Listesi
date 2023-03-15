using System;
using System.ComponentModel.Design;
using System.Net.Sockets;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string deger;
            int indis;
            LinkedList tyList = new LinkedList();

            int secim = menu();
            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("Kitap ismini giriniz:  "); deger = Console.ReadLine();   
                        tyList.ekle(deger);
                            break;


                    case 2:
                        Console.Write("indis: "); indis = int.Parse(Console.ReadLine());
                        tyList.aradanSil(indis);
                        break;

                    case 3:
                        tyList.elemanSay();
                        break;

                    case 4:
                        Console.Write("Kitap ismini giriniz:  "); deger = Console.ReadLine();
                        tyList.istenilenDeger(deger);
                        break;


                    case 0:
                        break;

                    default: Console.WriteLine("hatalı seçim yaptınız"); 
                        break;

                }
                tyList.yazdir();
                Console.WriteLine();
                secim = menu();
            }


            Console.ReadKey();

        }
      
        private static int menu()
        {
            int secim;
            Console.WriteLine("0- programı kapat ");
            Console.WriteLine("\n1- eleman ekle");
            Console.WriteLine("2- eleman sil");
            Console.WriteLine("3- eleman sayısı");
            Console.WriteLine("4- eleman arayınız");


            Console.Write("seçiminiz: ");
            secim = int.Parse(Console.ReadLine());
            return secim;

            
         

        }
    }
}
