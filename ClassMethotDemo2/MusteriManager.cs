using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo2
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Hoşgeldiniz Sayın: " + musteri.ısım);
        }
        public void list(Musteri[] musteri)
        {
            Console.WriteLine("Listemleme Başarılı ");
            foreach (Musteri x in musteri)
            {
                Console.WriteLine(x.ID);
            }
        }   
        public void Del(Musteri musteri)
        {
            Console.WriteLine("Silme İŞlemi Başarılı " + musteri.ısım);
        }
        
	
    }
}
