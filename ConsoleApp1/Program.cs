namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılım geliştirme kampı", "java", "programlamaya giriş"};

            // for (int i = 0; i <kurslar.Length; i++)
            // {
            //    Console.WriteLine(kurslar[i]);
            // }
            //Console.WriteLine("For bitti");
            //Console.WriteLine("SAYFA SONU");
            //Console.ReadLine();

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
                Console.ReadLine();
            }
        }
    }
}