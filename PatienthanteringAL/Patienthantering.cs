using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringEL;
using PatienthanteringDL;
using PatienthanteringEL;
using PatienthanteringDLef;

namespace PatienthanteringAL
{
    public class Patienthantering
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public Patienthantering() { }
        public Anvandare GetAnvandare(string inloggID, string losenord)
        {

            new PatienthanteringContext();

            UnitOfWork unitOfWork = new UnitOfWork();
            foreach (Anvandare anvandare in unitOfWork.AnvandareRepository.Find(a => a.InloggID.Equals(inloggID)))
            {
                if (losenord.Equals(anvandare.Losenord))
                {
                    return anvandare;
                }
            }
            return null;
        }       

        public IList<Patient> HamtaPatienter()
        {         
            List<Patient> patienter = new List<Patient>(); 
            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null)) 
            { 
                patienter.Add(patient); 
            }
            return patienter;
        }

        public void RegistreraPatient(string personNmr, string fnamn,string enamn,string email, string patientNmr, string adress, string telNmr )
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Patient patient = new Patient(personNmr, fnamn, enamn, email, patientNmr, adress, telNmr);
            unitOfWork.PatientRepository.Add(patient);
        }
        
        public Diagnos SkapaDiagnos(Patient selectedpatient, string behandling, string diagnosbeskrivning)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Diagnos diagnos = new Diagnos(selectedpatient, diagnosbeskrivning, DateTime.Now, behandling);
            unitOfWork.DiagnosRepository.Add(diagnos);
            return diagnos;
           
        }       

        public void LaggTillDiagnosTillKund(Patient selectedpatient, Diagnos diagnos)
        {
            
            UnitOfWork unitOfWork = new UnitOfWork();
            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr == selectedpatient.PatientNr))
            {
                patient.Diagnoser.Add(diagnos);
            }
                      
        }

        public IList<Diagnos> HamtaDiagnoser(Patient selectedpatient)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            List<Diagnos> diagnoser = new List<Diagnos>();

            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr == selectedpatient.PatientNr))
            {
                diagnoser = patient.Diagnoser;
            }
            return diagnoser;
        }

        public Lakemedelsrecept SkapaRecept(Patient selectedpatient, string lakemedel, string dosering, string anledning)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Lakemedelsrecept lakemedelsrecept = new Lakemedelsrecept(selectedpatient, lakemedel, dosering, DateTime.Now, anledning);
            unitOfWork.BehandlingRepository.Add(lakemedelsrecept);
            return lakemedelsrecept;
        }

        public IList<Lakemedelsrecept> HamtaRecept(Patient selectedpatient)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            List<Lakemedelsrecept> lakemedelsrecepts = new List<Lakemedelsrecept>();

            foreach (Lakemedelsrecept lakemedelsrecept in unitOfWork.BehandlingRepository.Find(m => m.Patient.PatientNr == selectedpatient.PatientNr))
            {
                lakemedelsrecepts.Add(lakemedelsrecept);
            }
            return lakemedelsrecepts;

        }
        
     
        public IList<VardPersonal> ListaSjukSkotare()
        {
            List<VardPersonal> sjukSkjotare = new List<VardPersonal>();
            foreach (VardPersonal personal in unitOfWork.VardPersonalRepository.Find(m => m.AnstallningsNr != null))
            {
                if (personal.YrkesRoll== "Sjuksköterska")
                {
                    sjukSkjotare.Add(personal);
                }
            }
            return sjukSkjotare;
        }
        public IList<LakarBesok> ListaBesok()
        {
            List<LakarBesok> lakarBesok = new List<LakarBesok>();

            foreach (LakarBesok lakarBesok1 in unitOfWork.LakarBesokRepository.Find(m => m.BesokNr != null))
            {

                lakarBesok.Add(lakarBesok1);

            }
            return lakarBesok;

        }
        public Patient HamtaPatient(string patientnummer)
        {

            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                if (patient.PatientNr == patientnummer)
                {
                    return patient;
                }
                
            }
            return null;
        }
        public LakarBesok HamtaBesok(string besokNr)
        {
            foreach (LakarBesok besok in unitOfWork.LakarBesokRepository.Find(m => m.PatientNr != null))
            {
                if (besok.BesokNr == besokNr)
                {
                    return besok;
                }

            }
            return null;
        }
        public VardPersonal HamtaLakare(string anstallningsnummer)
        {
            foreach (VardPersonal personal in unitOfWork.VardPersonalRepository.Find(m => m.AnstallningsNr != null))
            {
                if (personal.AnstallningsNr == anstallningsnummer)
                {
                    return personal;
                }
            }
            return null;
        }
        
        public void LaggTillBesok(LakarBesok besok)
        {
            unitOfWork.LakarBesokRepository.Add(besok);
        }
        public void TaBortBesok(string besokNr)
        {
       
            foreach (LakarBesok lakarBesok1 in unitOfWork.LakarBesokRepository.Find(m => m.BesokNr != null))
            {
                if (lakarBesok1.BesokNr == besokNr)
                {
                    unitOfWork.LakarBesokRepository.Remove(lakarBesok1);
                    break;
                }

            }
            
        }
        public void AndraDatum(LakarBesok lakarBesok)
        {
            TaBortBesok(lakarBesok.BesokNr);
            LaggTillBesok(lakarBesok);
        }
    }
}
