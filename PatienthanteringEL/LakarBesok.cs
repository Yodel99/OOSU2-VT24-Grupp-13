using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class LakarBesok
    {
        public LakarBesok()
        {
        }
        [Key]
        public string BesokNr { get; set; }
        public DateTime Datum { get; set; }
        public string Syfte { get; set; }
        public Patient Patient { get; set; }
        public VardPersonal AnsvarigLakare { get; set; }
        public string AnstallningsID => AnsvarigLakare?.AnstallningsNr;
        public string PatientNr => Patient?.PatientNr;
        public string PatientFNamn => Patient?.FNamn;
        public string LakareFnamn => AnsvarigLakare?.FNamn;

        public LakarBesok()
        {

        }
        public LakarBesok(string besokNr, DateTime datum, string syfte, Patient patient, VardPersonal ansvarigLäkare)
        {
            this.BesokNr = besokNr;
            this.Datum = datum;
            this.Syfte = syfte;
            this.Patient = patient;
            this.AnsvarigLakare = ansvarigLäkare;
        }
    }
}
