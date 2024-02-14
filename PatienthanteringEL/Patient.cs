using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class Patient: Person
    {
        public Patient()
        {
        }
        [Key]
        public string PatientNr { get; set; }
        public string Adress { get; set; }
        public string TelNr { get; set; }
        public List<Diagnos> Diagnoser { get; set; }

        private Patient()
        {

        }
        public Patient(string personNr, string fNamn, string eNamn, string email, string patientNr, string adress, string telNr) : base(personNr, fNamn, eNamn, email)
        {
            this.PatientNr = patientNr;
            this.Adress = adress;
            this.TelNr = telNr;
            this.Diagnoser = new List<Diagnos>();
        }
       

    }
}
