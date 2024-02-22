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
                var doctor = db.NursingStaffs.Find(visit.StaffNr);
                var patient = db.Patients.Find(visit.PatientNr);
                if (doctor != null)
                {
                    visit.ResponsibleNurse = doctor;
                }
                if (patient != null)
                {
                    visit.Patient = patient;
                }

                db.DoctorAppointments.Add(visit);
                db.SaveChanges();
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
                        .Include(a => a.ResponsibleNurse)
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
                appointment.Date = newDate;
                db.SaveChanges();
            }
            ;
        }
    }
}
