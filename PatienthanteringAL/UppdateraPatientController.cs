using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDL;
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
                    patient.PersonNr = valdInput;
                }
                else if (valdAttribut.Equals("fnamn"))
                {
                    patient.FNamn = valdInput;
                }
                else if (valdAttribut.Equals("enamn"))
                {
                    patient.ENamn = valdInput;
                }
                else if (valdAttribut.Equals("email"))
                {
                    patient.Email = valdInput;
                }
                else if (valdAttribut.Equals("adress"))
                {
                    patient.Adress = valdInput;
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
