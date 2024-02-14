using PatienthanteringDL;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringAL;

namespace PatienthanteringAL
{
    public class LoggaInKontroller
    {
        //hehehehhheh
        
        public Anvandare GetAnvandare(string inloggID, string losenord)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            foreach (Anvandare anvandare in unitOfWork.AnvandareRepository.Find(a => a.InloggID.Equals(inloggID)))
            {
                if (losenord.Equals(anvandare.Losenord))
                {
                    return anvandare;
                }
            }
            return null;
        }

    }
}
