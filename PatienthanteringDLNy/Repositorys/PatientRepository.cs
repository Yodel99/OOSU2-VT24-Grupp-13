using PatienthanteringELNy;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PatienthanteringDLNy
{
    public class PatientRepository : Repository<Patient>
    {
        public PatientRepository(PatientMSContext context) : base(context) { }
        public Patient GetSpecificPatient(string patientNr)
        {
            return Context.Set<Patient>().SingleOrDefault(a => a.PatientNr.Equals(patientNr));
        }
        public List<Patient> GetAllPatients()
        { 
            return Context.Set<Patient>().ToList();

        }

    }
}