namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Aciklama = "Amasya Elması";
            product1.Fiyati = 15;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Fiyati = 80;
            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati + "TL");
               
                Console.WriteLine("-----------------");
                
            }

            Console.WriteLine("........METOTLAR..........");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut","Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 4);


            //Console.WriteLine("Hello, World!");
        }
    }
}