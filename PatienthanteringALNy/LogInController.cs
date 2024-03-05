
using PatienthanteringELNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringALNy;
using PatienthanteringDLNy;
using PatienthanteringDLNy.DataSeed;

namespace PatienthanteringALNy
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
