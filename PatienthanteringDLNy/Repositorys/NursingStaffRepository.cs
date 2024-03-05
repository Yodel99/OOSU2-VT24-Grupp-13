using Microsoft.EntityFrameworkCore;
using PatienthanteringELNy;
using System.Collections.Generic;
using System.Linq;

namespace PatienthanteringDLNy
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