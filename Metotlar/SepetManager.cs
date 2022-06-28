using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler..Sepete Eklendi : " + product.Adi);
        }

        public void Ekle2(string productAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler.. Sepete Eklendi : "+ productAdi);
        }
       
    }
}
