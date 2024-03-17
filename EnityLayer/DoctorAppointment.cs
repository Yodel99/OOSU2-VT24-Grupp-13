using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EnityLayer
{
    public class DoctorAppointment
    {

        [Key]
        public string VisitNr { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public Patient Patient { get; set; }
        public NursingStaff ResponsibleNurse { get; set; }
        public string AppointmentNote { get; set; }
        public string AppointmentStatus { get; set; }
        public string StaffNr => ResponsibleNurse?.StaffNr;
        public string PatientNr => Patient?.PatientNr;
        public string PatientFname => Patient?.FName;
        public string DoctorFname => ResponsibleNurse?.FName;
        public string DoctorEname => ResponsibleNurse?.EName;
        public string PatientEname => Patient?.EName;

        public DoctorAppointment()
        {

        }
        public DoctorAppointment(string visitNr, DateTime date, string reason, Patient patient, NursingStaff responsibleNurse)
        {
            this.VisitNr = visitNr;
            this.Date = date;
            this.Reason = reason;
            this.Patient = patient;
            this.ResponsibleNurse = responsibleNurse;
        }
    }
}
