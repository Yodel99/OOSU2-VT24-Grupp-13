using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class DrugPrescriptionRepository : Repository<DrugPrescription>
    {
        public DrugPrescriptionRepository(PatientMSContext context) : base(context) { }
    }
}