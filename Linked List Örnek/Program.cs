using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listemiz  list1 = new Listemiz();
            int secim = Menu();
            while(secim != 9)
            {
                if(secim == 1)
                {
                    Console.Write("Başa eklemek istediginiz datayı girin: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    list1.basaEkle(data);
                    list1.yazdır();
                    secim = Menu();
                }
                else if (secim == 2)
                {
                    Console.Write("Sona eklemek istediginiz datayı girin: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    list1.sonaEkle(data);
                    list1.yazdır();
                    secim = Menu();
                }
                else if (secim == 3)
                {
                    list1.bastanSil();
                    list1.yazdır();
                    secim = Menu();
                }
                else if (secim == 4)
                {
                    list1.sondanSil();
                    list1.yazdır();
                    secim = Menu();
                }
                else if (secim == 9)
                {
                    list1.yazdır();
                    Console.WriteLine("programdan çıkılıyor");
                    break;
                }
            }
            
        }

        public static  int Menu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - başa ekle");
            Console.WriteLine("2 - sona ekle");
            Console.WriteLine("3 - baştan sil");
            Console.WriteLine("4 - sondan sil");
            Console.WriteLine("9 - programdan çık");
            Console.Write("Seçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            return secim;
            
        }

        class Block
        {
            public int data;
            public Block next;
            public Block(int data)
            {   
                this.data = data;
                next = null;
            }

        }

        class Listemiz
        {
            Block head; // listenin başındaki block

            public Listemiz()
            {
                head = null;
            }

            public void basaEkle(int data)
            {
                Block eleman = new Block(data);

                if(head == null)
                {
                    head = eleman;
                }
                else
                {
                    eleman.next = head;
                    head = eleman;
                }        
            }

            public void sonaEkle(int data) 
            {
                Block elaman = new Block(data);
                if (head == null)
                {
                    // head null ise liste boş demek ve başa sona eleman eklemek headi elamana eşitlemekle olur
                    head = elaman;
                }
                else
                {
                    Block temp =head;
                    while(temp.next != null)
                    {
                        temp = temp.next;
                    }
                    // temp while'dan çıktıgında son elemanı tutmuş olur
                    temp.next = elaman;
                    
                }
            }
            public void bastanSil()
            {
                if(head == null)
                {
                    Console.WriteLine("Liste boş");
                }
                else if(head.next == null)
                {
                    head = null;
                    Console.WriteLine("listedeki tek data silindi");
                }
                else
                {
                    head= head.next;
                    //baştaki eleman silinir
                    Console.WriteLine("baştan data silindi");
                }
            }

            public void sondanSil()
            {


                if (head == null)
                {
                    Console.WriteLine("Liste boş");
                }
                else if (head.next == null)
                {
                    head = null;
                    Console.WriteLine("listedeki tek data silindi");
                }
                Block temp;
                temp= head;
                Block sondanocenki = temp;
                while(temp.next != null)
                {

                    sondanocenki = temp;
                    temp = temp.next;// son elemanı getirir 
                    //bize sondan bi önceki eleman gerekiyor
                }

                sondanocenki.next = null; // sondaki silindi
                Console.WriteLine("sondan data silindi");
            }
            public void yazdır()
            {
                if(head == null)
                {
                    Console.WriteLine("liste boş");
                }
                else
                {
                    Block temp = head;
                    Console.Write(" baş >> ");
                    while (temp.next  != null)
                    {
                        Console.Write(temp.data + " >> ");
                        temp = temp.next; 
                    }
                    Console.Write(temp.data + " >>son. ");
                }

            }

        }
    }
}
