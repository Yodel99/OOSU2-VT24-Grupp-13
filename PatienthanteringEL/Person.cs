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
        public Person()
        {
        }
        public string PersonNr { get; set; }
        public string FNamn { get; set; }
        public string ENamn { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }
        public Person(string personNr, string fNamn, string eNamn, string email)
        {
            this.PersonNr = personNr;
            this.FNamn = fNamn;
            this.ENamn = eNamn;
            this.Email = email;
        }
    }
}
