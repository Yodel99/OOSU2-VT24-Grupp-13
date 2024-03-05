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
                    if (chosenAttribute.Equals("personnr"))
                    {
                        patient.SSN = chosenInput;

                    }
                    else if (chosenAttribute.Equals("fnamn"))
                    {
                        patient.FName = chosenInput;
                    }
                    else if (chosenAttribute.Equals("enamn"))
                    {
                        patient.EName = chosenInput;
                    }
                    else if (chosenAttribute.Equals("email"))
                    {
                        patient.Email = chosenInput;
                    }
                    else if (chosenAttribute.Equals("address"))
                    {
                        patient.Address = chosenInput;
                    }
                    else if (chosenAttribute.Equals("telnr"))
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
