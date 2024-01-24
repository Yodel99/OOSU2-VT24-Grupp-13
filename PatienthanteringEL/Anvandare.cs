using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringEL
{
    public class Anvandare
    {
        public string InloggID { get; set; }
        public string Losenord { get; set; }
        public VardPersonal VardPersonal { get; set; }
        public Anvandare(string inloggID, string losenord, VardPersonal vardPersonal)
        {
            this.InloggID = inloggID;
            this.Losenord = losenord;
            this.VardPersonal = vardPersonal;
        }
    }
}
