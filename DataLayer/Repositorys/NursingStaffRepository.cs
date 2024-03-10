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
            //var nursingStaff = Context.Set<NursingStaff>()
            //    .Where(ns => ns.StaffNr == staffNr)
            //    .Select(ns => new NursingStaff
            //    {
            //        FName = ns.FName,
            //        EName = ns.EName,
            //        Email = ns.Email,
            //        SSN = ns.SSN,
            //        StaffNr = ns.StaffNr,
            //        Profession = ns.Profession,
            //        Specialization = ns.Specialization != null ? ns.Specialization : "Not Specified"
            //    })
            //    .FirstOrDefault(); // Lägg till FirstOrDefault() för att få det första matchande objektet eller null om det inte finns något matchande

            //return nursingStaff;
        }
        public Patient GetSpecificPatient(string patientNr)
        {
            return Context.Set<Patient>().SingleOrDefault(a => a.PatientNr.Equals(patientNr));
        }

        public IList<NursingStaff> GetAll()
        {
            return Context.Set<NursingStaff>().ToList();
            //var nursingStaffList = Context.Set<NursingStaff>()
            //            .Select(ns => new NursingStaff
            //            {
            //                FName = ns.FName,
            //                EName = ns.EName,
            //                Email = ns.Email,
            //                SSN = ns.SSN,
            //                StaffNr = ns.StaffNr,
            //                Profession = ns.Profession,
            //                Specialization = ns.Specialization != null ? ns.Specialization : "Not Specified",

            //            })
            //            .ToList();

            //return nursingStaffList;
        }
    }
}