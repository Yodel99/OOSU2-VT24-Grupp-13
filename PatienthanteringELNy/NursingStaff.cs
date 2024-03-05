using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringELNy
{
    public class NursingStaff: Person
    {

        [Key]
        public string StaffNr { get; set; }
        public string Profession { get; set; }
        public string Specialization { get; set; }

        public NursingStaff()
        {

        }
        public NursingStaff(string ssn, string fName, string eName, string email, string staffNr, string specialization) : base(ssn, fName, eName, email)
        {
            this.StaffNr = staffNr;
            this.Profession = specialization;
        }

        public NursingStaff(string ssn, string fName, string eName, string email, string staffNr, string profession, string specialization) : base(ssn, fName, eName, email)
        {
            this.StaffNr = staffNr;
            this.Profession = profession;
            this.Specialization = specialization;
        }
    }
}
