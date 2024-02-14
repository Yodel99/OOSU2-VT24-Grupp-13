using PatienthanteringEL;

namespace PatienthanteringDLef
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(PatientMSContext context) : base(context) { }
    }
}