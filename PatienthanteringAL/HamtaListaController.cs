using Microsoft.EntityFrameworkCore;
using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class HamtaListaController
    {
        public IList<Patient> HamtaPatienter()
        {           
            using (PatientMSContext db = new PatientMSContext())
            {
                var patientList = db.Patients.ToList();
                List<Patient> patienter = new List<Patient>();
                foreach (Patient patient1 in patientList)
                {
                    patienter.Add(patient1);
                }
                return patienter;
            }
        }

        public IList<Diagnos> HamtaDiagnoser(Patient selectedpatient)
        {

            using (PatientMSContext db = new PatientMSContext())
            {
                var diagnos = db.Diagnosis.Include(p => p.Patient).ToList();
                List<Diagnos> patientdiagnosis = new List<Diagnos>();
                foreach (Diagnos diagnos1 in diagnos)
                {
                    if (diagnos1.Patient.PatientNr == selectedpatient.PatientNr)
                    {
                        patientdiagnosis.Add(diagnos1);
                    }
                }
                return patientdiagnosis;
            }

        }
        public IList<DrugPrescription> HamtaRecept(Patient selectedpatient)
        {

            using (PatientMSContext db = new PatientMSContext())
            {
                var drugPrescriptions = db.DrugPrescriptions.Include(p => p.Patient).ToList();
                List<DrugPrescription> patientprescriptions = new List<DrugPrescription>();
                foreach (DrugPrescription drugPrescription in drugPrescriptions)
                {
                    if (drugPrescription.Patient.PatientNr == selectedpatient.PatientNr)
                    {
                        patientprescriptions.Add(drugPrescription);
                    }
                }
                return patientprescriptions;
            }

        }
    }
}
