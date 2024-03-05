using DataLayer;
using EnityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class PrescribePrescriptionController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public void PrescripePrescription(Patient selectedpatient, string prescription, string dosage, string reason)
        {
            
                var patient = unitOfWork.PatientRepository.GetSpecificPatient(selectedpatient.PatientNr);

                DrugPrescription drugPrescription = new DrugPrescription(selectedpatient, prescription, dosage, DateTime.Now, reason);
                if (patient != null)
                {
                    drugPrescription.Patient = patient;
                }
                unitOfWork.DrugPrescriptionRepository.Add(drugPrescription);
                unitOfWork.SaveChanges();
            
        }
    }
}
