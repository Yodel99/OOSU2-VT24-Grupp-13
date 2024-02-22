using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class User
    {


        [Key]
        public string LoggInID { get; set; }
        public string Password { get; set; }
        public NursingStaff NursingStaff { get; set; }

        public User()
        {

        }
        public User(string inloggID, string losenord, NursingStaff nursingStaff)
        {
            this.LoggInID = inloggID;
            this.Password = losenord;
            this.NursingStaff = nursingStaff;
        }
    }
}
