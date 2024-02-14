using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class NursingStaffRepository : Repository<NursingStaff>
    {
        public NursingStaffRepository(PatientMSContext context) : base(context) { }
    }
}