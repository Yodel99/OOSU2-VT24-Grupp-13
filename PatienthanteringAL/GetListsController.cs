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
    public class GetListsController
    {
        public IList<Patient> GetPatients()
        {           
            using (PatientMSContext db = new PatientMSContext())
            {
                return  db.Patients.ToList();
            }
        }

        public IList<Diagnosis> GetDiagnosis(Patient selectedpatient)
        {

            using (PatientMSContext db = new PatientMSContext())
            {
                var diagnos = db.Diagnosis.Include(p => p.Patient).ToList();
                List<Diagnosis> patientdiagnosis = new List<Diagnosis>();
                foreach (Diagnosis diagnos1 in diagnos)
                {
                    if (diagnos1.Patient.PatientNr == selectedpatient.PatientNr)
                    {
                        patientdiagnosis.Add(diagnos1);
                    }
                }
                return patientdiagnosis;
            }

        }
        public IList<DrugPrescription> GetPrescriptions(Patient selectedpatient)
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
        public IList<NursingStaff> GetNursingStaffs()
        {

            using (PatientMSContext db = new PatientMSContext())
            {
                var staff = db.NursingStaffs;
                List<NursingStaff> doctors = new List<NursingStaff>();
                foreach (var nursingStaff in staff)
                {
                    if (nursingStaff.Profession == "Sjuksköterska")
                    {
                        doctors.Add(nursingStaff);
                    }
                }

                return doctors;
            }
        }
        public IList<DoctorAppointment> GetVisits()
        {
            using (PatientMSContext db = new PatientMSContext())
            {
                var appointments = db.DoctorAppointments
                                     .Include(p => p.Patient)
                                     .Include(d => d.ResponsibleNurse)
                                     .ToList();

                return appointments;
            }

        }
    }
}
