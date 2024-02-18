using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{ 
     class Program
    {
       static void Main(string[] args)
        {
        

            Person person1 = new Person();
            person1.FirstName = "Şafak";
            person1.LastName = "ATASEVER";
            person1.DateOfBirthYear = 123;
            person1.NationalIdentity = 1;


            Person person2 = new Person();
            person2.FirstName = "Mert";

            Console.WriteLine("\nPtt aracılığı ile MASKE");
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.WriteLine("\nEczane aracılığı ile MASKE");
            PharmacyManager pharmacyManager = new PharmacyManager(new PersonManager());
            pharmacyManager.GiveMask(person1);
          
            //SelamVer(isim: "Engin");
            //SelamVer(isim: "Türker");
            //SelamVer(isim: "Nalan");
            //SelamVer();
            //int sonuc = Topla(3,5);
            ////Diziler/ Arrays
            //string ogrenci1 = "Safak";
            //string ogrenci2 = "Mert";
            //string ogrenci3 = "Emir";
            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "Safak";
            //ogrenciler[1] = "Mert";
            //ogrenciler[2] = "Emir";
            Console.ReadLine();
        }
       

       
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim );
        }
        static int Topla(int sayi1,int sayi2) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc);
            return sonuc; 
        }


        public static void Degiskenler()
        {
            string mesaj = "Merhabalar";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi=false;

            string ad = "Şafak";
            string soyad = "Atasever";
            int dogumYili = 2001;
            long tcNo = 12345678910;
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
            Console.ReadLine();


        }
    }

   

    //pascal casing

}
