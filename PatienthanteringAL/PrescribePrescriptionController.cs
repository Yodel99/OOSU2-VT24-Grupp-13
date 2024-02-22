using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class PrescribePrescriptionController
    {
        public void PrescripePrescription(Patient selectedpatient, string prescription, string dosage, string reason)
        {
            using (var db = new PatientMSContext())
            {
                var patient = db.Patients.Find(selectedpatient.PatientNr);

                DrugPrescription drugPrescription = new DrugPrescription(selectedpatient, prescription, dosage, DateTime.Now, reason);
                if (patient != null)
                {
                    drugPrescription.Patient = patient;
                }
                db.DrugPrescriptions.Add(drugPrescription);
                db.SaveChanges();
            }
        }
    }
}
