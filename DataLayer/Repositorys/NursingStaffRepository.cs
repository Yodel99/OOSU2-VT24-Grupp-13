using Microsoft.EntityFrameworkCore;
using EnityLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class NursingStaffRepository : Repository<NursingStaff>
    {
        public NursingStaffRepository(PatientMSContext context) : base(context) { }
        public NursingStaff GetspecificDoctor(string staffNr)
        {
            return Context.Set<NursingStaff>().SingleOrDefault(a => a.StaffNr.Equals(staffNr));
        }
        public IList<NursingStaff> GetAll()
        {
            var nursingStaffList = Context.Set<NursingStaff>()
                        .Select(ns => new NursingStaff
                        {
                            FName = ns.FName,
                            EName = ns.EName,
                            Email = ns.Email,
                            SSN = ns.SSN,
                            StaffNr = ns.StaffNr,
                            Profession = ns.Profession,
                            Specialization = ns.Specialization != null ? ns.Specialization : "Not Specified",

                        })
                        .ToList();

            return nursingStaffList;
        }
    }
}