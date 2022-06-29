namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.CustomerNumber = "12345";
            customer1.Name = "Murat";
            customer1.Lastname = "Altıkulaç";
            customer1.TcNo = "12345678910";

            //kodlama.io
            
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.Taxnumber = "12345647890";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            
        }
    }
}