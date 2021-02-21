using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Can";
            musteri1.MusteriSoyad = "TATLICI";
            musteri1.MusteriYasi = 22;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Engin";
            musteri2.MusteriSoyad = "DEMIROG";
            musteri2.MusteriYasi = 34;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Mehmet";
            musteri3.MusteriSoyad = "Ciğerci";
            musteri3.MusteriYasi = 26;

            Musteri[] musteri = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("Foreach ile");
            foreach (var listele in musteri)
            {
                Console.WriteLine("*****Müsteriler ****");
                Console.WriteLine("Müşteri ID : " + listele.MusteriId);
                Console.WriteLine(listele.MusteriAdi);
                Console.WriteLine(listele.MusteriSoyad);
                Console.WriteLine(listele.MusteriYasi);
                Console.WriteLine("___________________________\n");
            }
            Console.WriteLine("For döngüsü ile");


            Console.WriteLine("*****Müsteriler ****");
            for (int i = 0; i < musteri.Length; i++)
            {

                Console.WriteLine("Müşteri ID : " + musteri[i].MusteriId);
                Console.WriteLine(musteri[i].MusteriAdi);
                Console.WriteLine(musteri[i].MusteriSoyad);
                Console.WriteLine(musteri[i].MusteriYasi);
                Console.WriteLine("___________________________\n");
            }

            //Musteri Ekleme

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);

            //Musteri Silme

            MusteriManager musterimanager2 = new MusteriManager();
            musterimanager2.Sil(musteri1);
            musterimanager2.Sil(musteri2);
            musterimanager2.Sil(musteri3);


            Console.ReadLine();







        }
    }
}
