using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class ManageVisitController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public IList<Patient> GetPatients()
        {
            List<Patient> patienter = new List<Patient>();
            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                patienter.Add(patient);
            }
            return patienter;
        }
        public IList<NursingStaff> ListNursingStaffs()
        {
            List<NursingStaff> nursingStaffs = new List<NursingStaff>();
            foreach (NursingStaff nursingStaff in unitOfWork.NursingStaffRepository.Find(m => m.StaffNr != null))
            {
                if (nursingStaff.Profession == "Sjuksköterska")
                {
                    nursingStaffs.Add(nursingStaff);
                }
            }
            return nursingStaffs;
        }
        public NursingStaff GetDoctor(string staffNr)
        {
            foreach (NursingStaff nursingStaff in unitOfWork.NursingStaffRepository.Find(m => m.StaffNr != null))
            {
                if (nursingStaff.StaffNr == staffNr)
                {
                    return nursingStaff;
                }
            }
            return null;
        }
        public Patient GetPatient(string patientNr)
        {

            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                if (patient.PatientNr == patientNr)
                {
                    return patient;
                }
            }
            return null;
        }
        public void AddVisit(DoctorAppointment visit)
        {
            unitOfWork.DoctorAppointmentRepository.Add(visit);
        }
        public IList<DoctorAppointment> ListVisits()
        {
            List<DoctorAppointment> doctorAppointments = new List<DoctorAppointment>();

            foreach (DoctorAppointment doctorAppointment in unitOfWork.DoctorAppointmentRepository.Find(m => m.VisitNr != null))
            {
                doctorAppointments.Add(doctorAppointment);
            }
            return doctorAppointments;

        }
        public void RemoveAppointment(string besokNr)
        {

            foreach (DoctorAppointment lakarBesok1 in unitOfWork.DoctorAppointmentRepository.Find(m => m.VisitNr != null))
            {
                if (lakarBesok1.VisitNr == besokNr)
                {
                    unitOfWork.DoctorAppointmentRepository.Remove(lakarBesok1);
                    break;
                }

            }

        }
        public DoctorAppointment GetVisit(string visitNr)
        {
            foreach (DoctorAppointment doctorAppointment in unitOfWork.DoctorAppointmentRepository.Find(m => m.PatientNr != null))
            {
                if (doctorAppointment.VisitNr == visitNr)
                {
                    return doctorAppointment;
                }

            }
            return null;
        }
        public void ChangeDate(DoctorAppointment DoctorAppointment)
        {
            RemoveAppointment(DoctorAppointment.VisitNr);
            AddVisit(DoctorAppointment);
        }
    }
}
