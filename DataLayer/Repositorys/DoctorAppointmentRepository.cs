using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using EnityLayer;

namespace DataLayer
{
    public class DoctorAppointmentRepository : Repository<DoctorAppointment>
    {
        public DoctorAppointmentRepository(PatientMSContext context) : base(context) { }

        public DoctorAppointment GetSpecificVisit(string visitNr)
        {
            return Context.Set<DoctorAppointment>()
                          .Include(appointment => appointment.Patient)
                          .Include(appointment => appointment.ResponsibleNurse)
                          .SingleOrDefault(a => a.VisitNr.Equals(visitNr));
        }
        public List<DoctorAppointment> GetAll() 
        {

            return Context.Set<DoctorAppointment>()
                          .Include(appointment => appointment.Patient)
                          .Include(appointment => appointment.ResponsibleNurse)
                          .ToList();
        }
    }
}