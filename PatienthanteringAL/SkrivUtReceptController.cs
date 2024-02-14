using PatienthanteringDLef;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class SkrivUtReceptController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public DrugPrescription SkapaRecept(Patient selectedpatient, string lakemedel, string dosering, string anledning)
        {           
            DrugPrescription lakemedelsrecept = new DrugPrescription(selectedpatient, lakemedel, dosering, DateTime.Now, anledning);
            unitOfWork.DrugPrescriptionRepository.Add(lakemedelsrecept);
            return lakemedelsrecept;
        }

        public IList<DrugPrescription> HamtaRecept(Patient selectedpatient)
        {
            List<DrugPrescription> lakemedelsrecepts = new List<DrugPrescription>();

            foreach (DrugPrescription lakemedelsrecept in unitOfWork.DrugPrescriptionRepository.Find(m => m.Patient.PatientNr == selectedpatient.PatientNr))
            {
                lakemedelsrecepts.Add(lakemedelsrecept);
            }
            return lakemedelsrecepts;

        }
    }
}
