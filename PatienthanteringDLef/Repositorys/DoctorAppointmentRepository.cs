using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class DoctorAppointmentRepository : Repository<DoctorAppointment>
    {       
        public DoctorAppointmentRepository(PatientMSContext context) : base(context) { }      
    }
}