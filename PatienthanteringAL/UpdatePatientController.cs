using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDLef;
using PatienthanteringEL;


namespace PatienthanteringAL
{
    public class UpdatePatientController
    {
        public bool UpdatePatientInfo(string chosenPatientNr, string chosenAttribute, string chosenInput)
        {                      
            using (var db = new PatientMSContext())
            {
                var patient = db.Patients.Find(chosenPatientNr);
                {
                    if (patient != null) 
                    {
                        if (chosenAttribute.Equals("personnr"))
                        {
                            patient.SSN = chosenInput;

                        }
                        else if (chosenAttribute.Equals("fnamn"))
                        {
                            patient.FName = chosenInput;
                        }
                        else if (chosenAttribute.Equals("enamn"))
                        {
                            patient.EName = chosenInput;
                        }
                        else if (chosenAttribute.Equals("email"))
                        {
                            patient.Email = chosenInput;
                        }
                        else if (chosenAttribute.Equals("address"))
                        {
                            patient.Address = chosenInput;
                        }
                        else if (chosenAttribute.Equals("telnr"))
                        {
                            patient.TelNr = chosenInput;
                        }
                        else
                        {
                            return false;
                        }
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            

        }

    }
}
