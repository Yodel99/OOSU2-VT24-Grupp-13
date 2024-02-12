using PatienthanteringDL;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class SkapaDiagnosController
    {
        public Diagnos SkapaDiagnos(Patient selectedpatient, string behandling, string diagnosbeskrivning)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Diagnos diagnos = new Diagnos(selectedpatient, diagnosbeskrivning, DateTime.Now, behandling);
            unitOfWork.DiagnosRepository.Add(diagnos);
            return diagnos;

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
    }
}
