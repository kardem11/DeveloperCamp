using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICrediManager consumerLoan = new ConsumerLoan();
            ICrediManager vehicleLoan = new VehicleLoan();    
            ICrediManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerServices();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(housingLoanManager, new DatabaseLoggerServices());

            List<ICrediManager> credis = new List<ICrediManager>() {consumerLoan, vehicleLoan };
           // basvuruManager.KrediOnbilgilendirmesiYap(credis);
 
        }
    }
}