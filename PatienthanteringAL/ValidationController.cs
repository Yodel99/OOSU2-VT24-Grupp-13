using Microsoft.EntityFrameworkCore;
using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class ValidationController
    {

        public bool AccessCheckNurse(User activeUser)
        {

            using (var patientMSContext = new PatientMSContext())
            {
                NursingStaff nursingStaff = GetNursingstaff(activeUser);

                if (nursingStaff.Profession == "Sjuksköterska"|| nursingStaff.Profession=="Läkare")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool AccessCheckDoctor(User activeUser)
        {
            using (var patientMSContext = new PatientMSContext())
            {
                NursingStaff nursingStaff = GetNursingstaff(activeUser);

                if (nursingStaff.Profession == "Läkare")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    
        private NursingStaff GetNursingstaff(User activeUser)
        {
            using (var patientMSContext = new PatientMSContext())
            {
                User user = patientMSContext.Users
                    .Include(a => a.NursingStaff)
                    .SingleOrDefault(a => a.LogginID.Equals(activeUser.LogginID));

                if (user.NursingStaff != null)
                {
                    return user.NursingStaff;
                }
            }

            return null;
        }
    }
}
