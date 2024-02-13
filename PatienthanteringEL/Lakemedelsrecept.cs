using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringEL
{
    public class Lakemedelsrecept
    {
        private Lakemedelsrecept()
        {
        }
        public  int LakemedelsreceptId { get; set; }
        public Patient Patient { get; set; }
        public string LakemedelsNamn { get; set; }
        public string Dosering { get; set; }
        public DateTime Utskrivningsdatum { get; set; }
        public string Anledning { get; set; }

        public Lakemedelsrecept(Patient patient, string lakemedelsNamn, string dosering, DateTime utskrivningsdatum, string anledning)
        {
            this.Patient = patient;
            this.LakemedelsNamn = lakemedelsNamn;
            this.Dosering = dosering;
            this.Utskrivningsdatum = utskrivningsdatum;
            this.Anledning = anledning;
        }
    }
}
