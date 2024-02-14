using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class Anvandare
    {
        public Anvandare()
        {
        }
        [Key]
        public string InloggID { get; set; }
        public string Losenord { get; set; }
        public VardPersonal VardPersonal { get; set; }

        public Anvandare()
        {

        }
        public Anvandare(string inloggID, string losenord, VardPersonal vardPersonal)
        {
            this.InloggID = inloggID;
            this.Losenord = losenord;
            this.VardPersonal = vardPersonal;
        }
    }
}
