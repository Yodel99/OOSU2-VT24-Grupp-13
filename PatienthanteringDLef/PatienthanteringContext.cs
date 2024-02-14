using Microsoft.EntityFrameworkCore;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace PatienthanteringDLef
{
    public class PatienthanteringContext : DbContext
    {     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=sqlutb2.hb.se,56077;Database=Patient;User ID=oosu2413;Password=GWL374;");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Patienthantering;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet <Anvandare> Anvandare { get; set; }
        public DbSet <Diagnos> Diagnoser { get; set; }
        public DbSet <LakarBesok> LakarBesok { get; set; }
        public DbSet <Lakemedelsrecept> Lakemedelsrecept { get; set; }
        public DbSet <Patient> Patienter { get; set; }
        
        public DbSet <VardPersonal> VardPersonal { get; set; }

        public void Datafyllning()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
            #region Vardpersonal
            var vardPersonal = new List<VardPersonal>
            {
                new VardPersonal{PersonNr = "19780706-1234", FNamn = "Karl", ENamn = "Karlsson", Email = "gokart69@gmail.com", AnstallningsNr = "A-1", YrkesRoll = "Läkare", Specialisering = "Ortoped"},
                new VardPersonal{PersonNr = "20010303-5783",FNamn = "Anders", ENamn = "Magnusson", Email = "landhockey420@gmail.com", AnstallningsNr = "A-2", YrkesRoll = "Receptionist"},
                new VardPersonal{PersonNr = "20010303-5783", FNamn = "Bengt", ENamn = "Bengtsson", Email = "hej123@live.se", AnstallningsNr = "A-3", YrkesRoll = "Sjuksköterska" },
                new VardPersonal{PersonNr = "20010303-5783", FNamn = "Agneta", ENamn = "Svensson", Email = "bollhaha@live.com", AnstallningsNr = "A-4",YrkesRoll = "Sjuksköterska" }
            };
            VardPersonal.AddRange(vardPersonal);
            SaveChanges();
            #endregion
            #region Anvandare
            var anvandare1 = new List<Anvandare>
            {
                new Anvandare{ InloggID ="lakare1", Losenord = "lakare1", VardPersonal = vardPersonal.Find(m => m.AnstallningsNr == "A-1") },
                new Anvandare{InloggID = "lakare2", Losenord = "lakare2",VardPersonal = vardPersonal.Find(m => m.AnstallningsNr == "A-2") },
                new Anvandare{InloggID ="lakare3",Losenord = "lakare3", VardPersonal = vardPersonal.Find(m => m.AnstallningsNr == "A-3") },
                new Anvandare{InloggID = "lakare4",Losenord = "lakare4", VardPersonal = vardPersonal.Find(m => m.AnstallningsNr == "A-4")}
            };
            Anvandare.AddRange(anvandare1); 
            SaveChanges();
            #endregion
            #region Patienter
            var patienter = new List<Patient>
            {
                new Patient{PersonNr = "19670512-4312", FNamn = "Jojje", ENamn = "Holmgren", Email = "jonte123@hotmail.com", PatientNr = "P-1", Adress = "Shommelomme vägen 1", TelNr = "0700123456"},
                new Patient{PersonNr = "19990823-4362", FNamn = "Jakob", ENamn = "Ia", Email = "jakesnake@hotmail.com", PatientNr = "P-2", Adress = "Falkberget 2", TelNr = "0702345323" },
                new Patient{PersonNr = "20050916-1612", FNamn = "Erik", ENamn = "Svensson", Email = "erco@hotmail.com", PatientNr = "P-3", Adress = "halmstadvägen 8", TelNr = "0702594563" }
            };
            Patienter.AddRange(patienter);
            SaveChanges();
            #endregion
            #region Recept
            var recept = new List<Lakemedelsrecept>
            {
                new Lakemedelsrecept{Patient = patienter.Find(m => m.PatientNr == "P-1"), LakemedelsNamn = "Ipren", Dosering = "1 karta per dag",Utskrivningsdatum = DateTime.Now, Anledning = "Växtvärk" },
                new Lakemedelsrecept{Patient = patienter.Find(m => m.PatientNr == "P-1"), LakemedelsNamn = "Alvedon", Dosering = "1 karta per dag", Utskrivningsdatum = DateTime.Now, Anledning = "Värk" },
                new Lakemedelsrecept{Patient = patienter.Find(m => m.PatientNr == "P-2"), LakemedelsNamn = "Strepsils", Dosering = "1 karta per dag", Utskrivningsdatum = DateTime.Now, Anledning = "Halsvärk" }
            };
            Lakemedelsrecept.AddRange(recept);
            SaveChanges();
            #endregion
            #region Besök
            var lakarBesok = new List<LakarBesok>
            {
                new LakarBesok{BesokNr = "B-1", Datum = DateTime.Now, Syfte = "Haltar med benet", Patient = patienter.Find(m => m.PatientNr == "P-1"), AnsvarigLakare = vardPersonal.Find(m => m.AnstallningsNr == "A-1") }
            };
            LakarBesok.AddRange(lakarBesok);
            SaveChanges();
            #endregion
            #region Diagnoser
            var diagnoser = new List<Diagnos>
            {
                new Diagnos{Patient = patienter.Find(m => m.PatientNr == "P-1"), Diagnosbeskrivning = "Brutet ben", Datum = DateTime.Now, Behandling = "Rehab 1 gång i veckan" }
            };
            Diagnoser.AddRange(diagnoser);
            SaveChanges();
            #endregion
        }
    }
}
