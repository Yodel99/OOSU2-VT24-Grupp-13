using Microsoft.EntityFrameworkCore;
using DataLayer;
using EnityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ValidationController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public bool AccessCheckNurse(User activeUser)
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
        public bool AccessCheckDoctor(User activeUser)
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
        private NursingStaff GetNursingstaff(User activeUser)
        {


            User user = unitOfWork.UserRepository.GetUser(activeUser.LoggInID);

            if (user != null && user.NursingStaff != null)
            {
                return user.NursingStaff;
            }
            else
            {

                return null;
            }

        }
    }
}
