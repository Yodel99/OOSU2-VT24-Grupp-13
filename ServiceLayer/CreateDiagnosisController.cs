using DataLayer;
using EnityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CreateDiagnosisController
    {UnitOfWork unitOfWork = new UnitOfWork();
        public void CreateDiagnosis(Patient selectedpatient, string treatment, string diagnosisDescription)
        {
            var patient = unitOfWork.PatientRepository.GetSpecificPatient(selectedpatient.PatientNr);   
             Diagnosis diagnosis = new Diagnosis(selectedpatient, diagnosisDescription, DateTime.Now, treatment);
             if (patient != null)
                {
                    diagnosis.Patient = patient;
                }
            unitOfWork.DiagnosisRepository.Add(diagnosis);
            unitOfWork.SaveChanges();
            
        }
    }
}
