using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class PatientRepository : Repository<Patient>
    {
        public PatientRepository(PatientMSContext context) : base(context) { }
    }
}