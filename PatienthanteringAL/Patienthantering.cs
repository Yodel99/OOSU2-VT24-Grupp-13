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

        public void RegistreraPatient(string personNmr, string fnamn,string enamn,string email, string patientNmr, string adress, string telNmr )
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Patient patient = new Patient(personNmr, fnamn, enamn, email, patientNmr, adress, telNmr);
            unitOfWork.PatientRepository.Add(patient);
        }
    }
}
