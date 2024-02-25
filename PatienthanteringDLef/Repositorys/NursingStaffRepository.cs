using Microsoft.EntityFrameworkCore;
using PatienthanteringEL;
using System.Collections.Generic;
using System.Linq;

namespace PatienthanteringDLef
{
    public class NursingStaffRepository : Repository<NursingStaff>
    {
        public NursingStaffRepository(PatientMSContext context) : base(context) { }
        public NursingStaff GetspecificDoctor(string staffNr)
        {
            return Context.Set<NursingStaff>().SingleOrDefault(a => a.StaffNr.Equals(staffNr));
        }
        public List<NursingStaff> GetAll()
        {
            return Context.Set<NursingStaff>().ToList();
        }
    }
}