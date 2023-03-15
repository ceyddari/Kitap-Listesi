using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class LinkedList
    {
        string deger;
        public Node root;

        public LinkedList()
        {
            root = null;
        }

        public void ekle(string data)
        {
            Node eleman = new Node(data);
            if (root == null)
            {
                root = eleman;
                Console.WriteLine("liste oluşturuldu, ilk eleman eklendi");
            }
            else
            {
                eleman.next = root;
                root = eleman;

                Console.WriteLine("eleman eklendi");
            }

        }
        public void yazdir()
        {
            Node temp = root;

            if (root == null)
                Console.WriteLine("liste boş");
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;

                }
                Console.Write(temp.data);

            }

        }



        public void aradanSil(int indis)
        {
            bool sonuc = false;

            if (root == null)
            {
                sonuc = true;
                Console.WriteLine("liste boş");

            }
            else if (root.next == null && indis == 0)

            {
                sonuc = true;
                root = null;
                Console.WriteLine("listede kalan son elenan da silindi");

            }
            else if (root.next! == null && indis == 0)

            {
                sonuc = true;

                Console.WriteLine("eleman silindi");

            }
            else
            {
                int i = 0;

                Node temp = root;
                Node temp2 = temp;

                while (temp.next != null)
                {
                    if (i == indis)
                    {
                        sonuc = true;
                        temp2.next = temp.next;
                        Console.WriteLine("aradan eleman silindi");
                        i++;
                        break;

                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;

                }
                if (i == indis)
                {
                    sonuc = true;
                    temp2.next = null;
                    Console.WriteLine("aradan eleman silindi");
                    i++;

                }

            }
            if (sonuc == false)
                Console.WriteLine("hatalı bir indis girişi yaptınız!");

        }

        public void elemanSay()
        {
            int sayac = 0;
            if (root == null)
                Console.WriteLine("eleman sayısı : " + sayac);
            else
            {
                Node temp = root;

                while (temp.next != null)
                {
                    sayac++;
                    temp = temp.next;

                }
                sayac++;
                Console.WriteLine("eleman sayısı: " + sayac); 

            }
        }

        public void istenilenDeger(string deger)
        {
            Node istenilendeger = new Node(deger);
            int sayac = 1;
            while (root != null)
            {
                if (deger == root.data)
                    
                {
                    Console.WriteLine("Kitabınız bulundu: " + deger + ", " + sayac + ". sırada");
                    break;
                }
                else
                {
                    root = root.next;
                    sayac++; 
                   

                }
                
            }
        }

        internal void istenilenDeger()
        {
            throw new NotImplementedException();
        }
    }
}
