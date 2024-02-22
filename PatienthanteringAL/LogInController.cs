
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


        public User GetUser(string logInID, string password)
        {
            using (var patientMSContext = new PatientMSContext())
            {               
                User user = patientMSContext.Users.FirstOrDefault(a => a.LoggInID.Equals(logInID));
                
                if (user != null)
                {                    
                    if (password.Equals(user.Password))
                    {
                        return user;
                    }
                }
            }

            return null;
        }

    }
}
