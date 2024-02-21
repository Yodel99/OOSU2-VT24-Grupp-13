using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringDLef.DataSeed
{
    public class DataSeed
    {
        public static void Fill(PatientMSContext context)
        {
            #region Hårdkodade Vårdpersonaler
            NursingStaff nursingStaff1 = new NursingStaff("19780706-1234", "Karl", "Karlsson", "gokart69@gmail.com", "A-1", "Läkare", "Ortoped");
            NursingStaff nursingStaff2 = new NursingStaff("20010303-5783", "Anders", "Magnusson", "landhockey420@gmail.com", "A-2", "Receptionist");
            NursingStaff nursingStaff3 = new NursingStaff("20010303-5783", "Bengt", "Bengtsson", "hej123@live.se", "A-3", "Sjuksköterska");
            NursingStaff nursingStaff4 = new NursingStaff("20010303-5783", "Agneta", "Svensson", "bollhaha@live.com", "A-4", "Sjuksköterska");

            context.NursingStaffs.Add(nursingStaff1);
            context.NursingStaffs.Add(nursingStaff2);
            context.NursingStaffs.Add(nursingStaff3);
            context.NursingStaffs.Add(nursingStaff4);
            #endregion

            #region Hårdkodade Användare
            context.Users.Add(new User("lakare1", "lakare1", nursingStaff1));
            context.Users.Add(new User("lakare2", "lakare2", nursingStaff2));
            context.Users.Add(new User("lakare3", "lakare3", nursingStaff3));
            context.Users.Add(new User("lakare4", "lakare4", nursingStaff4));
            #endregion

            #region Hårdkodade Patienter
            Patient patient1  = new Patient("19670512-4312", "Jojje", "Holmgren", "jonte123@hotmail.com", "P-1", "Shommelomme vägen 1", "0700123456");
            Patient patient2 = new Patient("19990823-4362", "Jakob", "Ia", "jakesnake@hotmail.com", "P-2", "Falkberget 2", "0702345323");
            Patient patient3 = new Patient("20050916-1612", "Erik", "Svensson", "erco@hotmail.com", "P-3", "halmstadvägen 8", "0702594563");
          
            context.Patients.Add(patient1);           
            context.Patients.Add(patient2);
            context.Patients.Add(patient3);
            #endregion

            #region Hårkodade Recept
            context.DrugPrescriptions.Add(new DrugPrescription(patient1, "Ipren", "1 karta per dag", DateTime.Now, "Växtvärk"));
            context.DrugPrescriptions.Add(new DrugPrescription(patient1, "Alvedon", "1 karta per dag", DateTime.Now, "Värk"));
            context.DrugPrescriptions.Add(new DrugPrescription(patient2, "Strepsils", "1 karta per dag", DateTime.Now, "Halsvärk"));
            #endregion

            #region Hårdkodade Läkarbesök
            context.DoctorAppointments.Add(new DoctorAppointment("B-1", DateTime.Now, "Haltar med benet", patient1, nursingStaff1));
            #endregion

            #region Hårdkodade Diagnoser
            Diagnos diagnos1 = new Diagnos(patient1, "Brutet ben", DateTime.Now, "Rehab 1 gång i veckan");
            context.Diagnosis.Add(diagnos1);
            #endregion

            context.SaveChanges();
        }

        //public void Datafyllning()
        //{
        //    Database.EnsureDeleted();
        //    Database.EnsureCreated();
        //    #region Vardpersonal
        //    var vardPersonal = new List<NursingStaff>
        //    {
        //        new NursingStaff{SSN = "19780706-1234", FName = "Karl", EName = "Karlsson", Email = "gokart69@gmail.com", StaffNr = "A-1", Profession = "Läkare", Specialization = "Ortoped"},
        //        new NursingStaff{SSN = "20010303-5783",FName = "Anders", EName = "Magnusson", Email = "landhockey420@gmail.com", StaffNr = "A-2", Profession = "Receptionist"},
        //        new NursingStaff{SSN = "20010303-5783", FName = "Bengt", EName = "Bengtsson", Email = "hej123@live.se", StaffNr = "A-3", Profession = "Sjuksköterska" },
        //        new NursingStaff{SSN = "20010303-5783", FName = "Agneta", EName = "Svensson", Email = "bollhaha@live.com", StaffNr = "A-4",Profession = "Sjuksköterska" }
        //    };
        //    NursingStaffs.AddRange(vardPersonal);
        //    SaveChanges();
        //    #endregion
        //    #region Anvandare
        //    var anvandare1 = new List<User>
        //    {
        //        new User{LogginID ="lakare1", Password = "lakare1", NursingStaff = vardPersonal.Find(m => m.StaffNr == "A-1") },
        //        new User{LogginID ="lakare2", Password = "lakare2",NursingStaff = vardPersonal.Find(m => m.StaffNr == "A-2") },
        //        new User{LogginID ="lakare3",Password = "lakare3", NursingStaff = vardPersonal.Find(m => m.StaffNr == "A-3") },
        //        new User{LogginID ="lakare4",Password = "lakare4", NursingStaff = vardPersonal.Find(m => m.StaffNr == "A-4")}
        //    };
        //    Users.AddRange(anvandare1);
        //    SaveChanges();
        //    #endregion
        //    #region Patienter
        //    var patienter = new List<Patient>
        //    {
        //        new Patient{SSN = "19670512-4312", FName = "Jojje", EName = "Holmgren", Email = "jonte123@hotmail.com", PatientNr = "P-1", Address = "Shommelomme vägen 1", TelNr = "0700123456"},
        //        new Patient{SSN = "19990823-4362", FName = "Jakob", EName = "Ia", Email = "jakesnake@hotmail.com", PatientNr = "P-2", Address = "Falkberget 2", TelNr = "0702345323" },
        //        new Patient{SSN = "20050916-1612", FName = "Erik", EName = "Svensson", Email = "erco@hotmail.com", PatientNr = "P-3", Address = "halmstadvägen 8", TelNr = "0702594563" }
        //    };
        //    Patients.AddRange(patienter);
        //    SaveChanges();
        //    #endregion
        //    #region Recept
        //    var recept = new List<DrugPrescription>
        //    {
        //        new DrugPrescription{Patient = patienter.Find(m => m.PatientNr == "P-1"), DrugName = "Ipren", Dosage = "1 karta per dag",IssueDate = DateTime.Now, Reason = "Växtvärk" },
        //        new DrugPrescription{Patient = patienter.Find(m => m.PatientNr == "P-1"), DrugName = "Alvedon", Dosage = "1 karta per dag", IssueDate = DateTime.Now, Reason = "Värk" },
        //        new DrugPrescription{Patient = patienter.Find(m => m.PatientNr == "P-2"), DrugName = "Strepsils", Dosage = "1 karta per dag", IssueDate = DateTime.Now, Reason = "Halsvärk" }
        //    };
        //    DrugPrescriptions.AddRange(recept);
        //    SaveChanges();
        //    #endregion
        //    #region Besök
        //    var lakarBesok = new List<DoctorAppointment>
        //    {
        //        new DoctorAppointment{VisitNr = "B-1", Datum = DateTime.Now, Syfte = "Haltar med benet", Patient = patienter.Find(m => m.PatientNr == "P-1"), AnsvarigLakare = vardPersonal.Find(m => m.StaffNr == "A-1") }
        //    };
        //    DoctorAppointments.AddRange(lakarBesok);
        //    SaveChanges();
        //    #endregion
        //    #region Diagnoser
        //    var diagnoser = new List<Diagnos>
        //    {
        //        new Diagnos{Patient = patienter.Find(m => m.PatientNr == "P-1"), DiagnosDescription = "Brutet ben", Date = DateTime.Now, Treatment = "Rehab 1 gång i veckan" }
        //    };
        //    Diagnosis.AddRange(diagnoser);
        //    SaveChanges();
        //    #endregion
        //}
    }
}
