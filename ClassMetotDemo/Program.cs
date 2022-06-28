namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 025;
            customer.Name = "Tom";
            customer.Lastname = "Hyder";
            customer.City = "NewYork";
            Customer customer2 = new Customer();
            customer.Id = 026;
            customer.Name = "Lisa";
            customer.Lastname = "Sunny";
            customer.City = "California";
            Customer customer3 = new Customer();
            customer.Id = 027;
            customer.Name = "John";
            customer.Lastname = "Snack";
            customer.City = "NewJersey";

            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.List(customer2);
            customerManager.Deletion(customer3);

            
          
        }
        
        
    }
}