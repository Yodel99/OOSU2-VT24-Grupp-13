using Microsoft.EntityFrameworkCore;
using EnityLayer;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
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