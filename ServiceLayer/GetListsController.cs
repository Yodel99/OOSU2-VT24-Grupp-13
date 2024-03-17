using Microsoft.EntityFrameworkCore;
using DataLayer;
using EnityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    
    public class GetListsController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public IList<Patient> GetPatients()
        {
            return unitOfWork.PatientRepository.GetAllPatients();
        }

        public IList<Diagnosis> GetDiagnosis(Patient selectedpatient)
        {

            
                var diagnos = unitOfWork.DiagnosisRepository.GetAll();
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
        public IList<DrugPrescription> GetPrescriptions(Patient selectedpatient)
        {

            
                var drugPrescriptions = unitOfWork.DrugPrescriptionRepository.GetAll();
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
        public IList<NursingStaff> GetNursingStaffs()
        {



            var staff = unitOfWork.NursingStaffRepository.GetAll();
            List<NursingStaff> doctors = new List<NursingStaff>();
            foreach (var nursingStaff in staff)
            {
                if (nursingStaff.Profession == "Sjuksköterska"||nursingStaff.Profession=="Läkare")
                {
                    doctors.Add(nursingStaff);
                }
            }

                return doctors;
            
        }
        public IList<DoctorAppointment> GetVisits()
        {
            return unitOfWork.DoctorAppointmentRepository.GetAll();
        }
    }
}
