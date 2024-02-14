using PatienthanteringDL;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringAL
{
    public class HanteraBesokController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public IList<Patient> HamtaPatienter()
        {
            List<Patient> patienter = new List<Patient>();
            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                patienter.Add(patient);
            }
            return patienter;
        }
        public IList<VardPersonal> ListaSjukSkotare()
        {
            List<VardPersonal> sjukSkjotare = new List<VardPersonal>();
            foreach (VardPersonal personal in unitOfWork.VardPersonalRepository.Find(m => m.AnstallningsNr != null))
            {
                if (personal.YrkesRoll == "Sjuksköterska")
                {
                    sjukSkjotare.Add(personal);
                }
            }
            return sjukSkjotare;
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
        public void LaggTillBesok(LakarBesok besok)
        {
            unitOfWork.LakarBesokRepository.Add(besok);
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
        public void AndraDatum(LakarBesok lakarBesok)
        {
            TaBortBesok(lakarBesok.BesokNr);
            LaggTillBesok(lakarBesok);
        }
    }
}
