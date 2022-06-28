using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Tom Hyder Added.");

        }
        public void List(Customer customer)
        {
            Console.WriteLine("Lisa Sunny Listed.");
        }
        public void Deletion(Customer customer)
        {
            Console.WriteLine("John Snack Deleted.");
        }
    }
}
