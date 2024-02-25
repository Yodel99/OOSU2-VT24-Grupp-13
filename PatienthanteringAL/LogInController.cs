
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
    public class LogInController
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public User GetUser(string logInID, string password)
        {
            
                         
                User user = unitOfWork.UserRepository.GetUser(logInID);
                if (user != null)
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
