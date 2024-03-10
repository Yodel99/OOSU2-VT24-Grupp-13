using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using EnityLayer;

namespace DataLayer
{
    public class DoctorAppointmentRepository : Repository<DoctorAppointment>
    {
        public DoctorAppointmentRepository(PatientMSContext context) : base(context) { }

        public DoctorAppointment GetSpecificVisit(string visitNr)
        {
            return Context.Set<DoctorAppointment>()
                .Include(p=>p.Patient)
                .Include(n=>n.ResponsibleNurse)
                .SingleOrDefault(a => a.VisitNr.Equals(visitNr));
            //var doctorAppointments = Context.Set<DoctorAppointment>()
            //                .Include(appointment => appointment.Patient)
            //                .Include(appointment => appointment.ResponsibleNurse)
            //                .Select(appointment => new DoctorAppointment
            //                {
            //                    VisitNr = appointment.VisitNr,
            //                    Date = appointment.Date,
            //                    Reason = appointment.Reason,

            //                    Patient = new Patient
            //                    {
            //                        PatientNr = appointment.Patient.PatientNr,
            //                        FName = appointment.Patient.FName,
            //                        EName = appointment.Patient.EName,
            //                        Email = appointment.Patient.Email,
            //                        SSN = appointment.Patient.SSN,
            //                        Address = appointment.Patient.Address,
            //                        TelNr = appointment.Patient.TelNr
            //                    },

            //                    ResponsibleNurse = new NursingStaff
            //                    {
            //                        SSN = appointment.ResponsibleNurse.SSN,
            //                        FName = appointment.ResponsibleNurse.FName,
            //                        EName = appointment.ResponsibleNurse.EName,
            //                        Email = appointment.ResponsibleNurse.Email,
            //                        Profession = appointment.ResponsibleNurse.Profession,
            //                        StaffNr = appointment.ResponsibleNurse.StaffNr,
            //                        Specialization = appointment.ResponsibleNurse.Specialization ?? "not specified"
            //                    }
            //                }).FirstOrDefault(appointment => appointment.VisitNr == visitNr);
            //return doctorAppointments;
        }
        

            public List<DoctorAppointment> GetAll()
            {
            return Context.Set<DoctorAppointment>()
                .Include(p=>p.Patient)
                .Include(n=>n.ResponsibleNurse)
                .ToList();
            //var doctorAppointments = Context.Set<DoctorAppointment>()
            //                .Include(appointment => appointment.Patient)
            //                .Include(appointment => appointment.ResponsibleNurse)
            //                .Select(appointment => new DoctorAppointment
            //                {
            //                    VisitNr = appointment.VisitNr,
            //                    Date = appointment.Date,
            //                    Reason = appointment.Reason,

            //                    Patient = new Patient
            //                    {
            //                        PatientNr = appointment.Patient.PatientNr,
            //                        FName = appointment.Patient.FName,
            //                        EName = appointment.Patient.EName,
            //                        Email = appointment.Patient.Email,
            //                        SSN = appointment.Patient.SSN,
            //                        Address = appointment.Patient.Address,
            //                        TelNr = appointment.Patient.TelNr
            //                    },

            //                    ResponsibleNurse = new NursingStaff
            //                    {
            //                        SSN = appointment.ResponsibleNurse.SSN,
            //                        FName = appointment.ResponsibleNurse.FName,
            //                        EName = appointment.ResponsibleNurse.EName,
            //                        Email = appointment.ResponsibleNurse.Email,
            //                        Profession = appointment.ResponsibleNurse.Profession,
            //                        StaffNr = appointment.ResponsibleNurse.StaffNr,
            //                        Specialization = appointment.ResponsibleNurse.Specialization ?? "not specified"
            //                    }
            //                })
            //                .ToList();


            //return doctorAppointments;
            }

            //    var appointments = Context.Set<DoctorAppointment>()
            //                              .Include(appointment => appointment.Patient)
            //                              .Include(appointment => appointment.ResponsibleNurse)
            //                              .Select(appointment => new DoctorAppointment
            //                              {
            //                                // Kopiera alla egenskaper
            //// Ersätt Specialization med "not specified" om det är null
            //                              ResponsibleNurse = new NursingStaff
            //                              {
            //                                  SSN = appointment.ResponsibleNurse.SSN,
            //                                  FName=appointment.ResponsibleNurse.FName,
            //                                  EName=appointment.ResponsibleNurse.EName,
            //                                  Email=appointment.ResponsibleNurse.Email,
            //                                  Profession=appointment.ResponsibleNurse.Profession,
            //                                  StaffNr=appointment.ResponsibleNurse.StaffNr,
            //                                  Specialization = appointment.ResponsibleNurse.Specialization ?? "not specified"
            //                              },
            //// Andra kopierade egenskaper
            //// ...
            //                              })
            //                              .ToList();

            //                                return appointments;
        
    }
}