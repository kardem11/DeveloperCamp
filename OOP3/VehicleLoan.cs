using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class VehicleLoan : ICrediManager     //taşıtkredisi
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi ödeme planı hesaplandı");
        }
    }
}
