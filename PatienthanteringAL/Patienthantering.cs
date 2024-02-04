using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDL;
using PatienthanteringEL;

namespace PatienthanteringAL
{
    public class Patienthantering
    {
        public Patienthantering() { }

        public IList<Patient> HamtaPatienter()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            List<Patient> patienter = new List<Patient>();   
            
            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                    patienter.Add(patient);
            }
            return patienter;                                      
        }

        public void UppdateraPatientInfo(string valdPatientID, string valdAttribut, string valdInput)
        {
            UnitOfWork unitOfWork = new UnitOfWork();

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
            }
        }
    }
}
