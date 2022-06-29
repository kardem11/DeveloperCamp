using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService)
        {
            
            crediManager.Calculate();
            loggerService.Log();
        }
        public void KrediOnbilgilendirmesiYap(List<ICrediManager> credis)
        {
            foreach(var credi in credis)
            {
                credi.Calculate();
            }
        }
    }
}
