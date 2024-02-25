using Microsoft.EntityFrameworkCore;
using PatienthanteringEL;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PatienthanteringDLef
{
    public class DrugPrescriptionRepository : Repository<DrugPrescription>
    {
        public DrugPrescriptionRepository(PatientMSContext context) : base(context) { }
        public List<DrugPrescription> GetAll()
        {
            return Context.Set<DrugPrescription>().Include(p => p.Patient).ToList();
        }
    }
}