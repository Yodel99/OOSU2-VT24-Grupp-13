using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class CreateDiagnosisController
    {
        public void CreateDiagnosis(Patient selectedpatient, string treatment, string diagnosisDescription)
        {
            using (var db = new PatientMSContext())
            {
                var patient = db.Patients.Find(selectedpatient.PatientNr);
                
                Diagnosis diagnos = new Diagnosis(selectedpatient, diagnosisDescription, DateTime.Now, treatment);
                if (patient != null)
                {
                    diagnos.Patient = patient;
                }
                db.Diagnosis.Add(diagnos);
                db.SaveChanges();
            }
        }
    }
}
