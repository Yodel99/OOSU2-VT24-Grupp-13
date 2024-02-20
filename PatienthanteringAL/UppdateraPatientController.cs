using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDLef;
using PatienthanteringEL;


namespace PatienthanteringAL
{
    public class UppdateraPatientController
    {
        public bool UppdateraPatientInfo(string chosenPatientNr, string chosenAttribute, string chosenInput)
        {            
            PatientMSContext patientMSContext = new PatientMSContext();

            bool check = false;

            Patient foundPatient = patientMSContext.Patients.FirstOrDefault(a => a.PatientNr.Equals(chosenPatientNr));
            {
                
                if (chosenAttribute.Equals("personnr"))
                {
                    foundPatient.SSN = chosenInput;
                }
                else if (chosenAttribute.Equals("fnamn"))
                {
                    foundPatient.FName = chosenInput;
                }
                else if (chosenAttribute.Equals("enamn"))
                {
                    foundPatient.EName = chosenInput;
                }
                else if (chosenAttribute.Equals("email"))
                {
                    foundPatient.Email = chosenInput;
                }
                else if (chosenAttribute.Equals("adress"))
                {
                    foundPatient.Address = chosenInput;
                }
                else if (chosenAttribute.Equals("telnr"))
                {
                    foundPatient.TelNr = chosenInput;
                }
                else
                {
                    check = false;
                }
                return check;
            }           
        }
    }
}
