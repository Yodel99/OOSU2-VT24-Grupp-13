using Microsoft.EntityFrameworkCore;
using EnityLayer;
using System.Linq;

namespace DataLayer
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(PatientMSContext context) : base(context) { }
        public User GetUser(string logInID)
        {
            return Context.Set<User>()
                .Include(u => u.NursingStaff)
                .FirstOrDefault(a => a.LoggInID.Equals(logInID));
        }
    }
}