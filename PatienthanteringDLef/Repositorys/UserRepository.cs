using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(PatientMSContext context) : base(context) { }
    }
}