using PatienthanteringELNy;

namespace PatienthanteringDLNy
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(PatientMSContext context) : base(context) { }
    }
}