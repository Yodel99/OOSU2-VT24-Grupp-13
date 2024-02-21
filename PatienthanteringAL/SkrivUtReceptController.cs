using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class SkrivUtReceptController
    {
        public void SkapaRecept(Patient selectedpatient, string lakemedel, string dosering, string anledning)
        {
            using (var db = new PatientMSContext())
            {
                var patient = db.Patients.Find(selectedpatient.PatientNr);

                DrugPrescription drugPrescription = new DrugPrescription(selectedpatient, lakemedel, dosering, DateTime.Now, anledning);
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
