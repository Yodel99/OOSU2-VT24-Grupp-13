using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringEL;


namespace PatienthanteringDL
{
    public class UnitOfWork
    {
        

        public Repository<Anvandare> AnvandareRepository
        {
            get; private set;
        }

        public Repository<Lakemedelsrecept> BehandlingRepository
        {
            get; private set;
        }
        public Repository<Diagnos> DiagnosRepository
        {
            get; private set;
        }
        public Repository<LakarBesok> LakarBesokRepository
        {
            get; private set;
        }
        public Repository<Person> PersonRepository
        {
            get; private set;
        }
        public Repository<VardPersonal> VardPersonalRepository
        {
            get; private set;
        }
        public Repository<Patient> PatientRepository
        {
            get; private set;
        }
                    
        private static UnitOfWork instans = null;
        public static UnitOfWork GetInstance()
        {
            if (instans == null)
            {
                instans = new UnitOfWork();
            }
            return instans;
        }

        /// <summary>
        ///  Create a new instance.
        /// </summary>
        public UnitOfWork()
        {
            AnvandareRepository = new Repository<Anvandare>();
            BehandlingRepository = new Repository<Lakemedelsrecept>();
            DiagnosRepository = new Repository<Diagnos>();
            LakarBesokRepository = new Repository<LakarBesok>();
            PersonRepository = new Repository<Person>();
            VardPersonalRepository = new Repository<VardPersonal>();
            PatientRepository = new Repository<Patient>();

            // Initialize the tables if this is the first UnitOfWork.
            if (AnvandareRepository.IsEmpty())
            {
                Fill();
            }
        }
        
        /// <summary>
        ///  Save the changes made. Does nothing in this case.
        /// </summary>
        public void Save()
        { }

        private void Fill()
        {
            #region Hårdkodade Vårdpersonaler
            VardPersonalRepository.Add(new VardPersonal("19780706-1234", "Karl", "Karlsson", "gokart69@gmail.com", "A-1", "Läkare", "Ortoped"));
            VardPersonalRepository.Add(new VardPersonal("20010303-5783", "Anders", "Magnusson", "landhockey420@gmail.com", "A-2", "Receptionist"));
            VardPersonalRepository.Add(new VardPersonal("20010303-5783", "Bengt", "Bengtsson", "hej123@live.se", "A-3", "Sjuksköterska"));
            VardPersonalRepository.Add(new VardPersonal("20010303-5783", "Agneta", "Svensson", "bollhaha@live.com", "A-4", "Sjuksköterska"));
            #endregion

            

            #region Hårdkodade Användare
            AnvandareRepository.Add(new Anvandare("lakare1", "lakare1", VardPersonalRepository.FirstOrDefault(m => m.AnstallningsNr == "A-1")));
            AnvandareRepository.Add(new Anvandare("lakare2", "lakare2", VardPersonalRepository.FirstOrDefault(m => m.AnstallningsNr == "A-2")));
            AnvandareRepository.Add(new Anvandare("lakare3", "lakare3", VardPersonalRepository.FirstOrDefault(m => m.AnstallningsNr == "A-3")));
            AnvandareRepository.Add(new Anvandare("lakare4", "lakare4", VardPersonalRepository.FirstOrDefault(m => m.AnstallningsNr == "A-4")));
            #endregion

            #region Hårdkodade Patienter
            PatientRepository.Add(new Patient("19670512-4312", "Jojje", "Holmgren", "jonte123@hotmail.com", "P-1", "Shommelomme vägen 1", "0700123456"));
            PatientRepository.Add(new Patient("19990823-4362", "Jakob", "Ia", "jakesnake@hotmail.com", "P-2", "Falkberget 2", "0702345323"));
            PatientRepository.Add(new Patient("20050916-1612", "Erik", "Svensson", "erco@hotmail.com", "P-3", "halmstadvägen 8", "0702594563"));
            #endregion

            #region Hårkodade Recept
            BehandlingRepository.Add(new Lakemedelsrecept(PatientRepository.FirstOrDefault(m => m.PatientNr == "P-1"), "Ipren", "1 karta per dag", DateTime.Now, "Växtvärk"));
            BehandlingRepository.Add(new Lakemedelsrecept(PatientRepository.FirstOrDefault(m => m.PatientNr == "P-1"), "Alvedon", "1 karta per dag", DateTime.Now, "Värk"));
            BehandlingRepository.Add(new Lakemedelsrecept(PatientRepository.FirstOrDefault(m => m.PatientNr == "P-2"), "Strepsils", "1 karta per dag", DateTime.Now, "Halsvärk"));
            #endregion

            #region Hårdkodade Läkarbesök
            LakarBesokRepository.Add(new LakarBesok("B-1", DateTime.Now, "Haltar med benet", PatientRepository.FirstOrDefault(m => m.PatientNr == "P-1"), VardPersonalRepository.FirstOrDefault(m => m.AnstallningsNr == "A-1")));
            #endregion

            #region Hårdkodade Diagnoser
            DiagnosRepository.Add(new Diagnos(PatientRepository.FirstOrDefault(m => m.PatientNr == "P-1"), "Brutet ben", DateTime.Now, "Rehab 1 gång i veckan"));
            #endregion

        }

        

    }
}
