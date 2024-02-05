using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDL;
using PatienthanteringEL;

namespace PatienthanteringAL
{
    public class Patienthantering
    {
        
        public Diagnos SkapaDiagnos(Patient selectedpatient, string behandling, string diagnosbeskrivning)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Diagnos diagnos = new Diagnos(selectedpatient, diagnosbeskrivning, DateTime.Now, behandling);
            unitOfWork.DiagnosRepository.Add(diagnos);
            return diagnos;
           
        }

        public IList<Patient> HamtaPatienter()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            List<Patient> patienter = new List<Patient>();

            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                patienter.Add(patient);
            }
            return patienter;
        }

        public void LaggTillDiagnosTillKund(Patient selectedpatient, Diagnos diagnos)
        {
            
            UnitOfWork unitOfWork = new UnitOfWork();
            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr == selectedpatient.PatientNr))
            {
                patient.Diagnoser.Add(diagnos);
            }
                      
        }

        public IList<Diagnos> HamtaDiagnoser(Patient selectedpatient)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            List<Diagnos> diagnoser = new List<Diagnos>();

            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr == selectedpatient.PatientNr))
            {
                diagnoser = patient.Diagnoser;
            }
            return diagnoser;
        }

        public Lakemedelsrecept SkapaRecept(Patient selectedpatient, string lakemedel, string dosering, string anledning)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Lakemedelsrecept lakemedelsrecept = new Lakemedelsrecept(selectedpatient, lakemedel, dosering, DateTime.Now, anledning);
            unitOfWork.BehandlingRepository.Add(lakemedelsrecept);
            return lakemedelsrecept;
        }

        public IList<Lakemedelsrecept> HamtaRecept(Patient selectedpatient)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            List<Lakemedelsrecept> lakemedelsrecepts = new List<Lakemedelsrecept>();

            foreach (Lakemedelsrecept lakemedelsrecept in unitOfWork.BehandlingRepository.Find(m => m.Patient.PatientNr == selectedpatient.PatientNr))
            {
                lakemedelsrecepts.Add(lakemedelsrecept);
            }
            return lakemedelsrecepts;

        }
    }
}
