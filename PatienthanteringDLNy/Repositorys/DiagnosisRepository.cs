using Microsoft.EntityFrameworkCore;
using PatienthanteringELNy;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace PatienthanteringDLNy
{
    public class DiagnosisRepository : Repository<Diagnosis>
    {
        public DiagnosisRepository(PatientMSContext context) : base(context) { }
        public List<Diagnosis> GetAll()
        {
            return Context.Set<Diagnosis>().Include(p => p.Patient).ToList();
        }
    }
    
}