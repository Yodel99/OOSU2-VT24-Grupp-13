using Microsoft.EntityFrameworkCore;
using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class ManageVisitController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public IList<Patient> GetPatients()
        {
            using (PatientMSContext db = new PatientMSContext())
            {
                return db.Patients.ToList();
            }
        }
        public IList<NursingStaff> ListNursingStaffs()
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
        public NursingStaff GetDoctor(string staffNr)
        {
            using (var patientMSContext = new PatientMSContext())
            {
                NursingStaff nursingStaff = patientMSContext.NursingStaffs.FirstOrDefault(a => a.StaffNr.Equals(staffNr));

                if (nursingStaff != null)
                {
                    return nursingStaff;
                }
            }

            return null;
        }
        public Patient GetPatient(string patientNr)
        {

            using (var patientMSContext = new PatientMSContext())
            {
                Patient patient = patientMSContext.Patients.FirstOrDefault(a => a.PatientNr.Equals(patientNr));

                if (patient != null)
                {
                    return patient;
                }
            }

            return null;
        }
    
        public void AddVisit(DoctorAppointment visit)
        {
            using (var db = new PatientMSContext())
            {
                var doctor = db.NursingStaffs.Find(visit.AnstallningsID);
                var patient = db.Patients.Find(visit.PatientNr);
                if (doctor != null)
                {
                    visit.AnsvarigLakare = doctor;
                }
                if (patient != null)
                {
                    visit.Patient = patient;
                }

                db.DoctorAppointments.Add(visit);
                db.SaveChanges();
            }
        }
        public IList<DoctorAppointment> ListVisits()
        {
            using (PatientMSContext db = new PatientMSContext())
            {
                var appointments = db.DoctorAppointments
                                     .Include(p => p.Patient)
                                     .Include(d => d.AnsvarigLakare)
                                     .ToList();

                return appointments;
            }

        }
        public void RemoveAppointment(string besokNr)
        {

            using (var db = new PatientMSContext())
            {
                var appointment = db.DoctorAppointments.Find(besokNr);
                
                db.DoctorAppointments.Remove(appointment);
                db.SaveChanges();
            }
            

        }
        public DoctorAppointment GetVisit(string visitNr)
        {
            {
                using (var patientMSContext = new PatientMSContext())
                {
                    DoctorAppointment doctorAppointment = patientMSContext.DoctorAppointments
                        .Include(a => a.Patient)
                        .Include(a => a.AnsvarigLakare)
                        .SingleOrDefault(a => a.VisitNr.Equals(visitNr));

                    if (doctorAppointment != null)
                    {
                        return doctorAppointment;
                    }
                }

                return null;
            }
        }
        public void ChangeDate(DateTime newDate, DoctorAppointment doctorAppointment)
        {
            using (var db = new PatientMSContext())
            {
                var appointment = db.DoctorAppointments.SingleOrDefault(a => a.VisitNr == doctorAppointment.VisitNr);
                appointment.Datum = newDate;
                db.SaveChanges();
            }
            ;
        }
    }
}
