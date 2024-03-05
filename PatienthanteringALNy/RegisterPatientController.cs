using PatienthanteringDLNy;
using PatienthanteringELNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringALNy
{
    public class RegisterPatientController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public Patient GetPatient(string patientNr)
        {
            var patient = unitOfWork.PatientRepository.GetSpecificPatient(patientNr);
            
                if (patient != null)
                {
                    return patient;
                }
            

            return null;
        }
        public void RegisterPatient(string personNmr, string fnamn, string enamn, string email, string patientNmr, string adress, string telNmr)
        {            
            Patient patient = new Patient(personNmr, fnamn, enamn, email, patientNmr, adress, telNmr);            
             
            
                unitOfWork.PatientRepository.Add(patient);
                unitOfWork.SaveChanges();
                   
        }
    }

}
