using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringEL
{
    public class Diagnos
    {
        public Diagnos()
        {
        }
        public int DiagnosID { get; set; }
        public Patient Patient { get; set; }
        public string Diagnosbeskrivning { get; set; }
        public DateTime Datum { get; set; }
        public string Behandling { get; set; }

        public Diagnos(Patient patient, string diagnosbeskrivning, DateTime datum, string behandling)
        {
            this.Patient = patient;
            this.Diagnosbeskrivning = diagnosbeskrivning;
            this.Datum = datum;
            this.Behandling = behandling;
        }
    }
}
