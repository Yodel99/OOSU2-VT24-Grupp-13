using PatienthanteringDL;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    //hejejeje
    public class SkrivUtReceptController
    {
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
