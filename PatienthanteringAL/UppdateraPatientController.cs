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
        public bool UppdateraPatientInfo(string valdPatientID, string valdAttribut, string valdInput)
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            bool check = false;

            foreach (Patient patient in unitOfWork.PatientRepository.Find(p => p.PatientNr.ToLower().Equals(valdPatientID)))
            {
                
                if (valdAttribut.Equals("personnr"))
                {
                    patient.SSN = valdInput;
                }
                else if (valdAttribut.Equals("fnamn"))
                {
                    patient.FName = valdInput;
                }
                else if (valdAttribut.Equals("enamn"))
                {
                    patient.EName = valdInput;
                }
                else if (valdAttribut.Equals("email"))
                {
                    patient.Email = valdInput;
                }
                else if (valdAttribut.Equals("adress"))
                {
                    patient.Address = valdInput;
                }
                else if (valdAttribut.Equals("telnr"))
                {
                    patient.TelNr = valdInput;
                }
                else
                {
                    check = false;
                    break;
                }
                return check;
            }
            return check;
        }
    }
}
