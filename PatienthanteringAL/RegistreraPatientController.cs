using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class RegistreraPatientController
    {
        public void RegistreraPatient(string personNmr, string fnamn, string enamn, string email, string patientNmr, string adress, string telNmr)
        {            
            Patient patient = new Patient(personNmr, fnamn, enamn, email, patientNmr, adress, telNmr);            
            using (var db = new PatientMSContext()) 
            {
                db.Patients.Add(patient);
                db.SaveChanges();
            }       
        }
    }
}
