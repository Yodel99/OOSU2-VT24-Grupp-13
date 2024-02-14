
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringAL;
using PatienthanteringDLef;
using PatienthanteringDLef.DataSeed;

namespace PatienthanteringAL
{
    public class LoggInController
    {      
        public User GetUser(string loggInID, string password)
        {          
            UnitOfWork unitOfWork = new UnitOfWork();
            foreach (User user in unitOfWork.UserRepository.Find(a => a.LogginID.Equals(loggInID)))
            {
                if (password.Equals(user.Password))
                {
                    return user;
                }
            }
            return null;
        }

    }
}
