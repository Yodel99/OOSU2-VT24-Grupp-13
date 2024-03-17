using Microsoft.EntityFrameworkCore;
using EnityLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class NursingStaffRepository : Repository<NursingStaff>
    {
        public NursingStaffRepository(PatientMSContext context) : base(context) { }
        public NursingStaff GetSpecificDoctor(string staffNr)
        {
            return Context.Set<NursingStaff>().SingleOrDefault(a => a.StaffNr.Equals(staffNr));
           
        }
        public IList<NursingStaff> GetAll()
        {
            return Context.Set<NursingStaff>().ToList();
  
        }
    }
}