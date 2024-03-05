using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringELNy
{
    public class Diagnosis
    {
        
        public int DiagnosisID { get; set; }
        public string DiagnosisDescription { get; set; }
        public DateTime Date { get; set; }
        public string Treatment { get; set; }       
        public Patient Patient { get; set; }
        

        public Diagnosis()
        {

        }
        public Diagnosis(Patient patient, string diagnosDescription, DateTime date, string treatment)
        {
            this.Patient = patient;
            this.DiagnosisDescription = diagnosDescription;
            this.Date = date;
            this.Treatment = treatment;
        }
    }
}
