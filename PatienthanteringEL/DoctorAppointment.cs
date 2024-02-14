using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class DoctorAppointment
    {

        [Key]
        public string VisitNr { get; set; }
        public DateTime Datum { get; set; }
        public string Syfte { get; set; }
        public Patient Patient { get; set; }
        public NursingStaff AnsvarigLakare { get; set; }
        public string AnstallningsID => AnsvarigLakare?.StaffNr;
        public string PatientNr => Patient?.PatientNr;
        public string PatientFNamn => Patient?.FName;
        public string LakareFnamn => AnsvarigLakare?.FName;

        public DoctorAppointment()
        {

        }
        public DoctorAppointment(string besokNr, DateTime datum, string syfte, Patient patient, NursingStaff ansvarigLäkare)
        {
            this.VisitNr = besokNr;
            this.Datum = datum;
            this.Syfte = syfte;
            this.Patient = patient;
            this.AnsvarigLakare = ansvarigLäkare;
        }
    }
}
