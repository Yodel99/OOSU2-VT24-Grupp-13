using EnityLayer;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    public class AddPatientViewModel : ObservableObject
    {
        // ListBox
        private GetListsController getListsController;

        private List<Patient> patients = null;

        public List<Patient> Patients
        {
            get => patients;
            set { patients = (List<Patient>)getListsController.GetPatients(); }
        }



        //public AddPatientViewModel()
        //{
        //    getListsController = new GetListsController();
        //    Patients = new List<Patient>();
        //}

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // Textboxes och labels
        private ObservableCollection<Patient> patientss = new ObservableCollection<Patient>();
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public ObservableCollection<Patient> Patientss
        {
            get => patientss;
            set { patientss = value; OnPropertyChanged(); }

        }
        public ObservableCollection<Person> People
        {
            get => People;
            set { People = value; OnPropertyChanged(); }

        }

        private string ssn;
        public string SSN
        {
            get => ssn;
            set { ssn = value; OnPropertyChanged(); }
        }

        private string fName;
        public string fname
        {
            get => fName;
            set { fName = value; OnPropertyChanged(); }
        }

        private string eName;
        public string ename
        {
            get => eName;
            set { eName = value; OnPropertyChanged(); }
        }

        private string eMail;
        public string email
        {
            get => eMail;
            set { eMail = value; OnPropertyChanged(); }
        }

        private string patientNr;
        public string patientnr
        {
            get => patientNr;
            set { patientNr = value; OnPropertyChanged(); }
        }

        private string adress;
        public string Adress
        {
            get => adress;
            set { adress = value; OnPropertyChanged(); }
        }

        private string telNr;
        public string telnr
        {
            get => telNr;
            set { telNr = value; OnPropertyChanged(); }
        }


        // Add kanpp

        //public ObservableCollection<Patient> Patients_
        //{
        //    get { return Patients; }
        //    set
        //    {
        //        if (Patients != value )
        //        {
        //            Patients = value;
        //            OnPropertyChanged(nameof(Patients));
        //        }
        //    }
        //}

        public void AddPatient(string ssn, string fName, string eName, string email, string patientNr, string address, string telNr)
        {
            var newPatient = new Patient
            {
                SSN = ssn,
                FName = fName,
                EName = eName,
                Email = email,
                PatientNr = patientNr,
                Address = address,
                TelNr = telNr
            };

            Patients.Add(newPatient);

            ssn = fName = eName = email = patientNr = adress = telNr = string.Empty;
        }

        public RelayCommand RegisterPatientCommand => new RelayCommand(_execute => AddPatient(SSN, fname, ename,email,patientnr, Adress, telnr ));

      

        public AddPatientViewModel()
        {
            getListsController = new GetListsController();
            RegisterPatientController RP = new RegisterPatientController();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
        }



    }
}
