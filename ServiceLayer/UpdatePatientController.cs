using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EnityLayer;


namespace ServiceLayer
{
    public class UpdatePatientController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public bool UpdatePatientInfo(string chosenPatientNr, string chosenAttribute, string chosenInput)
        {                      
            
            
            var patient = unitOfWork.PatientRepository.GetSpecificPatient(chosenPatientNr);
            {
                if (patient != null) 
                {
                    if (chosenAttribute.Equals("Firstname"))
                    {
                        patient.FName = chosenInput;
                    }
                    else if (chosenAttribute.Equals("Lastname"))
                    {
                        patient.EName = chosenInput;
                    }
                    else if (chosenAttribute.Equals("Email"))
                    {
                        patient.Email = chosenInput;
                    }
                    else if (chosenAttribute.Equals("Address"))
                    {
                        patient.Address = chosenInput;
                    }
                    else if (chosenAttribute.Equals("Telephone"))
                    {
                        patient.TelNr = chosenInput;
                    }
                    else
                    {
                        return false;
                    }
                        unitOfWork.SaveChanges();
                        return true;
                }
                else
                {
                    return false;
                }
                
                
            }
            

        }

    }
}
