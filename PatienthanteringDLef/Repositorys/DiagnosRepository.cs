using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class DiagnosRepository : Repository<Diagnosis>
    {
        public DiagnosRepository(PatientMSContext context) : base(context) { }
    }
}