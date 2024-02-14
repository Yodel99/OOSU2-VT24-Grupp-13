using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class Person
    {
        public string SSN { get; set; }
        public string FName { get; set; }
        public string EName { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }
        public Person(string ssn, string fName, string eName, string email)
        {
            this.SSN = ssn;
            this.FName = fName;
            this.EName = eName;
            this.Email = email;
        }
    }
}
