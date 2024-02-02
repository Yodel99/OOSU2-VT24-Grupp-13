using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDL;
using PatienthanteringEL;

namespace PatienthanteringAL
{
    public class Patienthantering
    {

        private UnitOfWork unitOfWork = new UnitOfWork();

        public IList<Patient> ListaPatienter()
        {

            
            List<Patient> patienter = new List<Patient>();

            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                patienter.Add(patient);
            }
            return patienter;

            
        }
        public IList<VardPersonal> ListaSjukSkotare()
        {
            List<VardPersonal> sjukSkjotare = new List<VardPersonal>();
            foreach (VardPersonal personal in unitOfWork.VardPersonalRepository.Find(m => m.AnstallningsNr != null))
            {
                if (personal.YrkesRoll== "Sjuksköterska")
                {
                    sjukSkjotare.Add(personal);
                }
            }
            return sjukSkjotare;
        }
    }
}
