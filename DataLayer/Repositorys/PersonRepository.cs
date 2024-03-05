using EnityLayer;

namespace DataLayer
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(PatientMSContext context) : base(context) { }
    }
}