using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class DiagnosRepository : Repository<Diagnos>
    {
        public DiagnosRepository(PatientMSContext context) : base(context) { }
    }
}