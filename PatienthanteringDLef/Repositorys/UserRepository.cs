using PatienthanteringEL;
using System.Linq;

namespace PatienthanteringDLef
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(PatientMSContext context) : base(context) { }
        public User GetUser(string logInID)
        {
            return Context.Set<User>().FirstOrDefault(a => a.LoggInID.Equals(logInID));
        }
    }
}