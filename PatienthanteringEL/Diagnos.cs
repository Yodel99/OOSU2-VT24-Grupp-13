using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class Diagnos
    {
        
        public int DiagnosID { get; set; }

        public Patient Patient { get; set; }
        public string DiagnosDescription { get; set; }
        public DateTime Date { get; set; }
        public string Treatment { get; set; }

        public Diagnos()
        {

        }
        public Diagnos(Patient patient, string diagnosDescription, DateTime date, string treatment)
        {
            this.Patient = patient;
            this.DiagnosDescription = diagnosDescription;
            this.Date = date;
            this.Treatment = treatment;
        }
    }
}
