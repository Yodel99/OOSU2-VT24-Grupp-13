using Microsoft.EntityFrameworkCore;
using DataLayer;
using EnityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ServiceLayer
{
    public class ManageVisitController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        GetListsController listsController = new GetListsController();
        
       
        public NursingStaff GetDoctor(string staffNr)
        {
            NursingStaff nursingStaff = unitOfWork.NursingStaffRepository.GetSpecificDoctor(staffNr);

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
            var existingNurse = unitOfWork.NursingStaffRepository.GetSpecificDoctor(visit.StaffNr);
            var patient = unitOfWork.PatientRepository.GetSpecificPatient(visit.PatientNr);

            if (existingNurse == null)
            {
                throw new Exception("Could not find doctor with the given staff number.");
            }

            if (patient == null)
            {
                throw new Exception("Could not find patient with the given patient number.");
            }

            visit.ResponsibleNurse = existingNurse;
            visit.Patient = patient;

            unitOfWork.DoctorAppointmentRepository.Add(visit);
            unitOfWork.SaveChanges();
        }
        public IList<DoctorAppointment> GetUserSpecificVisits(User user)
        {
            IList<DoctorAppointment> doctorAppointmentsUser=unitOfWork.DoctorAppointmentRepository.GetAll();
            IList<DoctorAppointment> finalList = new List<DoctorAppointment>();
            foreach (var visit in doctorAppointmentsUser)
            {
                if (visit.ResponsibleNurse.StaffNr==user.NursingStaff.StaffNr)
                {
                    finalList.Add(visit);
                }
            }
            return finalList;
        }

        public string GenerateNewVisitNr()
        {
            IList<DoctorAppointment> doctorAppointments = listsController.GetVisits();

            var maxVisitNr = doctorAppointments
                .Where(appt => appt.VisitNr != null && appt.VisitNr.StartsWith("B-"))
                .Select(appt => int.TryParse(appt.VisitNr.Substring(2), out int num) ? num : 0) 
                .DefaultIfEmpty(1) 
                .Max(); 

            
            return "B-" + (maxVisitNr + 1);
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
            
            var UpdatedoctorAppointment = unitOfWork.DoctorAppointmentRepository.GetSpecificVisit(doctorAppointment.VisitNr);
            {
                UpdatedoctorAppointment.Date = newDate;
            }
            unitOfWork.SaveChanges();
        }

    }
}
