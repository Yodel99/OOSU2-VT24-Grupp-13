using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class VardPersonal: Person
    {
        [Key]
        public string AnstallningsNr { get; set; }
        public string YrkesRoll { get; set; }
        public string Specialisering { get; set; }

        public VardPersonal()
        {

        }
        public VardPersonal(string personNr, string fNamn, string eNamn, string email, string anstallningsNr, string yrkesRoll) : base(personNr, fNamn, eNamn, email)
        {
            this.AnstallningsNr = anstallningsNr;
            this.YrkesRoll = yrkesRoll;
        }

        public VardPersonal(string personNr, string fNamn, string eNamn, string email, string anstallningsNr, string yrkesRoll, string specialisering) : base(personNr, fNamn, eNamn, email)
        {
            this.AnstallningsNr = anstallningsNr;
            this.YrkesRoll = yrkesRoll;
            this.Specialisering = specialisering;
        }
    }
}
