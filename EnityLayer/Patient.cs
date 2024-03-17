using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EnityLayer
{
    public class Patient: Person
    {

        [Key]
        public string PatientNr { get; set; }
        public string Address { get; set; }
        public string TelNr { get; set; }
        

        public Patient()
        {

        }
        public Patient(string personNr, string fName, string eName, string email, string patientNr, string address, string telNr) : base(personNr, fName, eName, email)
        {
            this.PatientNr = patientNr;
            this.Address = address;
            this.TelNr = telNr;
        }
       

    }
}
