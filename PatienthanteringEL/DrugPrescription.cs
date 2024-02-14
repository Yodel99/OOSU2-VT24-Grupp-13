using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatienthanteringEL
{
    public class DrugPrescription
    {    
        public  int DrugPrescriptionID { get; set; }
        public Patient Patient { get; set; }
        public string DrugName { get; set; }
        public string Dosage { get; set; }
        public DateTime IssueDate { get; set; }
        public string Reason { get; set; }

        public DrugPrescription()
        {

        }
        public DrugPrescription(Patient patient, string drugName, string dosage, DateTime issueDate, string reason)
        {
            this.Patient = patient;
            this.DrugName = drugName;
            this.Dosage = dosage;
            this.IssueDate = issueDate;
            this.Reason = reason;
        }
    }
}
