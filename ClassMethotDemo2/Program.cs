using System;

namespace ClassMethotDemo2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 15495926;
            musteri1.ısım = "Samet";
            musteri1.soyısım = "Ulaşan";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 169559;
            musteri2.ısım = "Efe";
            musteri2.soyısım = "Güroğlu";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 656523;
            musteri3.ısım = "Ahmet";
            musteri3.soyısım = "Kargan";

            Musteri[] musteri = new Musteri[] { musteri1,musteri2, musteri3};

            MusteriManager musteriManagers = new MusteriManager();
            musteriManagers.Add(musteri1);
            musteriManagers.Add(musteri2);
            musteriManagers.Add(musteri3);
            musteriManagers.list(musteri);
            musteriManagers.Del(musteri1);
            musteriManagers.Del(musteri2);
            musteriManagers.Del(musteri3);



        }
    }
}