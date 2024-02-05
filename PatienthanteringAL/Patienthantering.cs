﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using PatienthanteringDL;
using PatienthanteringEL;

namespace PatienthanteringAL
{
    public class Patienthantering
    {
        public Patienthantering() { }

        public IList<Patient> HamtaPatienter()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            List<Patient> patienter = new List<Patient>();   
            
            foreach (Patient patient in unitOfWork.PatientRepository.Find(m => m.PatientNr != null))
            {
                    patienter.Add(patient);
            }
            return patienter;                                      
        }

        public void UppdateraPatientInfo(string valdPatientID, string valdAttribut, string valdInput)
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            foreach (Patient patient in unitOfWork.PatientRepository.Find(p => p.PatientNr.ToLower().Equals(valdPatientID)))
            {

                if (valdAttribut.Equals("personnr"))
                {
                    patient.PersonNr = valdInput;
                }
                else if (valdAttribut.Equals("fnamn"))
                {
                    patient.FNamn = valdInput;
                }
                else if (valdAttribut.Equals("enamn"))
                {
                    patient.ENamn = valdInput;
                }
                else if (valdAttribut.Equals("email"))
                {
                    patient.Email = valdInput;
                }
                else if (valdAttribut.Equals("adress"))
                {
                    patient.Adress = valdInput;
                }
                else if (valdAttribut.Equals("telnr"))
                {
                    patient.TelNr = valdInput;
                }
            }
        }

        private UnitOfWork unitOfWork = new UnitOfWork();

        public IList<Patient> ListaPatienter()
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
                if (personal.YrkesRoll== "Sjuksköterska")
                {
                    sjukSkjotare.Add(personal);
                }
            }
            return sjukSkjotare;
        }
        public IList<LakarBesok>ListaBesok()
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
