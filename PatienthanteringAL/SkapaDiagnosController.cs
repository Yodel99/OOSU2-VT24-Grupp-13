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
    public class SkapaDiagnosController
    {
        public void SkapaDiagnos(Patient selectedpatient, string behandling, string diagnosbeskrivning)
        {
            using (var db = new PatientMSContext())
            {
                var patient = db.Patients.Find(selectedpatient.PatientNr);
                
                Diagnos diagnos = new Diagnos(selectedpatient, diagnosbeskrivning, DateTime.Now, behandling);
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
