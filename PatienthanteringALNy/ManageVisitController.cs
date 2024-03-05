using Microsoft.EntityFrameworkCore;
using PatienthanteringDLNy;
using PatienthanteringELNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringALNy
{
    public class ManageVisitController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        
       
        public NursingStaff GetDoctor(string staffNr)
        {
            NursingStaff nursingStaff = unitOfWork.NursingStaffRepository.GetspecificDoctor(staffNr);

                if (nursingStaff != null)
                {
                    return nursingStaff;
                }
            

            return null;
        }
        public Patient GetPatient(string patientNr)
        {
            Patient patient = unitOfWork.PatientRepository.GetSpecificPatient(patientNr);
            

                if (patient != null)
                {
                    return patient;
                }
            

            return null;
        }
    
        public void AddVisit(DoctorAppointment visit)
        {
            
            
            var doctor = unitOfWork.NursingStaffRepository.GetspecificDoctor(visit.StaffNr);
            var patient = unitOfWork.PatientRepository.GetSpecificPatient(visit.PatientNr);
                if (doctor != null)
                {
                    visit.ResponsibleNurse = doctor;
                }
                if (patient != null)
                {
                    visit.Patient = patient;
                }

            unitOfWork.DoctorAppointmentRepository.Add(visit);
            unitOfWork.SaveChanges();
            
        }
        
        public void RemoveAppointment(string besokNr)
        {

            
            unitOfWork.DoctorAppointmentRepository.Remove(GetVisit(besokNr));
            unitOfWork.SaveChanges();
            

        }
        public DoctorAppointment GetVisit(string visitNr)
        {
            {
                DoctorAppointment doctorAppointment = unitOfWork.DoctorAppointmentRepository.GetSpecificVisit(visitNr);

                if (doctorAppointment != null)
                    {
                        return doctorAppointment;
                    }
                

                return null;
            }
        }
        public void ChangeDate(DateTime newDate, DoctorAppointment doctorAppointment)
        {
            DoctorAppointment appointment = GetVisit(doctorAppointment.VisitNr);
            appointment.Date = newDate;
            unitOfWork.SaveChanges();
            
        }
    }
}
